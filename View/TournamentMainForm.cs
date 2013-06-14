using NHibernate;
using SuecaTournamentManager.Domain;
using SuecaTournamentManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace SuecaTournamentManager.View
{
    public partial class TournamentMainForm : Form
    {
        private int tournamentID;
        
        private CultureInfo culture;
        private ResourceManager ressourceManager;

        public TournamentMainForm()
        {
            InitializeComponent();
            LoadRessources(); ;
        }

        public TournamentMainForm(int tournamentID)
        {
            InitializeComponent();
            LoadRessources();

            this.tournamentID = tournamentID;
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.TournamentMainForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            ISession session = DatabaseManager.Instance.OpenSession();
            IList<Object> matches = session.QueryOver<Object>("Match").List();
            SelectionForm selection = new SelectionForm(matches);
            selection.ShowDialog();

            // Get selection result
            Match match = (Match) selection.getSelection();

            if (match != null)
            {
                MatchForm matchForm = new MatchForm(match.Id);
                matchForm.ShowDialog();
            }
            session.Close();
        }
    }
}
