using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
 public   class kiracıpresenter
    {
     kiracı Kiracılar = new kiracı();
     emlakEntities emlakent1 = new emlakEntities();
        public void kiracıInsert(string a, string b, string c)
        {



            Kiracılar.ad = a;
            Kiracılar.soyad = b;
            Kiracılar.telno = c;
            emlakent1.kiracı.Add(Kiracılar);
            emlakent1.SaveChanges();


        }

        public void kiracıUpdate(int dkk, string a, string b, string c)
        {
            var Kiracılar = emlakent1.kiracı.FirstOrDefault(x => x.kiracı_id == dkk);
            Kiracılar.ad = a;
           Kiracılar.soyad = b;
            Kiracılar.telno = c;
            emlakent1.SaveChanges();
        }

        public void kiracıDelete(int dk)
        {
            
                var Kiracılar = emlakent1.kiracı.First(x => x.kiracı_id == dk);

                emlakent1.kiracı.Remove(Kiracılar);
                emlakent1.SaveChanges();
            
        }
    }
}
