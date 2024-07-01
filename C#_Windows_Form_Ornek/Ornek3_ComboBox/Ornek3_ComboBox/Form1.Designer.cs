namespace Ornek3_ComboBox
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
            this.cmbUrunListesi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctUrunResim = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStokAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUrunListesi
            // 
            this.cmbUrunListesi.FormattingEnabled = true;
            this.cmbUrunListesi.Location = new System.Drawing.Point(120, 25);
            this.cmbUrunListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUrunListesi.Name = "cmbUrunListesi";
            this.cmbUrunListesi.Size = new System.Drawing.Size(437, 28);
            this.cmbUrunListesi.TabIndex = 0;
            this.cmbUrunListesi.SelectedIndexChanged += new System.EventHandler(this.cmbUrunListesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Listesi";
            // 
            // pctUrunResim
            // 
            this.pctUrunResim.Location = new System.Drawing.Point(22, 85);
            this.pctUrunResim.Name = "pctUrunResim";
            this.pctUrunResim.Size = new System.Drawing.Size(100, 145);
            this.pctUrunResim.TabIndex = 2;
            this.pctUrunResim.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(210, 82);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(347, 26);
            this.txtKitapAdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tür";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(210, 126);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(347, 26);
            this.txtTur.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adet";
            // 
            // txtStokAdet
            // 
            this.txtStokAdet.Location = new System.Drawing.Point(210, 168);
            this.txtStokAdet.Name = "txtStokAdet";
            this.txtStokAdet.Size = new System.Drawing.Size(347, 26);
            this.txtStokAdet.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yazar";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(210, 207);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(347, 26);
            this.txtYazar.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(22, 257);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(535, 198);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 467);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStokAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctUrunResim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctUrunResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUrunListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctUrunResim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStokAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.RichTextBox txtAciklama;
    }
}

