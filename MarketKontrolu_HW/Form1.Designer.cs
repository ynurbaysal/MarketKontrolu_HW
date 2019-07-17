namespace MarketKontrolu_HW
{
    partial class Form1
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
            this.btnReyon = new System.Windows.Forms.Button();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReyon
            // 
            this.btnReyon.Location = new System.Drawing.Point(36, 57);
            this.btnReyon.Name = "btnReyon";
            this.btnReyon.Size = new System.Drawing.Size(100, 23);
            this.btnReyon.TabIndex = 0;
            this.btnReyon.Text = "Reyon";
            this.btnReyon.UseVisualStyleBackColor = true;
            this.btnReyon.Click += new System.EventHandler(this.BtnReyon_Click);
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(36, 12);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(100, 20);
            this.txtUrun.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.btnReyon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReyon;
        private System.Windows.Forms.TextBox txtUrun;
    }
}

