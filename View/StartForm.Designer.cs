namespace SuecaTournamentManager.View
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button newTournamentButton;
        private System.Windows.Forms.Button newAssociationButton;
        private System.Windows.Forms.Button newTeamButton;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button editAssociationButton;
        private System.Windows.Forms.Button editTeamButton;

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
            this.newTournamentButton = new System.Windows.Forms.Button();
            this.newAssociationButton = new System.Windows.Forms.Button();
            this.newTeamButton = new System.Windows.Forms.Button();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.editAssociationButton = new System.Windows.Forms.Button();
            this.editTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTournamentButton
            // 
            this.newTournamentButton.Location = new System.Drawing.Point(19, 58);
            this.newTournamentButton.Name = "newTournamentButton";
            this.newTournamentButton.Size = new System.Drawing.Size(185, 24);
            this.newTournamentButton.TabIndex = 0;
            this.newTournamentButton.Text = "New Tournament";
            this.newTournamentButton.UseVisualStyleBackColor = true;
            this.newTournamentButton.Click += new System.EventHandler(this.newTournamentButton_Click);
            // 
            // newAssociationButton
            // 
            this.newAssociationButton.Location = new System.Drawing.Point(19, 88);
            this.newAssociationButton.Name = "newAssociationButton";
            this.newAssociationButton.Size = new System.Drawing.Size(185, 24);
            this.newAssociationButton.TabIndex = 1;
            this.newAssociationButton.Text = "New Association";
            this.newAssociationButton.UseVisualStyleBackColor = true;
            this.newAssociationButton.Click += new System.EventHandler(this.newAssociationButton_Click);
            // 
            // newTeamButton
            // 
            this.newTeamButton.Location = new System.Drawing.Point(19, 118);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(185, 24);
            this.newTeamButton.TabIndex = 2;
            this.newTeamButton.Text = "New Team";
            this.newTeamButton.UseVisualStyleBackColor = true;
            this.newTeamButton.Click += new System.EventHandler(this.newTeamButton_Click);
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Location = new System.Drawing.Point(210, 58);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(185, 24);
            this.loadTournamentButton.TabIndex = 3;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
            // 
            // editAssociationButton
            // 
            this.editAssociationButton.Location = new System.Drawing.Point(210, 88);
            this.editAssociationButton.Name = "editAssociationButton";
            this.editAssociationButton.Size = new System.Drawing.Size(185, 24);
            this.editAssociationButton.TabIndex = 4;
            this.editAssociationButton.Text = "Edit Association";
            this.editAssociationButton.UseVisualStyleBackColor = true;
            this.editAssociationButton.Click += new System.EventHandler(this.editAssociationButton_Click);
            // 
            // editTeamButton
            // 
            this.editTeamButton.Location = new System.Drawing.Point(210, 118);
            this.editTeamButton.Name = "editTeamButton";
            this.editTeamButton.Size = new System.Drawing.Size(185, 24);
            this.editTeamButton.TabIndex = 5;
            this.editTeamButton.Text = "Edit Team";
            this.editTeamButton.UseVisualStyleBackColor = true;
            this.editTeamButton.Click += new System.EventHandler(this.editTeamButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.editTeamButton);
            this.Controls.Add(this.editAssociationButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.newTeamButton);
            this.Controls.Add(this.newAssociationButton);
            this.Controls.Add(this.newTournamentButton);
            this.Name = "StartForm";
            this.Text = "STM | Start";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

