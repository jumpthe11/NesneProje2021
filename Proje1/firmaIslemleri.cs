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
    public partial class firmaIslemleri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        DataSet ds = new DataSet();
        public firmaIslemleri()
        {
            InitializeComponent();
        }

        private void firmaIslemleri_Load(object sender, EventArgs e)
        {
            kayitGoster("firma");
        }
        private void kayitGoster(string a)//KAyıtları datagrid de gösterir.
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from " + a, baglanti);
            adtr.Fill(ds, a);
            dataGridView1.DataSource = ds.Tables[a];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO firma(saticiFirmaAdi,adres,telefon) VALUES (@saticiFirmaAdi,@adres,@telefon)",baglanti);
                cmd.Parameters.AddWithValue("@saticiFirmaAdi",txtAdi.Text);
                cmd.Parameters.AddWithValue("@adres",txtAdres.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["firma"].Clear();
                kayitGoster("firma");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtAdres.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE firma SET saticiFirmaAdi=@saticiFirmaAdi,adres=@adres,telefon=@telefon WHERE saticiFirmaID='"+txtID.Text+"'", baglanti);
                cmd.Parameters.AddWithValue("@saticiFirmaAdi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["firma"].Clear();
                kayitGoster("firma");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["saticiFirmaID"].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells["saticiFirmaAdi"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM firma WHERE saticiFirmaAdi like '%" + txtAra.Text + "%' OR adres like '%" + txtAra.Text + "%' OR telefon like '%" + txtAra.Text + "%'", baglanti);
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd9 = new SqlCommand("DELETE FROM firma WHERE saticiFirmaID=" + txtID.Text, baglanti);
                cmd9.ExecuteNonQuery();
                cmd9.Dispose();
                baglanti.Close();
                ds.Tables["firma"].Clear();
                kayitGoster("firma");
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
