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
    public partial class siparisDetaylari : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MusteriTakip;Integrated Security=True");
        DataSet ds = new DataSet();

        public siparisDetaylari()
        {
            InitializeComponent();
        }

        private void siparisDetaylari_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            urun URUN1=new urun();
            baglanti.Open();
            //SqlDataAdapter adtr = new SqlDataAdapter("select * from siparisDetay where siparisID="+URUN1.siparisIDgetir(), baglanti);
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT mstrAdi AS ADI,mstrSoyadi AS SOYADI,mstrTelefon AS TELEFON" +
                ",mstrAdres AS ADRES,miktar AS ADET,siparisTarihi AS TARİH,urunAd AS URUN,satisFiyati AS FİYATI,miktar*satisFiyati AS [TOPLAM TUTAR]" +
"FROM siparis "+
"INNER JOIN musteri ON musteri.mstrID = siparis.musteriID "+
"INNER JOIN siparisDetay ON siparisDetay.siparisID = siparis.siparisID " +
"INNER JOIN urun ON urun.urunID = siparisDetay.urunID WHERE siparis.siparisID=" + URUN1.siparisIDgetir(), baglanti);
            adtr.Fill(ds, "siparis");
            dataGridView1.DataSource = ds.Tables["siparis"];
            baglanti.Close();
        }

        private void btnGeridon_Click(object sender, EventArgs e)
        {
            this.Close();
            //siparisIslemleri geri=new siparisIslemleri();
            //geri.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOdemeyap_Click(object sender, EventArgs e)
        {
            odemeYap oy = new odemeYap();
            oy.Show();
        }

        private void siparisDetaylari_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
