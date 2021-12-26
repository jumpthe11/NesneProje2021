using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public abstract class odeme
    {
        protected decimal indirimOrani { get; set; }
        protected decimal kdvorani { get; set; }
        public decimal toplamFiyat { get; set; }
        public decimal indirimliFiyat { get;set; }
        public decimal kdvliFiyat { get; set; }
        public void indirimHesapla(decimal indirimOr)
        {
            this.indirimOrani = indirimOr;
            this.indirimliFiyat = this.toplamFiyat * this.indirimOrani;
        }
        public void kdvHesapla(decimal kdvOran)
        {
            this.kdvorani = kdvOran;
            this.kdvliFiyat = this.toplamFiyat * kdvorani;
        }
        public odeme()
        {

        }
        public odeme(decimal toplamFiyat)
        {
            this.toplamFiyat = toplamFiyat;
            this.indirimliFiyat=indirimliFiyat;
        }
    }
    public class nakitOdeme:odeme
    {      
        public nakitOdeme()
        {

        }
        public nakitOdeme(decimal toplamFiyat) : base(toplamFiyat)
        {

        }
    }
    public class kredikartOdeme :odeme
    {
        public string KredikartNo { get; set; }
        public string AdSoyad { get; set; }
        public int SonKulAy { get; set; }
        public int SonKulYil { get; set; }
        public int CVV { get; set; }
        public void bilgiEkle(string KredikartNo, string AdSoyad, int SonKulAy, int SonKulYil, int CVV)
        {
            this.KredikartNo= KredikartNo;
            this.AdSoyad = AdSoyad;
            this.SonKulAy = SonKulAy;
            this.SonKulYil = SonKulYil;
            this.CVV = CVV;
        }
        public kredikartOdeme()
        {

        }
        public kredikartOdeme(decimal toplamFiyat) : base(toplamFiyat)
        {

        }
    }
    class havaleEftODeme:odeme
    {
        public string Iban { get; }
        public int havEftKodu { get; set; }        
        public havaleEftODeme(decimal toplamFiyat) : base(toplamFiyat)
        {

        }
        public havaleEftODeme()
        {
            this.Iban = "TR330006100519786457841326";
        }
    }
}
