using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
   public  class mahallepresenter
    {
        mahalle valmahalle = new mahalle();
        emlakEntities emlakent5 = new emlakEntities();

        public void mahalleInsert(string a, string b)
        {



            valmahalle.mahalle_ad = a;
            
            valmahalle.şehir_id = int.Parse(b);
            emlakent5.mahalle.Add(valmahalle);
            emlakent5.SaveChanges();


        }

        public void mahalleUpdate(int dkk, string a, string b)
        {
            var mah1 = emlakent5.mahalle.FirstOrDefault(x => x.mahalle_id == dkk);
            mah1.mahalle_ad = a;
            mah1.şehir_id = int.Parse(b);
      
            emlakent5.SaveChanges();
        }

        public void mahalleDelete(int dk)
        {

            var mhll = emlakent5.mahalle.First(x => x.mahalle_id == dk);

            emlakent5.mahalle.Remove(mhll);
            emlakent5.SaveChanges();
        }


    }
}
