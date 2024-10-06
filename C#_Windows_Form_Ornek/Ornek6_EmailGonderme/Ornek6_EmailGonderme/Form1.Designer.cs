namespace Ornek6_EmailGonderme
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
            this.components = new System.ComponentModel.Container();
            this.rtxt_Mesajİcerik = new System.Windows.Forms.RichTextBox();
            this.txt_EmailAdresi = new System.Windows.Forms.TextBox();
            this.txt_GönderilcekEmail = new System.Windows.Forms.TextBox();
            this.txt_alanadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MesajKonusu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Gmail = new System.Windows.Forms.Button();
            this.btn_Outlook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_EmailGonder = new System.Windows.Forms.Button();
            this.txt_MesajBaslik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_UygulamaSifresi = new System.Windows.Forms.TextBox();
            this.btn_NasılAlınır = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxt_Mesajİcerik
            // 
            this.rtxt_Mesajİcerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Mesajİcerik.Location = new System.Drawing.Point(4, 20);
            this.rtxt_Mesajİcerik.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_Mesajİcerik.Name = "rtxt_Mesajİcerik";
            this.rtxt_Mesajİcerik.Size = new System.Drawing.Size(414, 268);
            this.rtxt_Mesajİcerik.TabIndex = 0;
            this.rtxt_Mesajİcerik.Text = "";
            // 
            // txt_EmailAdresi
            // 
            this.txt_EmailAdresi.Location = new System.Drawing.Point(199, 16);
            this.txt_EmailAdresi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_EmailAdresi.Name = "txt_EmailAdresi";
            this.txt_EmailAdresi.Size = new System.Drawing.Size(239, 23);
            this.txt_EmailAdresi.TabIndex = 0;
            // 
            // txt_GönderilcekEmail
            // 
            this.txt_GönderilcekEmail.Location = new System.Drawing.Point(200, 82);
            this.txt_GönderilcekEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GönderilcekEmail.Name = "txt_GönderilcekEmail";
            this.txt_GönderilcekEmail.Size = new System.Drawing.Size(238, 23);
            this.txt_GönderilcekEmail.TabIndex = 2;
            // 
            // txt_alanadi
            // 
            this.txt_alanadi.Location = new System.Drawing.Point(175, 36);
            this.txt_alanadi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_alanadi.Name = "txt_alanadi";
            this.txt_alanadi.ReadOnly = true;
            this.txt_alanadi.Size = new System.Drawing.Size(243, 23);
            this.txt_alanadi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email Adresiniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gönderilecek Email Adresi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesaj Konusu";
            // 
            // txt_MesajKonusu
            // 
            this.txt_MesajKonusu.Location = new System.Drawing.Point(122, 227);
            this.txt_MesajKonusu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MesajKonusu.Name = "txt_MesajKonusu";
            this.txt_MesajKonusu.Size = new System.Drawing.Size(316, 23);
            this.txt_MesajKonusu.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxt_Mesajİcerik);
            this.groupBox1.Location = new System.Drawing.Point(16, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(422, 292);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesaj İçeriği";
            // 
            // btn_Gmail
            // 
            this.btn_Gmail.Location = new System.Drawing.Point(6, 22);
            this.btn_Gmail.Name = "btn_Gmail";
            this.btn_Gmail.Size = new System.Drawing.Size(71, 50);
            this.btn_Gmail.TabIndex = 9;
            this.btn_Gmail.Text = "Gmail";
            this.btn_Gmail.UseVisualStyleBackColor = true;
            this.btn_Gmail.Click += new System.EventHandler(this.btn_Gmail_Click);
            // 
            // btn_Outlook
            // 
            this.btn_Outlook.Location = new System.Drawing.Point(83, 22);
            this.btn_Outlook.Name = "btn_Outlook";
            this.btn_Outlook.Size = new System.Drawing.Size(85, 50);
            this.btn_Outlook.TabIndex = 10;
            this.btn_Outlook.Text = "Outlook/Hotmail/Live";
            this.btn_Outlook.UseVisualStyleBackColor = true;
            this.btn_Outlook.Click += new System.EventHandler(this.btn_Outlook_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Gmail);
            this.groupBox2.Controls.Add(this.btn_Outlook);
            this.groupBox2.Controls.Add(this.txt_alanadi);
            this.groupBox2.Location = new System.Drawing.Point(20, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alan Adınızı tıklayınız";
            // 
            // btn_EmailGonder
            // 
            this.btn_EmailGonder.Location = new System.Drawing.Point(166, 557);
            this.btn_EmailGonder.Name = "btn_EmailGonder";
            this.btn_EmailGonder.Size = new System.Drawing.Size(117, 56);
            this.btn_EmailGonder.TabIndex = 12;
            this.btn_EmailGonder.Text = "Email Gönder";
            this.btn_EmailGonder.UseVisualStyleBackColor = true;
            this.btn_EmailGonder.Click += new System.EventHandler(this.btn_EmailGonder_Click);
            // 
            // txt_MesajBaslik
            // 
            this.txt_MesajBaslik.Location = new System.Drawing.Point(122, 193);
            this.txt_MesajBaslik.Name = "txt_MesajBaslik";
            this.txt_MesajBaslik.Size = new System.Drawing.Size(316, 23);
            this.txt_MesajBaslik.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mesaj Başlığı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Uygulama Şifresi :";
            // 
            // txt_UygulamaSifresi
            // 
            this.txt_UygulamaSifresi.Location = new System.Drawing.Point(199, 50);
            this.txt_UygulamaSifresi.Name = "txt_UygulamaSifresi";
            this.txt_UygulamaSifresi.Size = new System.Drawing.Size(239, 23);
            this.txt_UygulamaSifresi.TabIndex = 1;
            // 
            // btn_NasılAlınır
            // 
            this.btn_NasılAlınır.Location = new System.Drawing.Point(444, 50);
            this.btn_NasılAlınır.Name = "btn_NasılAlınır";
            this.btn_NasılAlınır.Size = new System.Drawing.Size(120, 23);
            this.btn_NasılAlınır.TabIndex = 17;
            this.btn_NasılAlınır.Text = "Nasıl Alınır?";
            this.btn_NasılAlınır.UseVisualStyleBackColor = true;
            this.btn_NasılAlınır.Click += new System.EventHandler(this.btn_NasılAlınır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 617);
            this.Controls.Add(this.btn_NasılAlınır);
            this.Controls.Add(this.txt_UygulamaSifresi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MesajBaslik);
            this.Controls.Add(this.btn_EmailGonder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_MesajKonusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_GönderilcekEmail);
            this.Controls.Add(this.txt_EmailAdresi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Email Gönderme Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_Mesajİcerik;
        private System.Windows.Forms.TextBox txt_EmailAdresi;
        private System.Windows.Forms.TextBox txt_GönderilcekEmail;
        private System.Windows.Forms.TextBox txt_alanadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MesajKonusu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Gmail;
        private System.Windows.Forms.Button btn_Outlook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_EmailGonder;
        private System.Windows.Forms.TextBox txt_MesajBaslik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_UygulamaSifresi;
        private System.Windows.Forms.Button btn_NasılAlınır;
        private System.Windows.Forms.Timer timer1;
    }
}

