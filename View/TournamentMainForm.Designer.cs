namespace SuecaTournamentManager.View
{
    partial class TournamentMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button enterResultButton;
        private System.Windows.Forms.Button checkResultsButton;
        private System.Windows.Forms.Button checkRankingButton;
        private System.Windows.Forms.Button editResultButton;

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
            this.enterResultButton = new System.Windows.Forms.Button();
            this.checkResultsButton = new System.Windows.Forms.Button();
            this.checkRankingButton = new System.Windows.Forms.Button();
            this.editResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterResultButton
            // 
            this.enterResultButton.Location = new System.Drawing.Point(147, 32);
            this.enterResultButton.Name = "enterResultButton";
            this.enterResultButton.Size = new System.Drawing.Size(200, 24);
            this.enterResultButton.TabIndex = 0;
            this.enterResultButton.Text = "Enter result";
            this.enterResultButton.UseVisualStyleBackColor = true;
            this.enterResultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // checkResultsButton
            // 
            this.checkResultsButton.Location = new System.Drawing.Point(147, 138);
            this.checkResultsButton.Name = "checkResultsButton";
            this.checkResultsButton.Size = new System.Drawing.Size(200, 24);
            this.checkResultsButton.TabIndex = 1;
            this.checkResultsButton.Text = "Results";
            this.checkResultsButton.UseVisualStyleBackColor = true;
            // 
            // checkRankingButton
            // 
            this.checkRankingButton.Location = new System.Drawing.Point(147, 180);
            this.checkRankingButton.Name = "checkRankingButton";
            this.checkRankingButton.Size = new System.Drawing.Size(200, 24);
            this.checkRankingButton.TabIndex = 2;
            this.checkRankingButton.Text = "Ranking";
            this.checkRankingButton.UseVisualStyleBackColor = true;
            // 
            // editResultButton
            // 
            this.editResultButton.Location = new System.Drawing.Point(147, 87);
            this.editResultButton.Name = "editResultButton";
            this.editResultButton.Size = new System.Drawing.Size(200, 24);
            this.editResultButton.TabIndex = 3;
            this.editResultButton.Text = "Edit Result";
            this.editResultButton.UseVisualStyleBackColor = true;
            this.editResultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // TournamentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.editResultButton);
            this.Controls.Add(this.checkRankingButton);
            this.Controls.Add(this.checkResultsButton);
            this.Controls.Add(this.enterResultButton);
            this.Name = "TournamentMainForm";
            this.Text = "STM | Tournament Main";
            this.ResumeLayout(false);

        }

        #endregion
    }
}