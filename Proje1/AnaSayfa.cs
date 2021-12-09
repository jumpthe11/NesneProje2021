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
        Form2 newMDIChild;
        MusteriBilgileri newMDIChild2;
        urunBilgileri newMDIChild3;
        private void Yeni_Click(object sender, EventArgs e)
        {
            if (newMDIChild==null || newMDIChild.IsDisposed)
            {
                newMDIChild=new Form2();
                newMDIChild.Owner = this;
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        private void MüsteriBilgileri_Click(object sender, EventArgs e)
        {
            if (newMDIChild2 == null || newMDIChild2.IsDisposed)
            {
                newMDIChild2 = new MusteriBilgileri();
                newMDIChild2.Owner = this;
                newMDIChild2.MdiParent = this;
                newMDIChild2.Show();
            }
        }

        private void urunBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newMDIChild3 == null || newMDIChild3.IsDisposed)
            {
                newMDIChild3 = new urunBilgileri();
                newMDIChild3.Owner = this;
                newMDIChild3.MdiParent = this;
                newMDIChild3.Show();
            }
        }
    }
}
