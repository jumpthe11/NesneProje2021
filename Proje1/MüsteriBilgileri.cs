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
    public partial class MusteriBilgileri : Form
    {
        public MusteriBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        DataSet ds = new DataSet(); 
        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            kayitGoster("musteri");
        }

        private void kayitGoster(string a)//KAyıtları datagrid de gösterir.
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from "+a, baglanti);
            adtr.Fill(ds, a);
            dataGridView1.DataSource = ds.Tables[a];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTC.Text.Trim() != "" && txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtSifre.Text.Trim() != "")
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO musteri(TC,mstrAdi,mstrSoyadi,mstrTelefon,mstrAdres) VALUES (@TC,@mstrAdi,@mstrSoyadi,@mstrTelefon,@mstrAdres)", baglanti);
                    cmd.Parameters.AddWithValue("@TC", txtTC.Text);
                    cmd.Parameters.AddWithValue("@mstrAdi", txtAdi.Text);
                    cmd.Parameters.AddWithValue("@mstrSoyadi", txtSoyadi.Text);
                    cmd.Parameters.AddWithValue("@mstrTelefon", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@mstrAdres", txtAdres.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO kullaniciGiris(TC,sifre,kullaniciTuru) VALUES(@TC,@sifre,@kullaniciTuru)", baglanti);
                    cmd2.Parameters.AddWithValue("@TC", txtTC.Text);
                    cmd2.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd2.Parameters.AddWithValue("@kullaniciTuru", false);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    baglanti.Close();
                    
                    ds.Tables["musteri"].Clear();
                    kayitGoster("musteri");
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
                MessageBox.Show("Eksik bilgiler var.\n Ekleme yapamazsınız.\n Aynı TC ile ekleme yapamazsınız.");
            }
           
        }  

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd3 = new SqlCommand("UPDATE musteri SET mstrAdi=@mstrAdi,mstrSoyadi=@mstrSoyadi,mstrTelefon=@mstrTelefon,mstrAdres=@mstrAdres WHERE TC='" + txtTC.Text + "'", baglanti);
                cmd3.Parameters.AddWithValue("@mstrAdi", txtAdi.Text);
                cmd3.Parameters.AddWithValue("@mstrSoyadi", txtSoyadi.Text);
                cmd3.Parameters.AddWithValue("@mstrTelefon", txtTelefon.Text);
                cmd3.Parameters.AddWithValue("@mstrAdres", txtAdres.Text);
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                baglanti.Close();
                if (txtSifre.Text.Trim() != "")
                {
                    baglanti.Open();
                    SqlCommand cmd4 = new SqlCommand("UPDATE kullaniciGiris SET sifre=@sifre WHERE TC='" + txtTC.Text + "'", baglanti);
                    cmd4.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd4.ExecuteNonQuery();
                    cmd4.Dispose();
                    baglanti.Close();
                }                
                ds.Tables["musteri"].Clear();
                kayitGoster("musteri");
                foreach (Control kontrol in this.Controls)
                {
                    if (kontrol is TextBox)
                        kontrol.Text = "";
                }
                MessageBox.Show("GÜNCELLENDİ");
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldorunuz...!!!");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM musteri WHERE mstrTelefon like '%"+txtAra.Text+"%'",baglanti);
            adtr.Fill(table);
            dataGridView1.DataSource= table;
            baglanti.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM musteri WHERE mstrTelefon like '%" + txtAra.Text+ "%' OR TC like '%" + txtAra.Text + "%' OR mstrAdi like '%" + txtAra.Text  + "%' OR mstrSoyadi like '%" + txtAra.Text + "%'", baglanti);
            adtr.Fill(table1);
            dataGridView1.DataSource = table1;
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells["mstrAdi"].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells["mstrSoyadi"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["mstrTelefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["mstrAdres"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTC.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd5 = new SqlCommand("delete from musteri WHERE TC=" + txtTC.Text, baglanti);
                cmd5.ExecuteNonQuery();
                cmd5.Dispose();
                baglanti.Close();
                baglanti.Open();
                SqlCommand cmd6 = new SqlCommand("delete from musteri WHERE TC=" + txtTC.Text, baglanti);
                cmd6.ExecuteNonQuery();
                cmd6.Dispose();
                baglanti.Close();
                ds.Tables["musteri"].Clear();
                kayitGoster("musteri");
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
    }
}
