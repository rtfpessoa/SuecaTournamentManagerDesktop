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
using NHibernate;
using SuecaTournamentManager.Utils;
using SuecaTournamentManager.Domain;

namespace SuecaTournamentManager.View
{
    public partial class TournamentForm : Form
    {
        private CultureInfo culture;
        private ResourceManager ressourceManager;

        public TournamentForm()
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
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.TournamentForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.tournamentLabel.Text = ressourceManager.GetString("name", culture);
            this.tournamentButton.Text = ressourceManager.GetString("submit", culture);
            this.onlyTeamsButton.Text = ressourceManager.GetString("team_competition", culture);
            this.teamsAndAssociationsButton.Text = ressourceManager.GetString("team_association_competition", culture);
        }

        private void tournamentButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            Tournament tournament = new Tournament();
            tournament.Name = this.tournamentTextBox.Text;
            session.Save(tournament);
            session.Close();
            Close();
        }
    }
}
