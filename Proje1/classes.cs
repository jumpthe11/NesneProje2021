using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public abstract class musteriBilgisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private static string TC = "";
        private static int siparisID = 0;
        public musteriBilgisi()
        {

        }
        public musteriBilgisi(string _TC, int _siparisID)
        {
            TC = _TC;
            siparisID = _siparisID;
        }
        public musteriBilgisi(string Ad,string Soyad)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            //this.TC = TC;   
        }
        public string getirTC()
        {
            return TC;  
        }
        public int siparisIDgetir()
        {
            return siparisID;
        }

    }
    public class urun:musteriBilgisi
    {
        private string urunad=" ";

        public string urunAd
        {
            get { return urunad; }
            set { urunad = value; }
        }
        
        public string urunID { get; set; }
        public int satisFiyati { get; set; }
        public int stokMiktari { get; set; }
        public bool varmi { get; set; }
        public int urunAdet { get; set; }
        public urun(string urunID, string urunAd, int satisFiyati, int stokMiktari, bool varmi, int urunAdet)
        {
            this.urunID= urunID;
            this.urunAd= urunAd;
            this.satisFiyati= satisFiyati;  
            this.stokMiktari= stokMiktari;  
            this.varmi= varmi;
            this.urunAdet= urunAdet;    
        }
        public urun(string _TC,int _siparisID) : base(_TC, _siparisID)
        {

        }
        public urun(string Ad,string Soyad,string TC):base(Ad,Soyad)
        {

        }
        public urun()
        {


        }
        public override string ToString()
        {
            return this.urunad+" "+this.urunAdet+" "+this.satisFiyati+":"+ this.urunAdet*this.satisFiyati;
        }
    }

    public class sepet
    {

        public static List<urun> urunlerlistesi = new List<urun>();
        public sepet(string urunID, string urunAd, int satisFiyati, int stokMiktari, bool varmi, int urunAdet)
        {
            urunlerlistesi.Add(new urun(urunID, urunAd, satisFiyati, stokMiktari, varmi, urunAdet));
        }
        public sepet()
        {
                
        }
    }
}
