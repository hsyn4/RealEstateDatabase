using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateDatabase.VİEW;
using RealEstateDatabase.MODEL;

namespace RealEstateDatabase.PRESENTER
{
  public   class evsahibipresenter
    {
        ev_sahibi EvSahibi = new ev_sahibi();
        emlakEntities emlakent = new emlakEntities();

   public  void evsahibiInsert(string a,string b,string c){

       

       EvSahibi.ad = a;
       EvSahibi.soyad = b;
       EvSahibi.telefon = c;
       emlakent.ev_sahibi.Add(EvSahibi);
       emlakent.SaveChanges();
       

      }

   public void evsahibiUpdate(int dk,string a,string b,string c)
   {
       var evs = emlakent.ev_sahibi.FirstOrDefault(x => x.ev_sahibi_id == dk);
       evs.ad = a;
       evs.soyad = b;
       evs.telefon = c;
       
       emlakent.SaveChanges();
   }

   public void evsahibiDelete(int dk)
   {

       var evss = emlakent.ev_sahibi.FirstOrDefault(x=>x.ev_sahibi_id==dk);
     
       emlakent.ev_sahibi.Remove(evss);
       emlakent.SaveChanges();
   }


   


    }
}
