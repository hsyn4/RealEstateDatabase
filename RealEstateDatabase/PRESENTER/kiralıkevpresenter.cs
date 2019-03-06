using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
 public    class kiralıkevpresenter
    {
     kiralık_ev KiralıkEv = new kiralık_ev();
        emlakEntities emlakent3 = new emlakEntities();

        public void kiralıkevInsert(string a, string b, string c,string d,string e,string f , string g,string h)
        {



            KiralıkEv.ada_parsel = a;
            KiralıkEv.bulunduğu_kat=int.Parse( b);
            KiralıkEv.fiyat =int.Parse( c);
            KiralıkEv.sokak=d;
            KiralıkEv.kat_sayısı= int.Parse(e);
            KiralıkEv.oda_sayısı = int.Parse(f);
            KiralıkEv.salon_sayısı = int.Parse(g);
            KiralıkEv.kapı_no = int.Parse(h);

            emlakent3.kiralık_ev.Add(KiralıkEv);
            emlakent3.SaveChanges();


        }

        public void kiralıkevUpdate(int dkk, string a, string b, string c,string d,string e,string f,string g,string h)
        {
            var krlkev = emlakent3.kiralık_ev.FirstOrDefault(x => x.kiralık_ev_id == dkk);
            KiralıkEv.ada_parsel = a;
            KiralıkEv.bulunduğu_kat =int.Parse( b);
            KiralıkEv.fiyat = int.Parse(c);
            KiralıkEv.sokak = d;
            KiralıkEv.kat_sayısı = int.Parse(e);
            KiralıkEv.oda_sayısı = int.Parse(f);
            KiralıkEv.salon_sayısı = int.Parse(g);
            KiralıkEv.kapı_no = int.Parse(h);
            emlakent3.SaveChanges();
        }

        public void kiralıkevDelete(int dk)
        {

            var kiralıkEv = emlakent3.kiralık_ev.First(x => x.kiralık_ev_id == dk);

            emlakent3.kiralık_ev.Remove(kiralıkEv);
            emlakent3.SaveChanges();
        }



    }
}
