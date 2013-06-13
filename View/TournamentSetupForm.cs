using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Reflection;
using NHibernate;
using NHibernate.Criterion;
using SuecaTournamentManager.Domain;
using SuecaTournamentManager.Utils;

namespace SuecaTournamentManager.View
{
    public partial class TournamentSetupForm : Form
    {
        private int tournamentId;
        
        private CultureInfo culture;
        private ResourceManager ressourceManager;

        public TournamentSetupForm(int tournamentId)
        {
            this.tournamentId = tournamentId;
            InitializeComponent();
            LoadRessources();
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.TournamentSetupForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.addAssociationButton.Text = ressourceManager.GetString("add", culture);
            this.addTeamButton.Text = ressourceManager.GetString("add", culture);
            this.removeAssociationsLabel.Text = ressourceManager.GetString("associations", culture);
            this.removeAssociationsButton.Text = ressourceManager.GetString("remove", culture);
            this.removeTeamLabel.Text = ressourceManager.GetString("teams", culture);
            this.removeTeamButton.Text = ressourceManager.GetString("remove", culture);
            this.startTournamentButton.Text = ressourceManager.GetString("start_tournament", culture);
        }

        private void addAssociationButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            IList<Object> associations = session.CreateCriteria<Association>().Add(Restrictions.IsEmpty("Tournaments")).List<Object>();
            SelectionForm selection = new SelectionForm(associations);
            selection.ShowDialog();

            // Get selection result
            Association association = (Association) selection.getSelection();

            Tournament tournament = session.Load<Tournament>(tournamentId);

            if(association != null)
            {
                tournament.Associations.Add(association);
                session.Flush();
            }
            session.Close();
        }

        private void removeAssociationsButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();

            Tournament tournament = session.Load<Tournament>(tournamentId);

            SelectionForm selection = new SelectionForm(tournament.Associations);
            selection.ShowDialog();

            // Get selection result
            Association association = (Association) selection.getSelection();

            if (association != null)
            {
                tournament.Associations.Remove(association);
                session.Flush();
            }
            session.Close();
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            IList<Object> teams = session.CreateCriteria<Team>().Add(Restrictions.IsEmpty("Tournaments")).List<Object>();
            SelectionForm selection = new SelectionForm(teams);
            selection.ShowDialog();

            // Get selection result
            Team team = (Team)selection.getSelection();

            Tournament tournament = session.Load<Tournament>(tournamentId);

            if (team != null)
            {
                tournament.Teams.Add(team);
                session.Flush();
            }
            session.Close();
        }

        private void removeTeamButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            Tournament tournament = session.Load<Tournament>(tournamentId);
            SelectionForm selection = new SelectionForm(tournament.Teams);
            selection.ShowDialog();

            // Get selection result
            Team team = (Team)selection.getSelection();

            if (team != null)
            {
                tournament.Teams.Remove(team);
                session.Flush();
            }
            session.Close();
        }
    }
}
