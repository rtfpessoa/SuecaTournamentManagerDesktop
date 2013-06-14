namespace SuecaTournamentManager.View
{
    partial class TournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.TextBox tournamentTextBox;
        private System.Windows.Forms.Button tournamentButton;
        private System.Windows.Forms.RadioButton onlyTeamsButton;
        private System.Windows.Forms.RadioButton teamsAndAssociationsButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentTextBox = new System.Windows.Forms.TextBox();
            this.tournamentButton = new System.Windows.Forms.Button();
            this.onlyTeamsButton = new System.Windows.Forms.RadioButton();
            this.teamsAndAssociationsButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Location = new System.Drawing.Point(9, 75);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(49, 17);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Name:";
            // 
            // tournamentTextBox
            // 
            this.tournamentTextBox.Location = new System.Drawing.Point(64, 75);
            this.tournamentTextBox.Name = "tournamentTextBox";
            this.tournamentTextBox.Size = new System.Drawing.Size(100, 22);
            this.tournamentTextBox.TabIndex = 1;
            // 
            // tournamentButton
            // 
            this.tournamentButton.Location = new System.Drawing.Point(75, 157);
            this.tournamentButton.Name = "tournamentButton";
            this.tournamentButton.Size = new System.Drawing.Size(95, 24);
            this.tournamentButton.TabIndex = 2;
            this.tournamentButton.Text = "Submit";
            this.tournamentButton.UseVisualStyleBackColor = true;
            this.tournamentButton.Click += new System.EventHandler(this.tournamentButton_Click);
            // 
            // onlyTeamsButton
            // 
            this.onlyTeamsButton.AutoSize = true;
            this.onlyTeamsButton.Location = new System.Drawing.Point(12, 103);
            this.onlyTeamsButton.Name = "onlyTeamsButton";
            this.onlyTeamsButton.Size = new System.Drawing.Size(143, 21);
            this.onlyTeamsButton.TabIndex = 3;
            this.onlyTeamsButton.TabStop = true;
            this.onlyTeamsButton.Text = "Team Competition";
            this.onlyTeamsButton.UseVisualStyleBackColor = true;
            this.onlyTeamsButton.Checked = true;
            // 
            // teamsAndAssociationsButton
            // 
            this.teamsAndAssociationsButton.AutoSize = true;
            this.teamsAndAssociationsButton.Location = new System.Drawing.Point(12, 130);
            this.teamsAndAssociationsButton.Name = "teamsAndAssociationsButton";
            this.teamsAndAssociationsButton.Size = new System.Drawing.Size(247, 21);
            this.teamsAndAssociationsButton.TabIndex = 4;
            this.teamsAndAssociationsButton.TabStop = true;
            this.teamsAndAssociationsButton.Text = "Team and Association Competition";
            this.teamsAndAssociationsButton.UseVisualStyleBackColor = true;
            // 
            // TournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.teamsAndAssociationsButton);
            this.Controls.Add(this.onlyTeamsButton);
            this.Controls.Add(this.tournamentButton);
            this.Controls.Add(this.tournamentTextBox);
            this.Controls.Add(this.tournamentLabel);
            this.Name = "TournamentForm";
            this.Text = "SMT | Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}