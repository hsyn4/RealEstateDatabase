using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
   public  class şehirpresenter
    {

       şehir valşehir = new şehir();
        emlakEntities emlakent7 = new emlakEntities();

        public void şehirInsert(string a)
        {



            valşehir.şehir_ismi = a;

       
            emlakent7.şehir.Add(valşehir);
            emlakent7.SaveChanges();


        }

        public void şehirUpdate(int dkk, string a)
        {
            var şehir1 = emlakent7.şehir.FirstOrDefault(x => x.şehir_id == dkk);
            şehir1.şehir_ismi = a;
            

            emlakent7.SaveChanges();
        }

        public void şehirDelete(int dk)
        {

            var şehir2 = emlakent7.şehir.First(x => x.şehir_id == dk);

            emlakent7.şehir.Remove(şehir2);
            emlakent7.SaveChanges();
        }
    }
}
