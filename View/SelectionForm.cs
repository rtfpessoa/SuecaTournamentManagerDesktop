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
using SuecaTournamentManager.Domain;
using Iesi.Collections;

namespace SuecaTournamentManager.View
{
    public partial class SelectionForm : Form
    {
        private CultureInfo culture;
        private ResourceManager ressourceManager;
        private Object selection;

        public SelectionForm(IEnumerable<Object> options)
        {
            InitializeComponent();

            LoadRessources();

            // Insert options into the ComboBox
            selectionComboBox.DataSource = options;
        }

        public SelectionForm(ISet options)
        {
            InitializeComponent();

            LoadRessources();

            foreach (Object o in options)
            {
                selectionComboBox.Items.Add(o);
            }
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            /* Force language
             * culture = CultureInfo.CreateSpecificCulture("pt-PT");
             */
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.SelectionForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.submitButton.Text = ressourceManager.GetString("submit", culture);
        }

        public Object getSelection()
        {
            return selection;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
           selection = this.selectionComboBox.SelectedItem;
           Close();
        }
    }
}
