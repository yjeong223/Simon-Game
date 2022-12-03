namespace Simon_Part_1
{
    partial class GamerAttemptResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.playerAttemptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerAttemptLabel
            // 
            this.playerAttemptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerAttemptLabel.AutoSize = true;
            this.playerAttemptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerAttemptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerAttemptLabel.Location = new System.Drawing.Point(12, 53);
            this.playerAttemptLabel.Name = "playerAttemptLabel";
            this.playerAttemptLabel.Size = new System.Drawing.Size(283, 27);
            this.playerAttemptLabel.TabIndex = 23;
            this.playerAttemptLabel.Text = "Result of Player Attempt";
            // 
            // GamerAttemptResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 135);
            this.Controls.Add(this.playerAttemptLabel);
            this.Name = "GamerAttemptResult";
            this.Text = "GamerAttemptResult";
            this.Load += new System.EventHandler(this.GamerAttemptResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label playerAttemptLabel;
    }
}