namespace Proje1
{
    partial class urunBilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUrunadi = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisfiyati = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbxFirmaAdi = new System.Windows.Forms.ComboBox();
            this.cmbxKategoriAdi = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSparisMiktari = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunadi
            // 
            this.txtUrunadi.Location = new System.Drawing.Point(86, 40);
            this.txtUrunadi.Name = "txtUrunadi";
            this.txtUrunadi.Size = new System.Drawing.Size(175, 23);
            this.txtUrunadi.TabIndex = 1;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(86, 127);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(175, 23);
            this.txtAlisFiyati.TabIndex = 4;
            // 
            // txtSatisfiyati
            // 
            this.txtSatisfiyati.Location = new System.Drawing.Point(86, 156);
            this.txtSatisfiyati.Name = "txtSatisfiyati";
            this.txtSatisfiyati.Size = new System.Drawing.Size(175, 23);
            this.txtSatisfiyati.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Firma Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aliş Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategori";
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEkle.Image = global::Proje1.Properties.Resources.Graphicloads_100_Flat_2_Add;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(86, 320);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEkle.Size = new System.Drawing.Size(175, 33);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Image = global::Proje1.Properties.Resources.Graphicloads_100_Flat_Close;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(86, 359);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSil.Size = new System.Drawing.Size(175, 33);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAra.Image = global::Proje1.Properties.Resources.Rafiqul_Hassan_Blogger_Search;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(86, 427);
            this.btnAra.Name = "btnAra";
            this.btnAra.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAra.Size = new System.Drawing.Size(175, 33);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(675, 482);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbxFirmaAdi
            // 
            this.cmbxFirmaAdi.FormattingEnabled = true;
            this.cmbxFirmaAdi.Location = new System.Drawing.Point(86, 69);
            this.cmbxFirmaAdi.Name = "cmbxFirmaAdi";
            this.cmbxFirmaAdi.Size = new System.Drawing.Size(175, 23);
            this.cmbxFirmaAdi.TabIndex = 2;
            this.cmbxFirmaAdi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbxKategoriAdi
            // 
            this.cmbxKategoriAdi.FormattingEnabled = true;
            this.cmbxKategoriAdi.Location = new System.Drawing.Point(86, 98);
            this.cmbxKategoriAdi.Name = "cmbxKategoriAdi";
            this.cmbxKategoriAdi.Size = new System.Drawing.Size(175, 23);
            this.cmbxKategoriAdi.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.Image = global::Proje1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_history;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(86, 281);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGuncelle.Size = new System.Drawing.Size(175, 33);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtAra
            // 
            this.txtAra.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtAra.Location = new System.Drawing.Point(86, 398);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(175, 23);
            this.txtAra.TabIndex = 12;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(86, 11);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.ReadOnly = true;
            this.txtUrunID.Size = new System.Drawing.Size(175, 23);
            this.txtUrunID.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ürün ID";
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(86, 185);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(175, 23);
            this.txtStokMiktari.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Stok Miktarı";
            // 
            // txtSparisMiktari
            // 
            this.txtSparisMiktari.Location = new System.Drawing.Point(86, 214);
            this.txtSparisMiktari.Name = "txtSparisMiktari";
            this.txtSparisMiktari.Size = new System.Drawing.Size(175, 23);
            this.txtSparisMiktari.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Spariş Miktarı";
            // 
            // btnTemizle
            // 
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTemizle.Image = global::Proje1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_locationbar_rtl;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(86, 243);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnTemizle.Size = new System.Drawing.Size(175, 33);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // urunBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(958, 496);
            this.Controls.Add(this.cmbxKategoriAdi);
            this.Controls.Add(this.cmbxFirmaAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSparisMiktari);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.txtSatisfiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.txtUrunadi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "urunBilgileri";
            this.Text = "Ürün Bilgileri";
            this.Load += new System.EventHandler(this.urunBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUrunadi;
        private TextBox txtAlisFiyati;
        private TextBox txtSatisfiyati;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnEkle;
        private Button btnSil;
        private Button btnAra;
        private DataGridView dataGridView1;
        private ComboBox cmbxFirmaAdi;
        private ComboBox cmbxKategoriAdi;
        private Button btnGuncelle;
        private TextBox txtAra;
        private TextBox txtUrunID;
        private Label label7;
        private TextBox txtStokMiktari;
        private Label label8;
        private TextBox txtSparisMiktari;
        private Label label9;
        private Button btnTemizle;
    }
}