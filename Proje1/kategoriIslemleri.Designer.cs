namespace Proje1
{
    partial class kategoriIslemleri
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
            this.txtKategoriID = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKategoriID
            // 
            this.txtKategoriID.Location = new System.Drawing.Point(101, 27);
            this.txtKategoriID.Name = "txtKategoriID";
            this.txtKategoriID.ReadOnly = true;
            this.txtKategoriID.Size = new System.Drawing.Size(149, 23);
            this.txtKategoriID.TabIndex = 42;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(101, 429);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(149, 23);
            this.txtAra.TabIndex = 41;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Image = global::Proje1.Properties.Resources.Rafiqul_Hassan_Blogger_Search;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(101, 458);
            this.btnAra.Name = "btnAra";
            this.btnAra.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAra.Size = new System.Drawing.Size(149, 33);
            this.btnAra.TabIndex = 40;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(256, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(413, 479);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Proje1.Properties.Resources.Graphicloads_100_Flat_Close;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(101, 163);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSil.Size = new System.Drawing.Size(149, 33);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::Proje1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_history;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(101, 124);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGuncelle.Size = new System.Drawing.Size(149, 33);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::Proje1.Properties.Resources.Graphicloads_100_Flat_2_Add;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(101, 85);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEkle.Size = new System.Drawing.Size(149, 33);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kategori No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(101, 56);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(149, 23);
            this.txtKategoriAdi.TabIndex = 29;
            // 
            // kategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(681, 503);
            this.Controls.Add(this.txtKategoriID);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKategoriAdi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "kategoriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kategori İşlemleri";
            this.Load += new System.EventHandler(this.kategoriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtKategoriID;
        private TextBox txtAra;
        private Button btnAra;
        private DataGridView dataGridView1;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Label label2;
        private Label label1;
        private TextBox txtKategoriAdi;
    }
}