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
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Location = new System.Drawing.Point(29, 106);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(49, 17);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Name:";
            // 
            // tournamentTextBox
            // 
            this.tournamentTextBox.Location = new System.Drawing.Point(84, 103);
            this.tournamentTextBox.Name = "tournamentTextBox";
            this.tournamentTextBox.Size = new System.Drawing.Size(100, 22);
            this.tournamentTextBox.TabIndex = 1;
            // 
            // tournamentButton
            // 
            this.tournamentButton.Location = new System.Drawing.Point(190, 102);
            this.tournamentButton.Name = "tournamentButton";
            this.tournamentButton.Size = new System.Drawing.Size(75, 24);
            this.tournamentButton.TabIndex = 2;
            this.tournamentButton.Text = "Submit";
            this.tournamentButton.UseVisualStyleBackColor = true;
            // 
            // Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.tournamentButton);
            this.Controls.Add(this.tournamentTextBox);
            this.Controls.Add(this.tournamentLabel);
            this.Name = "Tournament";
            this.Text = "SMT | Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}