namespace ReverseHangmanForms.Presentation
{
    partial class FRM_CustomMessageBox
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
            this.BTN_TeamName1 = new System.Windows.Forms.Button();
            this.BTN_TeamName2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_TeamName1
            // 
            this.BTN_TeamName1.BackColor = System.Drawing.Color.Black;
            this.BTN_TeamName1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TeamName1.ForeColor = System.Drawing.Color.White;
            this.BTN_TeamName1.Location = new System.Drawing.Point(12, 120);
            this.BTN_TeamName1.Name = "BTN_TeamName1";
            this.BTN_TeamName1.Size = new System.Drawing.Size(354, 38);
            this.BTN_TeamName1.TabIndex = 0;
            this.BTN_TeamName1.Text = "WWWWWWWWWWWWWWWWWWWWWWWWW";
            this.BTN_TeamName1.UseVisualStyleBackColor = false;
            this.BTN_TeamName1.Click += new System.EventHandler(this.BTN_TeamName1_Click);
            // 
            // BTN_TeamName2
            // 
            this.BTN_TeamName2.BackColor = System.Drawing.Color.Black;
            this.BTN_TeamName2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TeamName2.ForeColor = System.Drawing.Color.White;
            this.BTN_TeamName2.Location = new System.Drawing.Point(372, 120);
            this.BTN_TeamName2.Name = "BTN_TeamName2";
            this.BTN_TeamName2.Size = new System.Drawing.Size(354, 38);
            this.BTN_TeamName2.TabIndex = 1;
            this.BTN_TeamName2.Text = "WWWWWWWWWWWWWWWWWWWWWWWWW";
            this.BTN_TeamName2.UseVisualStyleBackColor = false;
            this.BTN_TeamName2.Click += new System.EventHandler(this.BTN_TeamName2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 108);
            this.label1.TabIndex = 2;
            this.label1.Text = "Who won the tiebreaker?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(738, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_TeamName2);
            this.Controls.Add(this.BTN_TeamName1);
            this.Name = "FRM_CustomMessageBox";
            this.Text = "Tiebreaker Result";
            this.Load += new System.EventHandler(this.FRM_CustomMessageBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_TeamName1;
        private System.Windows.Forms.Button BTN_TeamName2;
        private System.Windows.Forms.Label label1;
    }
}