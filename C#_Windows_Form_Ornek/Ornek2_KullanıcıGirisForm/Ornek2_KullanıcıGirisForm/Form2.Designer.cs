namespace Ornek2_KullanıcıGirisForm
{
    partial class Form2
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
            this.lblSelamla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelamla
            // 
            this.lblSelamla.AutoSize = true;
            this.lblSelamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSelamla.Location = new System.Drawing.Point(315, 36);
            this.lblSelamla.Name = "lblSelamla";
            this.lblSelamla.Size = new System.Drawing.Size(0, 24);
            this.lblSelamla.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 109);
            this.Controls.Add(this.lblSelamla);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelamla;
    }
}