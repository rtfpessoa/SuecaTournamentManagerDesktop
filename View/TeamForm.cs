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
using Iesi.Collections.Generic;

namespace SuecaTournamentManager.View
{
    public partial class TeamForm : Form
    {
        private Team team;
        private CultureInfo culture;
        private ResourceManager ressourceManager;
        private ISession session;

        public TeamForm()
        {
            PrepareForm();
            team = new Team();
        }

        public TeamForm(int id)
        {
            PrepareForm();
            team = session.Load<Team>(id);
            name1TextBox.Text = team.Name1;
            name2TextBox.Text = team.Name2;
        }

        private void PrepareForm()
        {
            InitializeComponent();
            LoadRessources();
            session = DatabaseManager.Instance.OpenSession();
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.TeamForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.namesLabel.Text = ressourceManager.GetString("names", culture);
            this.namesButton.Text = ressourceManager.GetString("submit", culture);
        }

        private void namesButton_Click(object sender, EventArgs e)
        {
            team.Name1 = this.name1TextBox.Text;
            team.Name2 = this.name2TextBox.Text;
            session.SaveOrUpdate(team);
            session.Flush();
            session.Close();
            Close();
        }

        private void TeamForm_Closing(object sender, CancelEventArgs e)
        {
            session.Close();
        }
    }
}
