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
    public partial class yoneticiEkle : Form
    {
        public yoneticiEkle()
        {
            InitializeComponent();
        }

        private void btnUyelikTamamla_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");

        private void btnYoneticiekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTC.Text.Trim() != "" && textSifre.Text.Trim() != "")
                {
                    baglanti.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO kullaniciGiris(TC,sifre,kullaniciTuru) VALUES(@TC,@sifre,@kullaniciTuru)", baglanti);
                    cmd2.Parameters.AddWithValue("@TC", txtTC.Text);
                    cmd2.Parameters.AddWithValue("@sifre", textSifre.Text);
                    cmd2.Parameters.AddWithValue("@kullaniciTuru", true);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    baglanti.Close();
                    foreach (Control kontrol in this.Controls)
                    {
                        if (kontrol is TextBox)
                            kontrol.Text = "";
                    }
                    MessageBox.Show("EKLENDİ");
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldorunuz...!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("TC bilginiz kayıtlı ise kayıt olamazsınız");
            }
        }
    }
}
