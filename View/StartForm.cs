using System;
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
using SuecaTournamentManager.Utils;
using NHibernate;
using SuecaTournamentManager.Domain;

namespace SuecaTournamentManager.View
{
    public partial class StartForm : Form
    {
        private CultureInfo culture;
        private ResourceManager ressourceManager;

        public StartForm()
        {
            InitializeComponent();

            LoadRessources();
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            /* Force language
             * culture = CultureInfo.CreateSpecificCulture("pt-PT");
             */
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.StartForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.newTournamentButton.Text = ressourceManager.GetString("new_tournament_btn", culture);
            this.newAssociationButton.Text = ressourceManager.GetString("new_association_btn", culture);
            this.newTeamButton.Text = ressourceManager.GetString("new_team_btn", culture);
            this.loadTournamentButton.Text = ressourceManager.GetString("load_tournament", culture);
            this.editAssociationButton.Text = ressourceManager.GetString("edit_association", culture);
            this.editTeamButton.Text = ressourceManager.GetString("edit_team", culture);
        }

        private void newTournamentButton_Click(object sender, EventArgs e)
        {
            Form tournament = new TournamentForm();
            tournament.ShowDialog();
        }

        private void newTeamButton_Click(object sender, EventArgs e)
        {
            Form team = new TeamForm();
            team.ShowDialog();
        }

        private void newAssociationButton_Click(object sender, EventArgs e)
        {
            Form association = new AssociationForm();
            association.ShowDialog();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            IList<Object> tournaments = session.QueryOver<Object>("Tournament").List();
            SelectionForm selection = new SelectionForm(tournaments);
            selection.ShowDialog();
            
            // Get selection result
            Tournament tournament = (Tournament) selection.getSelection();
            
            session.Close();
            
            if (tournament != null)
            {
                Form tournamentSetupForm = new TournamentSetupForm(tournament.Id);
                tournamentSetupForm.Show();
                Close();
            }
        }

        private void editAssociationButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            IList<Object> associations = session.QueryOver<Object>("Association").List();
            SelectionForm selection = new SelectionForm(associations);
            selection.ShowDialog();

            // Get selection result
            Association association = (Association)selection.getSelection();

            if (association != null)
            {
                AssociationForm associationForm = new AssociationForm(association.Id);
                associationForm.ShowDialog();
            }
        }

        private void editTeamButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            IList<Object> teams = session.QueryOver<Object>("Team").List();
            SelectionForm selection = new SelectionForm(teams);
            selection.ShowDialog();

            // Get selection result
            Team team = (Team)selection.getSelection();

            if (team != null)
            {
                TeamForm teamForm = new TeamForm(team.Id);
                teamForm.ShowDialog();
            }
        }
    }
}
