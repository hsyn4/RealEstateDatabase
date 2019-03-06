using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
  public   class kirakayıtpresenter
    {

      kira_kayıt kk = new kira_kayıt();
      emlakEntities entemlak = new emlakEntities();

      public void kirakayıtInsert(string a,string b,string c,string d,string e)
      {

          kk.ev_sahibi_id = int.Parse(a);
          kk.kiralık_ev_id = int.Parse(b);
          kk.temsilci_id = int.Parse(c);
          kk.kiracı_id = int.Parse(d);
          
          kk.kiralama_fiyatı = int.Parse(e);
          entemlak.kira_kayıt.Add(kk);
          entemlak.SaveChanges();

      }

      public void kirakayıtUpdate(int dkk,string a, string b, string c, string d, string e)
      {
          var kkayıt = entemlak.kira_kayıt.FirstOrDefault(x => x.kira_kayıt_id == dkk);
          kk.ev_sahibi_id = int.Parse(a);
          kk.kiralık_ev_id = int.Parse(b);
          kk.temsilci_id = int.Parse(c);
          kk.kiracı_id = int.Parse(d);
          kk.kiralama_fiyatı = int.Parse(e);
          
          entemlak.SaveChanges();

      }


      public void kirakayıtDelete(int dkk)
      {

          var kkyt = entemlak.kira_kayıt.First(x => x.kira_kayıt_id == dkk);

          entemlak.kira_kayıt.Remove(kkyt);
          entemlak.SaveChanges();


      }
 
    }
}
