namespace Proje1
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.File = new System.Windows.Forms.MenuStrip();
            this.Yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.MüsteriBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.urunBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pencere = new System.Windows.Forms.ToolStripMenuItem();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Yeni,
            this.MüsteriBilgileri,
            this.urunBilgileriToolStripMenuItem,
            this.firmaİşlemleriToolStripMenuItem,
            this.kategoriİşlemleriToolStripMenuItem,
            this.Pencere});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.MdiWindowListItem = this.Pencere;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(800, 34);
            this.File.TabIndex = 1;
            this.File.Text = "File";
            // 
            // Yeni
            // 
            this.Yeni.Image = global::Proje1.Properties.Resources.Icons_Land_Vista_People_Office_Customer_Male_Dark;
            this.Yeni.Name = "Yeni";
            this.Yeni.Size = new System.Drawing.Size(101, 30);
            this.Yeni.Text = "Yönetici Ekle";
            this.Yeni.Click += new System.EventHandler(this.Yeni_Click);
            // 
            // MüsteriBilgileri
            // 
            this.MüsteriBilgileri.BackColor = System.Drawing.SystemColors.Control;
            this.MüsteriBilgileri.ForeColor = System.Drawing.Color.Black;
            this.MüsteriBilgileri.Image = global::Proje1.Properties.Resources.Icojam_Blue_Bits_Users;
            this.MüsteriBilgileri.Name = "MüsteriBilgileri";
            this.MüsteriBilgileri.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MüsteriBilgileri.Size = new System.Drawing.Size(117, 30);
            this.MüsteriBilgileri.Text = "Müsteri Bilgileri";
            this.MüsteriBilgileri.Click += new System.EventHandler(this.MüsteriBilgileri_Click);
            // 
            // urunBilgileriToolStripMenuItem
            // 
            this.urunBilgileriToolStripMenuItem.Image = global::Proje1.Properties.Resources.Double_J_Design_Ravenna_3d_Box;
            this.urunBilgileriToolStripMenuItem.Name = "urunBilgileriToolStripMenuItem";
            this.urunBilgileriToolStripMenuItem.Size = new System.Drawing.Size(103, 30);
            this.urunBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            this.urunBilgileriToolStripMenuItem.Click += new System.EventHandler(this.urunBilgileriToolStripMenuItem_Click);
            // 
            // firmaİşlemleriToolStripMenuItem
            // 
            this.firmaİşlemleriToolStripMenuItem.Image = global::Proje1.Properties.Resources.Aha_Soft_Standard_City_University;
            this.firmaİşlemleriToolStripMenuItem.Name = "firmaİşlemleriToolStripMenuItem";
            this.firmaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(112, 30);
            this.firmaİşlemleriToolStripMenuItem.Text = "Firma İşlemleri";
            this.firmaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.firmaİşlemleriToolStripMenuItem_Click);
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.Image = global::Proje1.Properties.Resources.Acidrums4_Betelgeuse_Categories_applications_other;
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            this.kategoriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kategoriİşlemleriToolStripMenuItem_Click);
            // 
            // Pencere
            // 
            this.Pencere.Name = "Pencere";
            this.Pencere.Size = new System.Drawing.Size(61, 30);
            this.Pencere.Text = "Pencere";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.File);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.File;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip File;
        private ToolStripMenuItem Yeni;
        private ToolStripMenuItem Pencere;
        private ToolStripMenuItem MüsteriBilgileri;
        private ToolStripMenuItem urunBilgileriToolStripMenuItem;
        private ToolStripMenuItem firmaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
    }
}