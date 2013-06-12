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
            this.Name = ressourceManager.GetString("form_name", culture);
            this.Text = "SMT | " + this.Name;
            this.tournamentLabel.Text = ressourceManager.GetString("name", culture);
            this.tournamentButton.Text = ressourceManager.GetString("submit", culture);
        }

        private void tournamentButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
