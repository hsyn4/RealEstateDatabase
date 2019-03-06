using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
   public  class satışkayıtpresenter
    {
       satış_kaydı sk = new satış_kaydı();
        emlakEntities entemlak = new emlakEntities();

        public void satışkayıtInsert(string a, string b, string c, string d, string e)
        {

            sk.ev_sahibi_id = int.Parse(a);
            sk.satılık_ev_id = int.Parse(b);
            sk.temsilci_id = int.Parse(c);
            sk.ev_sahibi_id = int.Parse(d);

            sk.satış_fiyatı = int.Parse(e);
            entemlak.satış_kaydı.Add(sk);
            entemlak.SaveChanges();

        }

        public void satışkayıtUpdate(int dkk, string a, string b, string c, string d, string e)
        {
            var kkayıt = entemlak.kira_kayıt.FirstOrDefault(x => x.kira_kayıt_id == dkk);
            sk.ev_sahibi_id = int.Parse(a);
            sk.satılık_ev_id = int.Parse(b);
            sk.temsilci_id = int.Parse(c);
            sk.ev_sahibi_id = int.Parse(d);
            sk.satış_fiyatı = int.Parse(e);

            entemlak.SaveChanges();

        }


        public void satışkayıtDelete(int dkk)
        {

            var kkyt = entemlak.satış_kaydı.First(x => x.kayıt_id == dkk);

            entemlak.satış_kaydı.Remove(kkyt);
            entemlak.SaveChanges();


        }
 

    }
}
