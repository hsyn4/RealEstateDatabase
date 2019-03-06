using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
   public  class satılıkevpresenter
    {
        satılık_ev SatılıkEv = new satılık_ev();
        emlakEntities emlakent4 = new emlakEntities();

        public void satılıkevInsert(string a, string b, string c, string d, string e, string f, string g, string h,string i,string j,string k)
        {



            SatılıkEv.ada_parsel =c ;
            SatılıkEv.bulunduğu_kat = int.Parse(e);
            SatılıkEv.fiyat = int.Parse(h);
            SatılıkEv.sokak = a;
            SatılıkEv.kat_sayısı = int.Parse(d);
            SatılıkEv.oda_sayısı = int.Parse(f);
           SatılıkEv.salon_sayısı = int.Parse(g);
            SatılıkEv.kapı_no = int.Parse(b);
            SatılıkEv.mahalle_id = int.Parse(i);
            SatılıkEv.temsilci_id = int.Parse(j);
            SatılıkEv.ev_sahibi_id=int.Parse(k);

            emlakent4.satılık_ev.Add(SatılıkEv);
            emlakent4.SaveChanges();


        }

        public void satılıkevUpdate(int dkk, string a, string b, string c, string d, string e, string f, string g, string h,string i ,string j,string k)
        {
            var SatılıkEv = emlakent4.satılık_ev.FirstOrDefault(x => x.satılık_ev_id == dkk);
            SatılıkEv.ada_parsel = c;
            SatılıkEv.bulunduğu_kat = int.Parse(e);
            SatılıkEv.fiyat = int.Parse(h);
            SatılıkEv.sokak = a;
            SatılıkEv.kat_sayısı = int.Parse(d);
            SatılıkEv.oda_sayısı = int.Parse(f);
            SatılıkEv.salon_sayısı = int.Parse(g);
            SatılıkEv.kapı_no = int.Parse(b);
            SatılıkEv.mahalle_id = int.Parse(i);
            SatılıkEv.temsilci_id = int.Parse(j);
            SatılıkEv.ev_sahibi_id = int.Parse(k);
            emlakent4.SaveChanges();
        }

        public void satılıkevDelete(int dk)
        {

            var satılıkEv = emlakent4.satılık_ev.First(x => x.satılık_ev_id == dk);

            emlakent4.satılık_ev.Remove(satılıkEv);
            emlakent4.SaveChanges();
        }


    }
}
