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
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM kullaniciGiris WHERE kullaniciAdi='" + txtKullaniciAdi.Text + "'" + "AND" + " sifre='" + txtSifre.Text + "'", baglanti);
            int b = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.ExecuteNonQuery();
            baglanti.Close();
            if (b>0)
            {
                AnaSayfa formGiris = new AnaSayfa();
                formGiris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý yada þifre hatalýdýr.Tekrar deneyiniz.");
            }
            

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}