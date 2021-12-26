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
    public partial class siparisIslemleri : Form
    {
        public siparisIslemleri()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void siparisIslemleri_Load(object sender, EventArgs e)
        {
            kayitGoster();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        DataSet ds = new DataSet();
        
        private void kayitGoster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select urunID AS URUNID,stokMiktari AS STOKMIKTARI,urunAd AS URUNADI,satisFiyati AS SATISFIYATI from urun WHERE stokMiktari>0", baglanti);
            adtr.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            baglanti.Close();
            
        }
        int sepetUrunMiktar = 0;
        bool urunDurum=false;
        sepet Sepet = new sepet();
        int stokmiktar = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            stokmiktar = Convert.ToInt32(dataGridView1.CurrentRow.Cells["STOKMIKTARI"].Value);
            btnSepet.Text = Convert.ToString(++ sepetUrunMiktar);
            if (stokmiktar>0)
            {                
                if (sepet.urunlerlistesi.Count == 0)
                {
                    new sepet(Convert.ToString(dataGridView1.CurrentRow.Cells["URUNID"].Value), Convert.ToString(dataGridView1.CurrentRow.Cells["URUNADI"].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SATISFIYATI"].Value),stokmiktar, true, 1);
                    stokmiktar--;
                }
                else
                {
                    foreach (urun URUN in sepet.urunlerlistesi)
                    {
                        if (URUN.urunAd == Convert.ToString(dataGridView1.CurrentRow.Cells["URUNADI"].Value))
                        {
                            URUN.urunAdet++;
                            stokmiktar--;
                            urunDurum = false;
                            break;

                        }
                        else { urunDurum = true; }
                    }
                }
                if (urunDurum)
                {
                    new sepet(Convert.ToString(dataGridView1.CurrentRow.Cells["urunID"].Value), Convert.ToString(dataGridView1.CurrentRow.Cells["URUNADI"].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SATISFIYATI"].Value), stokmiktar, true, 1);
                    stokmiktar--;
                    urunDurum = false;
                }
                dataGridView2.DataSource = "";
                dataGridView2.DataSource = sepet.urunlerlistesi;
            }
            else
            {
                MessageBox.Show("Yeterli stok yok");
            }
        }

       
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ControlBox = false;
            urun URUN2 = new urun();
            string tc = "";
            int musteriID = 0;
            foreach (urun URUN in sepet.urunlerlistesi)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO siparisDetay(siparisID,urunID,birimFiyat,miktar) VALUES (@siparisID,@urunID,@birimFiyat,@miktar)", baglanti);
                cmd.Parameters.AddWithValue("@siparisID",URUN.siparisIDgetir());
                cmd.Parameters.AddWithValue("@urunID", URUN.urunID);
                cmd.Parameters.AddWithValue("@birimFiyat", URUN.satisFiyati);
                cmd.Parameters.AddWithValue("@miktar", URUN.urunAdet);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                tc=URUN.getirTC();
            }
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("SELECT mstrID FROM musteri where TC = '" + tc + "'", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();
            while (rd7.Read()) // reader Okuyabiliyorsa
            {
                musteriID=Convert.ToInt16(rd7["mstrID"]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO siparis(siparisID,musteriID,siparisTarihi) VALUES (@siparisID,@musteriID,@siparisTarihi)", baglanti);
            cmd2.Parameters.AddWithValue("@siparisID", URUN2.siparisIDgetir());
            cmd2.Parameters.AddWithValue("@musteriID", musteriID);
            cmd2.Parameters.AddWithValue("@siparisTarihi", DateTime.Now);
            cmd2.ExecuteNonQuery();
            cmd2.Dispose();
            baglanti.Close();
            siparisDetaylari siparisislemler = new siparisDetaylari();
            siparisislemler.Show();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {         
            for (int i = 0; i < sepet.urunlerlistesi.Count; i++)
            {
                if (sepet.urunlerlistesi[i].urunAd== Convert.ToString(dataGridView2.CurrentRow.Cells["urunAd"].Value) && sepet.urunlerlistesi[i].urunAdet==1)
                {
                    sepet.urunlerlistesi.RemoveAt(sepet.urunlerlistesi.IndexOf(sepet.urunlerlistesi[i]));
                    btnSepet.Text =Convert.ToString(-- sepetUrunMiktar);
                    stokmiktar++;
                }
                else if (sepet.urunlerlistesi[i].urunAd == Convert.ToString(dataGridView2.CurrentRow.Cells["urunAd"].Value) && sepet.urunlerlistesi[i].urunAdet > 1)
                {
                    sepet.urunlerlistesi[i].urunAdet--;
                    btnSepet.Text = Convert.ToString(--sepetUrunMiktar);
                    stokmiktar--;
                }
            }

            dataGridView2.DataSource = "";
            dataGridView2.DataSource = sepet.urunlerlistesi;
        }

        private void sepetKapat_Click(object sender, EventArgs e)
        {
            urun URUN2 = new urun();

            baglanti.Open();
            SqlCommand cmd9 = new SqlCommand("delete from siparisDetay WHERE siparisID=" + URUN2.siparisIDgetir(), baglanti);
            cmd9.ExecuteNonQuery();
            cmd9.Dispose();
            baglanti.Close();
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("delete from siparis WHERE siparisID=" + URUN2.siparisIDgetir(), baglanti);
            cmd8.ExecuteNonQuery();
            cmd8.Dispose();
            baglanti.Close();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
