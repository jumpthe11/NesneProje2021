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
    public partial class urunBilgileri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        DataSet ds = new DataSet();

        public urunBilgileri()
        {
            InitializeComponent();
        }
        string saticiFirmaID=" ";
        string kategoriID= " ";
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunadi.Text.Trim() != "" && cmbxFirmaAdi.Text.Trim() != "" && cmbxKategoriAdi.Text.Trim() != "" && txtAlisFiyati.Text.Trim() != "" && txtSatisfiyati.Text.Trim() != "" && txtStokMiktari.Text.Trim() != "" && txtSparisMiktari.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd5= new SqlCommand("select * from kategori where kategoriAdi='" + cmbxKategoriAdi.SelectedItem.ToString() + "'", baglanti);
                SqlDataReader oku5 = cmd5.ExecuteReader();
                while (oku5.Read())
                    kategoriID = oku5["kategoriID"].ToString();
                baglanti.Close();
                baglanti.Open();
                SqlCommand cmd6 = new SqlCommand("select * from firma where saticiFirmaAdi='" + cmbxFirmaAdi.SelectedItem.ToString() + "'", baglanti);
                SqlDataReader oku6 =cmd6.ExecuteReader();
                while (oku6.Read())
                    saticiFirmaID = oku6["saticiFirmaID"].ToString();
                baglanti.Close();
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO urun(urunAd,saticiFirmaID,kategoriID,alisFiyati,satisFiyati,stokMiktari,siparisMiktari) VALUES (@urunAd,@saticiFirmaID,@kategoriID,@alisFiyati,@satisFiyati,@stokMiktari,@siparisMiktari)", baglanti);
                cmd.Parameters.AddWithValue("@urunAd", txtUrunadi.Text);
                cmd.Parameters.AddWithValue("@saticiFirmaID", saticiFirmaID);
                cmd.Parameters.AddWithValue("@kategoriID", kategoriID);
                cmd.Parameters.AddWithValue("@alisFiyati", txtAlisFiyati.Text);
                cmd.Parameters.AddWithValue("@satisFiyati", txtSatisfiyati.Text);
                cmd.Parameters.AddWithValue("@stokMiktari", txtStokMiktari.Text);
                cmd.Parameters.AddWithValue("@siparisMiktari", txtSparisMiktari.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["urun"].Clear();
                kayitGoster();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void urunBilgileri_Load(object sender, EventArgs e)
        {
            kayitGoster();
        }

        private void kayitGoster()
        {
            cmbxFirmaAdi.Items.Clear();
            cmbxKategoriAdi.Items.Clear();  
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from kategori", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmbxKategoriAdi.Items.Add(oku["kategoriAdi"].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from firma", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                cmbxFirmaAdi.Items.Add(oku2["saticiFirmaAdi"].ToString());
            }
            baglanti.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunID.Text = dataGridView1.CurrentRow.Cells["urunID"].Value.ToString();
            txtUrunadi.Text = dataGridView1.CurrentRow.Cells["urunAd"].Value.ToString();
            //
            baglanti.Open();//combobax a kategori listesi çekilir
            SqlCommand cmd3 = new SqlCommand("select * from kategori where kategoriID='"+dataGridView1.CurrentRow.Cells["kategoriID"].Value + "'", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();
            while (oku3.Read())
            {
                cmbxKategoriAdi.SelectedItem = oku3["kategoriAdi"].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select * from firma where saticiFirmaID='" + dataGridView1.CurrentRow.Cells["saticiFirmaID"].Value + "'", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();
            while (oku4.Read())
            {
                cmbxFirmaAdi.SelectedItem = oku4["saticiFirmaAdi"].ToString();
            }
            baglanti.Close();

            //
            txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells["alisFiyati"].Value.ToString();
            txtSatisfiyati.Text = dataGridView1.CurrentRow.Cells["satisFiyati"].Value.ToString();
            txtStokMiktari.Text = dataGridView1.CurrentRow.Cells["stokMiktari"].Value.ToString();
            txtSparisMiktari.Text = dataGridView1.CurrentRow.Cells["siparisMiktari"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd5 = new SqlCommand("DELETE FROM urun WHERE urunID=" + txtUrunID.Text, baglanti);
                cmd5.ExecuteNonQuery();
                cmd5.Dispose();
                baglanti.Close();               
                ds.Clear();
                kayitGoster();
                foreach (Control kontrol in this.Controls)
                {
                    if (kontrol is TextBox)
                        kontrol.Text = "";
                }
                MessageBox.Show("Silme başarılı..");
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz çift tıklayınız");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control kontrol in this.Controls)
            {
                if (kontrol is TextBox)
                    kontrol.Text = "";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunadi.Text.Trim() != "" && cmbxFirmaAdi.Text.Trim() != "" && cmbxKategoriAdi.Text.Trim() != "" && txtAlisFiyati.Text.Trim() != "" && txtSatisfiyati.Text.Trim() != "" && txtStokMiktari.Text.Trim() != "" && txtSparisMiktari.Text.Trim() != "")
            {
                if (cmbxKategoriAdi.SelectedItem.ToString()!=null)
                {
                    baglanti.Open();
                    SqlCommand cmd5 = new SqlCommand("select * from kategori where kategoriAdi='" + cmbxKategoriAdi.SelectedItem.ToString() + "'", baglanti);
                    SqlDataReader oku5 = cmd5.ExecuteReader();
                    while (oku5.Read())
                        kategoriID = oku5["kategoriID"].ToString();
                    baglanti.Close();
                }            
                if (cmbxFirmaAdi.SelectedItem.ToString()!=null)
                {
                    baglanti.Open();
                    SqlCommand cmd6 = new SqlCommand("select * from firma where saticiFirmaAdi='" + cmbxFirmaAdi.SelectedItem.ToString() + "'", baglanti);
                    SqlDataReader oku6 = cmd6.ExecuteReader();
                    while (oku6.Read())
                        saticiFirmaID = oku6["saticiFirmaID"].ToString();
                    baglanti.Close();
                }                
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE urun SET urunAd=@urunAd,saticiFirmaID=@saticiFirmaID,kategoriID=@kategoriID,alisFiyati=@alisFiyati,satisFiyati=@satisFiyati,stokMiktari=@stokMiktari,siparisMiktari=@siparisMiktari WHERE urunID='" + txtUrunID.Text + "'", baglanti);
                cmd.Parameters.AddWithValue("@urunAd", txtUrunadi.Text);
                cmd.Parameters.AddWithValue("@saticiFirmaID", saticiFirmaID);
                cmd.Parameters.AddWithValue("@kategoriID", kategoriID);
                cmd.Parameters.AddWithValue("@alisFiyati", txtAlisFiyati.Text);
                cmd.Parameters.AddWithValue("@satisFiyati", txtSatisfiyati.Text);
                cmd.Parameters.AddWithValue("@stokMiktari", txtStokMiktari.Text);
                cmd.Parameters.AddWithValue("@siparisMiktari", txtSparisMiktari.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["urun"].Clear();
                kayitGoster();
                foreach (Control kontrol in this.Controls)
                {
                    if (kontrol is TextBox)
                        kontrol.Text = "";
                }
                MessageBox.Show("GÜNCELLEME BAŞARILI...");
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldorunuz...!!!");
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM urun WHERE urunAd like '%" + txtAra.Text + "%' OR saticiFirmaID like '%" + txtAra.Text + "%' OR urunID like '%" + txtAra.Text + "%'", baglanti);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
    }
}
