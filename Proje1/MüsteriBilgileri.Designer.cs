namespace Proje1
{
    partial class MusteriBilgileri
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::Proje1.Properties.Resources.Graphicloads_100_Flat_2_Add;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(112, 187);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Proje1.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_clear_history;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(112, 226);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(149, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Proje1.Properties.Resources.Graphicloads_100_Flat_Close;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(112, 265);
            this.btnSil.Name = "btnSil";
            this.btnSil.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSil.Size = new System.Drawing.Size(149, 33);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(499, 426);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAra
            // 
            this.btnAra.Image = global::Proje1.Properties.Resources.Rafiqul_Hassan_Blogger_Search;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(112, 405);
            this.btnAra.Name = "btnAra";
            this.btnAra.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAra.Size = new System.Drawing.Size(149, 33);
            this.btnAra.TabIndex = 11;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(112, 376);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(149, 23);
            this.txtAra.TabIndex = 10;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(54, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(47, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(42, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(64, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "TC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(59, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(112, 158);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(149, 23);
            this.txtSifre.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(112, 129);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(149, 23);
            this.txtAdres.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(112, 99);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(149, 23);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(112, 70);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(149, 23);
            this.txtSoyadi.TabIndex = 3;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(112, 12);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(149, 23);
            this.txtTC.TabIndex = 1;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(112, 41);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(149, 23);
            this.txtAdi.TabIndex = 2;
            // 
            // MusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtAdi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MusteriBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.MusteriBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private Button btnSil;
        private DataGridView dataGridView1;
        private Button btnAra;
        private TextBox txtAra;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox txtSifre;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtSoyadi;
        private TextBox txtTC;
        private TextBox txtAdi;
    }
}