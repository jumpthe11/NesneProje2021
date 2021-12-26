using System.Data.SqlClient;

namespace Proje1
{
    public partial class Giris : Form
    {
        
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("SELECT MAX(siparisID) FROM siparis", baglanti);
            SqlDataReader rd7 = cmd7.ExecuteReader();
            while (rd7.Read()) // reader Okuyabiliyorsa
            {
                new urun(txtKullaniciAdi1.Text, Convert.ToInt16(rd7[0]) + 1);
            }
            baglanti.Close();
            try
            {
                baglanti.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT * FROM kullaniciGiris WHERE TC=@TC AND sifre=@sifre", baglanti);
                cmd3.Parameters.AddWithValue("@TC", txtKullaniciAdi1.Text);
                cmd3.Parameters.AddWithValue("@sifre", txtSifre1.Text);
                SqlDataReader rd3 = cmd3.ExecuteReader();
                
                if (rd3.HasRows) // Girilen K.Adý ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd3.Read()) // reader Okuyabiliyorsa
                    {
                        if (Convert.ToInt16(rd3["kullaniciTuru"])==1) // 1 Rolü Admin'e ait olarak Ayarlanmýþdýr
                        {
                            // Kullanýcý Rolü 1 ise Admin Ekraný Aç 
                            AnaSayfa formGiris = new AnaSayfa();
                            formGiris.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Kullanýcý Rolü 1 dýþýnda ise Kullanýcý Ekraný Aç
                            siparisIslemleri formGiris = new siparisIslemleri();
                            formGiris.Show();
                            this.Hide();
                        }
                    }
                }
                else /// Reader SATIR döndüremiyorsa K.Adý Parola Yanlýþ Demekdir
                {
                    rd3.Close();
                    MessageBox.Show("Kullanýcý Adý veya Parola Geçersizdir", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            baglanti.Close();
            }

            catch // Baðlantý açamayýp Sorgu Çalýþtýramýyorsa Veritabanýna Ulaþamýyor Demekdir
            {
                MessageBox.Show("DB ye ulaþýlamadý", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUyeol_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnUyelikTamamla_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTC.Text.Trim() != "" && txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "" && txtAdres.Text.Trim() != "" && textSifre.Text.Trim() != "")
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
                    cmd2.Parameters.AddWithValue("@sifre", textSifre.Text);
                    cmd2.Parameters.AddWithValue("@kullaniciTuru", false);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    baglanti.Close();
                    foreach (Control kontrol in this.Controls)
                    {
                        if (kontrol is TextBox)
                            kontrol.Text = "";
                    }
                    MessageBox.Show("EKLENDÝ");
                }
                else
                {
                    MessageBox.Show("Tüm Alanlarý Doldorunuz...!!!");
                }
        }
            catch (Exception)
            {
                MessageBox.Show("TC bilginiz kayýtlý ise kayýt olamazsýnýz");
            }
    groupBox1.Visible = false;
        }
    }
}