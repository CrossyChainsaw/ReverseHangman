
namespace ReverseHangmanForms
{
    partial class FRM_Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Rules));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.LBL_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Title.Location = new System.Drawing.Point(12, 9);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(913, 83);
            this.LBL_Title.TabIndex = 1;
            this.LBL_Title.Text = "Regels";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 182);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Het woord moet terug te vinden zijn op woorden.org of vandale.nl\r\n2. Een woord" +
    " moet minimaal 4 verschillende letters hebben.\r\n3. Je kunt alleen punten verdien" +
    "en tijdens het raden";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 32F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(913, 83);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puntentelling";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(913, 167);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // FRM_Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(937, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_Title);
            this.Name = "FRM_Rules";
            this.Text = "FRM_Rules";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Rules_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}