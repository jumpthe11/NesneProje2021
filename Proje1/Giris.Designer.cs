namespace Proje1
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi1 = new System.Windows.Forms.TextBox();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnUyeol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyelikTamamla = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kulanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtKullaniciAdi1
            // 
            this.txtKullaniciAdi1.Location = new System.Drawing.Point(179, 49);
            this.txtKullaniciAdi1.Margin = new System.Windows.Forms.Padding(4);
            this.txtKullaniciAdi1.Name = "txtKullaniciAdi1";
            this.txtKullaniciAdi1.Size = new System.Drawing.Size(190, 29);
            this.txtKullaniciAdi1.TabIndex = 2;
            // 
            // txtSifre1
            // 
            this.txtSifre1.Location = new System.Drawing.Point(179, 91);
            this.txtSifre1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.Size = new System.Drawing.Size(190, 29);
            this.txtSifre1.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Image = global::Proje1.Properties.Resources.Paomedia_Small_N_Flat_Sign_check;
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.Location = new System.Drawing.Point(179, 139);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGiris.Size = new System.Drawing.Size(192, 45);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnUyeol
            // 
            this.btnUyeol.Image = global::Proje1.Properties.Resources.Kyo_Tux_Phuzion_Sign_Add;
            this.btnUyeol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeol.Location = new System.Drawing.Point(179, 192);
            this.btnUyeol.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeol.Name = "btnUyeol";
            this.btnUyeol.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUyeol.Size = new System.Drawing.Size(192, 44);
            this.btnUyeol.TabIndex = 4;
            this.btnUyeol.Text = "UYE OL";
            this.btnUyeol.UseVisualStyleBackColor = true;
            this.btnUyeol.Click += new System.EventHandler(this.btnUyeol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyelikTamamla);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textSifre);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtSoyadi);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Location = new System.Drawing.Point(50, 232);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(420, 350);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnUyelikTamamla
            // 
            this.btnUyelikTamamla.Location = new System.Drawing.Point(129, 302);
            this.btnUyelikTamamla.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyelikTamamla.Name = "btnUyelikTamamla";
            this.btnUyelikTamamla.Size = new System.Drawing.Size(192, 32);
            this.btnUyelikTamamla.TabIndex = 26;
            this.btnUyelikTamamla.Text = "MUŞTERi EKLE";
            this.btnUyelikTamamla.UseVisualStyleBackColor = true;
            this.btnUyelikTamamla.Click += new System.EventHandler(this.btnUyelikTamamla_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adı";
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(129, 235);
            this.textSifre.Margin = new System.Windows.Forms.Padding(4);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(190, 29);
            this.textSifre.TabIndex = 21;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(129, 195);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(190, 29);
            this.txtAdres.TabIndex = 21;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(129, 153);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(190, 29);
            this.txtTelefon.TabIndex = 20;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(129, 112);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(190, 29);
            this.txtSoyadi.TabIndex = 19;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(129, 31);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(190, 29);
            this.txtTC.TabIndex = 18;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(129, 71);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(190, 29);
            this.txtAdi.TabIndex = 18;
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(528, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUyeol);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre1);
            this.Controls.Add(this.txtKullaniciAdi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri ve Yönetici Giriş Ekranı";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi1;
        private TextBox txtSifre1;
        private Button btnGiris;
        private Button btnUyeol;
        private GroupBox groupBox1;
        private Button btnUyelikTamamla;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtSoyadi;
        private TextBox txtAdi;
        private Label label8;
        private Label label7;
        private TextBox textSifre;
        private TextBox txtTC;
    }
}