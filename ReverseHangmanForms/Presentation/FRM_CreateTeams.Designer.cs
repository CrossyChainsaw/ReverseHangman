
namespace ReverseHangmanForms
{
    partial class FRM_CreateTeams
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_TeamOne = new System.Windows.Forms.TextBox();
            this.TB_TeamTwo = new System.Windows.Forms.TextBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(413, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TB_TeamOne
            // 
            this.TB_TeamOne.BackColor = System.Drawing.Color.Black;
            this.TB_TeamOne.ForeColor = System.Drawing.Color.White;
            this.TB_TeamOne.Location = new System.Drawing.Point(12, 164);
            this.TB_TeamOne.MaxLength = 25;
            this.TB_TeamOne.Name = "TB_TeamOne";
            this.TB_TeamOne.Size = new System.Drawing.Size(375, 22);
            this.TB_TeamOne.TabIndex = 2;
            this.TB_TeamOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_TeamTwo
            // 
            this.TB_TeamTwo.BackColor = System.Drawing.Color.Black;
            this.TB_TeamTwo.ForeColor = System.Drawing.Color.White;
            this.TB_TeamTwo.Location = new System.Drawing.Point(413, 164);
            this.TB_TeamTwo.MaxLength = 25;
            this.TB_TeamTwo.Name = "TB_TeamTwo";
            this.TB_TeamTwo.Size = new System.Drawing.Size(375, 22);
            this.TB_TeamTwo.TabIndex = 3;
            this.TB_TeamTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.Color.Black;
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.BTN_Start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Start.Location = new System.Drawing.Point(12, 349);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(776, 89);
            this.BTN_Start.TabIndex = 4;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // FRM_CreateTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.TB_TeamTwo);
            this.Controls.Add(this.TB_TeamOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_CreateTeams";
            this.Text = "FRM_Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_CreateTeams_FormClosed);
            this.Load += new System.EventHandler(this.FRM_CreateTeams_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_TeamOne;
        private System.Windows.Forms.TextBox TB_TeamTwo;
        private System.Windows.Forms.Button BTN_Start;
    }
}