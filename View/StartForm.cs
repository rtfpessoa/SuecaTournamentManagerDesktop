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
            this.Name = ressourceManager.GetString("form_name", culture);
            this.Text = "STM | " + this.Name;
            this.newTournamentButton.Text = ressourceManager.GetString("new_tournament_btn", culture);
            this.newAssociationButton.Text = ressourceManager.GetString("new_association_btn", culture);
            this.newTeamButton.Text = ressourceManager.GetString("new_team_btn", culture);
            this.loadTournamentButton.Text = ressourceManager.GetString("load", culture);
            this.editAssociationButton.Text = ressourceManager.GetString("edit", culture);
            this.editTeamButton.Text = ressourceManager.GetString("edit", culture);
            this.loadTournamentLabel.Text = ressourceManager.GetString("tournaments", culture);
            this.editAssociationLabel.Text = ressourceManager.GetString("associations", culture);
            this.editTeamLabel.Text = ressourceManager.GetString("teams", culture);
        }

        private void newTournamentButton_Click(object sender, EventArgs e)
        {
            Form tournament = new TournamentForm();
            tournament.Show();
        }

        private void newTeamButton_Click(object sender, EventArgs e)
        {
            Form team = new TeamForm();
            team.Show();
        }

        private void newAssociationButton_Click(object sender, EventArgs e)
        {
            Form association = new AssociationForm();
            association.Show();
        }
    }
}
