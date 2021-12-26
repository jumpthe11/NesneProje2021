using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class odemeYap : Form
    {
        public odemeYap()
        {
            InitializeComponent();
        }

        int sipariID = 0;
        decimal toplamFiyat=0;
        decimal indirimliFiyat=0;
        
        havaleEftODeme havaleEftODeme = new havaleEftODeme();
        kredikartOdeme kredikartOdeme =new kredikartOdeme();
        nakitOdeme nakitOdeme=new nakitOdeme();
        private void odemeYap_Load(object sender, EventArgs e)
        {
            foreach (urun item in sepet.urunlerlistesi)
            {
                listBox1.Items.Add(item.urunAd);
                listBox2.Items.Add(item.urunAdet);
                listBox3.Items.Add(item.satisFiyati);
                listBox4.Items.Add(item.satisFiyati * item.urunAdet);
                toplamFiyat += item.satisFiyati * item.urunAdet;
                sipariID = item.siparisIDgetir();

            }
            havaleEftODeme.havEftKodu = sipariID;
            havaleEftODeme.toplamFiyat = toplamFiyat;
            havaleEftODeme.kdvHesapla(0.18M);
            havaleEftODeme.indirimHesapla(0.1M);

            //kredikartOdeme.havEftKodu = sipariID;
            havaleEftODeme.toplamFiyat = toplamFiyat;
            havaleEftODeme.kdvHesapla(0.18M);
            havaleEftODeme.indirimHesapla(0.1M);
            nakitAktifEtme();
        }

        private void nakitAktifEtme()
        {
            indirimliFiyat = toplamFiyat - toplamFiyat / 10;
            gbNakit.Visible = true;
            gbNakit.Location = new Point(370, 37);
            lblNGTop.Text = toplamFiyat.ToString();
            lblNiTop.Text = indirimliFiyat.ToString();
            gbKredikart.Visible = false;
            gbHavaleEft.Visible = false;
        }

        private void rdNakit_CheckedChanged(object sender, EventArgs e)
        {
            nakitAktifEtme();
        }
        private void rdKredikart_CheckedChanged(object sender, EventArgs e)
        {
            gbNakit.Visible = false;
            gbKredikart.Visible = true;
            gbKredikart.Location = new Point(370, 37);
            lblKKGt.Text = toplamFiyat.ToString();
            lblKKiTop.Text = indirimliFiyat.ToString();
            gbHavaleEft.Visible = false;
        }

        private void rdHavaleEft_CheckedChanged(object sender, EventArgs e)
        {
            gbNakit.Visible = false;
            gbKredikart.Visible = false;
            gbHavaleEft.Visible = true;
            gbHavaleEft.Location = new Point(370, 37);
            lblHEGTop.Text = toplamFiyat.ToString();
            lblHEiTop.Text = indirimliFiyat.ToString();
            lblHEKodu.Text=sipariID.ToString(); 
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdNakit.Checked)
            {
                siparisDurumu1();
                 string message = "Sipariş tamamlanmıştır.\n Müşteriden nakit ödemeyi aldığınıza emin olunuz..";
                projeyiKapat(message);
            }
            else if (rdHavaleEft.Checked)
            {
                siparisDurumu1();
                string message = "Iban No: " + havaleEftODeme.Iban + "\n Havale/EFT Kodu: " + havaleEftODeme.havEftKodu + "\n Sipariş tamamlanmıştır.\n Ödeme yaparken açıklama kısmına eft kodunuzu yazmayı unutmayınız.";
                projeyiKapat(message);
            }
            else if (rdKredikart.Checked)
            {
                kredikartOdeme.bilgiEkle(txtKartno.Text,txtAdsoyad.Text, Convert.ToInt32(txtAy.SelectedItem), Convert.ToInt32(txtYil.SelectedItem),Convert.ToInt32(txtCvv.Text))
;                siparisDurumu1();
                string message="Kart No        : " + kredikartOdeme.KredikartNo +
                    "\n İsim Soyisim        : " + kredikartOdeme.AdSoyad +
                    "\n Kart No     : " + kredikartOdeme.KredikartNo +
                    "\n Son Kullanma Tarihi: " + kredikartOdeme.SonKulAy +"/"+kredikartOdeme.SonKulYil+
                    "CVV : " + kredikartOdeme.CVV +
                    "\n Sipariş tamamlanmıştır.\n Ödemeniz başarıyla alınmıştır.";
                projeyiKapat(message);
            }
        }

        private static void projeyiKapat(string message)
        {
            const string caption = "Uygulamayı Kapat";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void siparisDurumu1()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE siparis SET siparisDurumu=@siparisDurumu WHERE siparisID='" + sipariID + "'", baglanti);
            cmd.Parameters.AddWithValue("@siparisDurumu", 1);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglanti.Close();
        }

        private void odemeYap_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void odemeYap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
