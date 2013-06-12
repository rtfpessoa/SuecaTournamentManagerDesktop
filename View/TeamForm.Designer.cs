namespace SuecaTournamentManager.View
{
    partial class TeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.TextBox name1TextBox;
        private System.Windows.Forms.TextBox name2TextBox;
        private System.Windows.Forms.Button namesButton;

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
            this.namesLabel = new System.Windows.Forms.Label();
            this.name1TextBox = new System.Windows.Forms.TextBox();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.namesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Location = new System.Drawing.Point(118, 70);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(46, 17);
            this.namesLabel.TabIndex = 0;
            this.namesLabel.Text = "Names:";
            // 
            // name1TextBox
            // 
            this.name1TextBox.Location = new System.Drawing.Point(30, 107);
            this.name1TextBox.Name = "name1TextBox";
            this.name1TextBox.Size = new System.Drawing.Size(100, 22);
            this.name1TextBox.TabIndex = 1;
            // 
            // name2TextBox
            // 
            this.name2TextBox.Location = new System.Drawing.Point(155, 107);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(100, 22);
            this.name2TextBox.TabIndex = 2;
            // 
            // namesButton
            // 
            this.namesButton.Location = new System.Drawing.Point(104, 161);
            this.namesButton.Name = "namesButton";
            this.namesButton.Size = new System.Drawing.Size(75, 23);
            this.namesButton.TabIndex = 3;
            this.namesButton.Text = "Submit";
            this.namesButton.UseVisualStyleBackColor = true;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.namesButton);
            this.Controls.Add(this.name2TextBox);
            this.Controls.Add(this.name1TextBox);
            this.Controls.Add(this.namesLabel);
            this.Name = "Team";
            this.Text = "SMT | Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}