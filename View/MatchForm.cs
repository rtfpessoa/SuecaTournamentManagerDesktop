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
    public partial class MatchForm : Form
    {
        private CultureInfo culture;
        private ResourceManager ressourceManager;
        private Match match;
        private int matchId;

        private Result result1;
        private Result result2;

        private ISession session = DatabaseManager.Instance.OpenSession();

        public MatchForm(int matchId)
        {
            InitializeComponent();
            this.matchId = matchId;
            match = session.Load<Match>(matchId);

            result1 = match.Result1;
            result2 = match.Result2;
            if (result1 != null && result2 != null)
            {
                this.score1TextBox.Text = result1.Score.ToString();
                this.lines1TextBox.Text = result1.Lines.ToString();
                this.score2TextBox.Text = result2.Score.ToString();
                this.lines2TextBox.Text = result2.Lines.ToString();
            }
            else
            {
                result1 = new Result();
                result2 = new Result();
            }
        }

        private void LoadRessources()
        {
            // Start ressource manager
            culture = CultureInfo.CurrentCulture;
            ressourceManager = new ResourceManager("SuecaTournamentManager.View.MatchForm", Assembly.GetExecutingAssembly());

            // Load ressources
            this.Text = "STM | " + ressourceManager.GetString("form_name", culture);
            this.score1Label.Text = ressourceManager.GetString("score", culture);
            this.lines1Label.Text = ressourceManager.GetString("lines", culture);
            this.score2Label.Text = ressourceManager.GetString("score", culture);
            this.lines2Label.Text = ressourceManager.GetString("lines", culture);
            this.team1Label.Text = ressourceManager.GetString("team1", culture);
            this.team1Label.Text = ressourceManager.GetString("team2", culture);
            this.submitButton.Text = ressourceManager.GetString("submit", culture);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {            
            // Fill the values of result 1
            result1.Match = match;
            result1.Team = match.Team1;
            result1.Phase = match.Phase;
            result1.Tournament = match.Tournament;
            result1.Score = Convert.ToInt32(this.score1TextBox.Text);
            result1.Lines = Convert.ToInt32(this.lines1TextBox.Text);

            // Fill the values of result 2
            result2.Match = match;
            result2.Team = match.Team2;
            result2.Phase = match.Phase;
            result2.Tournament = match.Tournament;
            result2.Score = Convert.ToInt32(this.score2TextBox.Text);
            result2.Lines = Convert.ToInt32(this.lines2TextBox.Text);

            // Assign the results to the match
            match.Result1 = result1;
            match.Result2 = result2;
            // Save or Update the results
            session.SaveOrUpdate(result1);
            session.SaveOrUpdate(result2);
            // Update the match
            session.Update(match);
            session.Flush();
            session.Close();
            Close();
        }
    }
}
