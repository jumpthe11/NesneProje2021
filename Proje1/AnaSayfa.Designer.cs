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
            this.File = new System.Windows.Forms.MenuStrip();
            this.Yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.Pencere = new System.Windows.Forms.ToolStripMenuItem();
            this.MüsteriBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.urunBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Yeni,
            this.Pencere,
            this.MüsteriBilgileri,
            this.urunBilgileriToolStripMenuItem});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.MdiWindowListItem = this.Pencere;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(800, 24);
            this.File.TabIndex = 1;
            this.File.Text = "File";
            // 
            // Yeni
            // 
            this.Yeni.Name = "Yeni";
            this.Yeni.Size = new System.Drawing.Size(41, 20);
            this.Yeni.Text = "Yeni";
            this.Yeni.Click += new System.EventHandler(this.Yeni_Click);
            // 
            // Pencere
            // 
            this.Pencere.Name = "Pencere";
            this.Pencere.Size = new System.Drawing.Size(61, 20);
            this.Pencere.Text = "Pencere";
            // 
            // MüsteriBilgileri
            // 
            this.MüsteriBilgileri.Name = "MüsteriBilgileri";
            this.MüsteriBilgileri.Size = new System.Drawing.Size(98, 20);
            this.MüsteriBilgileri.Text = "MüsteriBilgileri";
            this.MüsteriBilgileri.Click += new System.EventHandler(this.MüsteriBilgileri_Click);
            // 
            // urunBilgileriToolStripMenuItem
            // 
            this.urunBilgileriToolStripMenuItem.Name = "urunBilgileriToolStripMenuItem";
            this.urunBilgileriToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.urunBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            this.urunBilgileriToolStripMenuItem.Click += new System.EventHandler(this.urunBilgileriToolStripMenuItem_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.File);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.File;
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}