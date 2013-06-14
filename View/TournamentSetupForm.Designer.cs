namespace SuecaTournamentManager.View
{
    partial class TournamentSetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button addAssociationButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Label removeAssociationsLabel;
        private System.Windows.Forms.Button removeAssociationsButton;
        private System.Windows.Forms.Label removeTeamLabel;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.Button startTournamentButton;

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
            this.addAssociationButton = new System.Windows.Forms.Button();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.removeAssociationsLabel = new System.Windows.Forms.Label();
            this.removeAssociationsButton = new System.Windows.Forms.Button();
            this.removeTeamLabel = new System.Windows.Forms.Label();
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.startTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAssociationButton
            // 
            this.addAssociationButton.Location = new System.Drawing.Point(33, 29);
            this.addAssociationButton.Name = "addAssociationButton";
            this.addAssociationButton.Size = new System.Drawing.Size(100, 24);
            this.addAssociationButton.TabIndex = 0;
            this.addAssociationButton.Text = "Add";
            this.addAssociationButton.UseVisualStyleBackColor = true;
            this.addAssociationButton.Click += new System.EventHandler(this.addAssociationButton_Click);
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(33, 91);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(100, 24);
            this.addTeamButton.TabIndex = 1;
            this.addTeamButton.Text = "Add";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // removeAssociationsLabel
            // 
            this.removeAssociationsLabel.AutoSize = true;
            this.removeAssociationsLabel.Location = new System.Drawing.Point(92, 9);
            this.removeAssociationsLabel.Name = "removeAssociationsLabel";
            this.removeAssociationsLabel.Size = new System.Drawing.Size(87, 17);
            this.removeAssociationsLabel.TabIndex = 2;
            this.removeAssociationsLabel.Text = "Associations";
            // 
            // removeAssociationsButton
            // 
            this.removeAssociationsButton.Location = new System.Drawing.Point(139, 29);
            this.removeAssociationsButton.Name = "removeAssociationsButton";
            this.removeAssociationsButton.Size = new System.Drawing.Size(100, 24);
            this.removeAssociationsButton.TabIndex = 4;
            this.removeAssociationsButton.Text = "Remove";
            this.removeAssociationsButton.UseVisualStyleBackColor = true;
            this.removeAssociationsButton.Click += new System.EventHandler(this.removeAssociationsButton_Click);
            // 
            // removeTeamLabel
            // 
            this.removeTeamLabel.AutoSize = true;
            this.removeTeamLabel.Location = new System.Drawing.Point(108, 71);
            this.removeTeamLabel.Name = "removeTeamLabel";
            this.removeTeamLabel.Size = new System.Drawing.Size(51, 17);
            this.removeTeamLabel.TabIndex = 5;
            this.removeTeamLabel.Text = "Teams";
            // 
            // removeTeamButton
            // 
            this.removeTeamButton.Location = new System.Drawing.Point(139, 91);
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Size = new System.Drawing.Size(100, 24);
            this.removeTeamButton.TabIndex = 7;
            this.removeTeamButton.Text = "Remove";
            this.removeTeamButton.UseVisualStyleBackColor = true;
            this.removeTeamButton.Click += new System.EventHandler(this.removeTeamButton_Click);
            // 
            // startTournamentButton
            // 
            this.startTournamentButton.Location = new System.Drawing.Point(12, 148);
            this.startTournamentButton.Name = "startTournamentButton";
            this.startTournamentButton.Size = new System.Drawing.Size(250, 40);
            this.startTournamentButton.TabIndex = 8;
            this.startTournamentButton.Text = "Start Tournament";
            this.startTournamentButton.UseVisualStyleBackColor = true;
            this.startTournamentButton.Click += new System.EventHandler(this.startTournamentButton_Click);
            // 
            // TournamentSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 202);
            this.Controls.Add(this.startTournamentButton);
            this.Controls.Add(this.removeTeamButton);
            this.Controls.Add(this.removeTeamLabel);
            this.Controls.Add(this.removeAssociationsButton);
            this.Controls.Add(this.removeAssociationsLabel);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.addAssociationButton);
            this.Name = "TournamentSetupForm";
            this.Text = "STM | Tournament Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}