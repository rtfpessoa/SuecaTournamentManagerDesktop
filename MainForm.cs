using NHibernate;
using NHibernate.Cfg;
using System.Reflection;
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
using SuecaTournamentManager.Utils;

namespace SuecaTournamentManager
{
    public partial class MainForm : Form
    {
        private CultureInfo culture;
        private ResourceManager ressourceManager;

        public MainForm()
        {
            InitializeComponent();

            LoadRessources();

            //this.Icon = new Icon("Ressources/icon.ico");

            /* Setup SQLite database schema and connection factory */
            DatabaseManager.Instance.OpenSession();
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            /* Force language
             * culture = CultureInfo.CreateSpecificCulture("pt-PT");
             */
            ressourceManager = new ResourceManager("SuecaTournamentManager.MainForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.startButton.Text = ressourceManager.GetString("start", culture);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form start = new View.StartForm();
            start.Show();

        }
    }
}
