namespace SuecaTournamentManager.View
{
    partial class MatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.Label score1Label;
        private System.Windows.Forms.TextBox score1TextBox;
        private System.Windows.Forms.Label lines1Label;
        private System.Windows.Forms.TextBox lines1TextBox;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label score2Label;
        private System.Windows.Forms.TextBox score2TextBox;
        private System.Windows.Forms.Label lines2Label;
        private System.Windows.Forms.TextBox lines2TextBox;
        private System.Windows.Forms.Button submitButton;

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
            this.score1Label = new System.Windows.Forms.Label();
            this.score1TextBox = new System.Windows.Forms.TextBox();
            this.lines1Label = new System.Windows.Forms.Label();
            this.score2TextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.lines1TextBox = new System.Windows.Forms.TextBox();
            this.lines2TextBox = new System.Windows.Forms.TextBox();
            this.score2Label = new System.Windows.Forms.Label();
            this.lines2Label = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score1Label
            // 
            this.score1Label.AutoSize = true;
            this.score1Label.Location = new System.Drawing.Point(9, 106);
            this.score1Label.Name = "score1Label";
            this.score1Label.Size = new System.Drawing.Size(45, 17);
            this.score1Label.TabIndex = 0;
            this.score1Label.Text = "Score";
            // 
            // score1TextBox
            // 
            this.score1TextBox.Location = new System.Drawing.Point(92, 103);
            this.score1TextBox.Name = "score1TextBox";
            this.score1TextBox.Size = new System.Drawing.Size(100, 22);
            this.score1TextBox.TabIndex = 1;
            // 
            // lines1Label
            // 
            this.lines1Label.AutoSize = true;
            this.lines1Label.Location = new System.Drawing.Point(12, 159);
            this.lines1Label.Name = "lines1Label";
            this.lines1Label.Size = new System.Drawing.Size(42, 17);
            this.lines1Label.TabIndex = 2;
            this.lines1Label.Text = "Lines";
            // 
            // score2TextBox
            // 
            this.score2TextBox.Location = new System.Drawing.Point(309, 103);
            this.score2TextBox.Name = "score2TextBox";
            this.score2TextBox.Size = new System.Drawing.Size(100, 22);
            this.score2TextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(183, 205);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 24);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // lines1TextBox
            // 
            this.lines1TextBox.Location = new System.Drawing.Point(92, 156);
            this.lines1TextBox.Name = "lines1TextBox";
            this.lines1TextBox.Size = new System.Drawing.Size(100, 22);
            this.lines1TextBox.TabIndex = 5;
            // 
            // lines2TextBox
            // 
            this.lines2TextBox.Location = new System.Drawing.Point(309, 156);
            this.lines2TextBox.Name = "lines2TextBox";
            this.lines2TextBox.Size = new System.Drawing.Size(100, 22);
            this.lines2TextBox.TabIndex = 6;
            // 
            // score2Label
            // 
            this.score2Label.AutoSize = true;
            this.score2Label.Location = new System.Drawing.Point(232, 103);
            this.score2Label.Name = "score2Label";
            this.score2Label.Size = new System.Drawing.Size(46, 17);
            this.score2Label.TabIndex = 7;
            this.score2Label.Text = "Score";
            // 
            // lines2Label
            // 
            this.lines2Label.AutoSize = true;
            this.lines2Label.Location = new System.Drawing.Point(232, 156);
            this.lines2Label.Name = "lines2Label";
            this.lines2Label.Size = new System.Drawing.Size(46, 17);
            this.lines2Label.TabIndex = 8;
            this.lines2Label.Text = "Lines";
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Location = new System.Drawing.Point(89, 52);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(46, 17);
            this.team1Label.TabIndex = 9;
            this.team1Label.Text = "Team 1";
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Location = new System.Drawing.Point(306, 52);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(46, 17);
            this.team2Label.TabIndex = 10;
            this.team2Label.Text = "Team 2";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.team2Label);
            this.Controls.Add(this.team1Label);
            this.Controls.Add(this.lines2Label);
            this.Controls.Add(this.score2Label);
            this.Controls.Add(this.lines2TextBox);
            this.Controls.Add(this.lines1TextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.score2TextBox);
            this.Controls.Add(this.lines1Label);
            this.Controls.Add(this.score1TextBox);
            this.Controls.Add(this.score1Label);
            this.Name = "MatchForm";
            this.Text = "STM | Match Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}