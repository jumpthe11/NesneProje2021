using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje1
{
    
    public partial class AnaSayfa : Form
    {
        
        
        public bool MDIFormAcikmi(string formAdi)
        {
            FormCollection fc=new FormCollection();
            foreach (Form form in fc)
                if (form.Name == formAdi)
                    return true;
            return false;
        }
        public AnaSayfa()
        {
            InitializeComponent();
        }
        yoneticiEkle newMDIChild;
        MusteriBilgileri mesteribilgileri;
        urunBilgileri urunbilgileri;
        firmaIslemleri firmaislemleri;
        kategoriIslemleri kategoriislemleri;
        private void Yeni_Click(object sender, EventArgs e)
        {
            if (newMDIChild==null || newMDIChild.IsDisposed)
            {
                newMDIChild=new yoneticiEkle();
                newMDIChild.Owner = this;
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        private void MüsteriBilgileri_Click(object sender, EventArgs e)
        {
            if (mesteribilgileri == null || mesteribilgileri.IsDisposed)
            {
                mesteribilgileri = new MusteriBilgileri();
                mesteribilgileri.Owner = this;
                mesteribilgileri.MdiParent = this;
                mesteribilgileri.Show();
            }
        }

        private void urunBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunbilgileri == null || urunbilgileri.IsDisposed)
            {
                urunbilgileri = new urunBilgileri();
                urunbilgileri.Owner = this;
                urunbilgileri.MdiParent = this;
                urunbilgileri.Show();
            }
        }

        private void firmaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (firmaislemleri == null || firmaislemleri.IsDisposed)
            {
                firmaislemleri = new firmaIslemleri();
                firmaislemleri.Owner = this;
                firmaislemleri.MdiParent = this;
                firmaislemleri.Show();
            }
        }

        private void kategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kategoriislemleri == null || kategoriislemleri.IsDisposed)
            {
                kategoriislemleri = new kategoriIslemleri();
                kategoriislemleri.Owner = this;
                kategoriislemleri.MdiParent = this;
                kategoriislemleri.Show();
            }
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
