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
    public partial class AssociationForm : Form
    {
        private Association association;
        private CultureInfo culture;
        private ResourceManager ressourceManager;
        private ISession session;

        public AssociationForm()
        {
            PrepareForm();
            association = new Association();
        }

        public AssociationForm(int id)
        {
            PrepareForm();
            association = session.Load<Association>(id);
            nameTextBox.Text = association.Name;
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
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.AssociationForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.nameLabel.Text = ressourceManager.GetString("name", culture);
            this.submitButton.Text = ressourceManager.GetString("submit", culture);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            association.Name = this.nameTextBox.Text;
            session.SaveOrUpdate(association);
            session.Flush();
            session.Close();
            Close();
        }

        private void AssociationForm_Closing(object sender, CancelEventArgs e)
        {
            session.Close();
        }
    }
}
