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
      
    public partial class kategoriIslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        DataSet ds = new DataSet();
        public kategoriIslemleri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO kategori(kategoriAdi) VALUES (@kategoriAdi)", baglanti);
                cmd.Parameters.AddWithValue("@kategoriAdi", txtKategoriAdi.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["kategori"].Clear();
                kayitGoster("kategori");
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

        private void kategoriIslemleri_Load(object sender, EventArgs e)
        {
            kayitGoster("kategori");
        }
        private void kayitGoster(string a)//KAyıtları datagrid de gösterir.
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from " + a, baglanti);
            adtr.Fill(ds, a);
            dataGridView1.DataSource = ds.Tables[a];
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() != "" )
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE kategori SET kategoriAdi=@kategoriAdi WHERE kategoriID='" + txtKategoriID.Text + "'", baglanti);
                cmd.Parameters.AddWithValue("@kategoriAdi", txtKategoriAdi.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["kategori"].Clear();
                kayitGoster("kategori");
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKategoriID.Text = dataGridView1.CurrentRow.Cells["kategoriID"].Value.ToString();
            txtKategoriAdi.Text = dataGridView1.CurrentRow.Cells["kategoriAdi"].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM kategori WHERE kategoriAdi like '%" + txtAra.Text + "%'", baglanti);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM kategori WHERE kategoriAdi like '%" + txtAra.Text + "%'", baglanti);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKategoriID.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd9 = new SqlCommand("delete from kategori WHERE kategoriID=" + txtKategoriID.Text, baglanti);
                cmd9.ExecuteNonQuery();
                cmd9.Dispose();
                baglanti.Close();
                ds.Tables["kategori"].Clear();
                kayitGoster("kategori");
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
