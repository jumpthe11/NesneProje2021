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
            kayitGoster("tblMusteri");
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
            
            if (txtAdi.Text.Trim()!=""&&txtSoyadi.Text.Trim() != ""&&txtTelefon.Text.Trim() != ""&&txtAdres.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblMusteri(mstrAdi,mstrSoyadi,mstrTelefon,mstrAdres) VALUES (@mstrAdi,@mstrSoyadi,@mstrTelefon,@mstrAdres)",baglanti);
                cmd.Parameters.AddWithValue("@mstrAdi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@mstrSoyadi", txtSoyadi.Text);
                cmd.Parameters.AddWithValue("@mstrTelefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@mstrAdres", txtAdres.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAdi.Text= dataGridView1.CurrentRow.Cells["mstrAdi"].Value.ToString();
            txtSoyadi.Text= dataGridView1.CurrentRow.Cells["mstrSoyadi"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["mstrTelefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["mstrAdres"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tblMusteri SET mstrAdi=@mstrAdi,mstrSoyadi=@mstrSoyadi,mstrTelefon=@mstrTelefon,mstrAdres=@mstrAdres WHERE mstrTelefon=@mstrTelefon", baglanti);
                cmd.Parameters.AddWithValue("@mstrAdi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@mstrSoyadi", txtSoyadi.Text);
                cmd.Parameters.AddWithValue("@mstrTelefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@mstrAdres", txtAdres.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                ds.Tables["tblMusteri"].Clear();
                kayitGoster("tblMusteri");
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
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM tblMusteri WHERE mstrTelefon like '%"+txtAra.Text+"%'",baglanti);
            adtr.Fill(table);
            dataGridView1.DataSource= table;
            baglanti.Close();


        }
    }
}
