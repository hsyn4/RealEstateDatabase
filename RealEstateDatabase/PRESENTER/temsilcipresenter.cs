using RealEstateDatabase.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDatabase.PRESENTER
{
   public class temsilcipresenter
    {
       temsilci tmsl = new temsilci();
        emlakEntities emlakent2 = new emlakEntities();

        public void temsilciInsert(string a, string b, string c,string d)
        {
           

            tmsl.ad = a;
            tmsl.soyad = b;
            tmsl.tel_no = c;
            tmsl.dükkan_id =int.Parse( d);
            emlakent2.temsilci.Add(tmsl);
            emlakent2.SaveChanges();


        }

        public void temsilciUpdate(int dkk, string a, string b, string c,string d)
        {
            //emlakEntities emlakent2 = new emlakEntities();
            //temsilci tmsl = new temsilci();
            var temsilci = emlakent2.temsilci.FirstOrDefault(x => x.temsilci_id == dkk);
            temsilci.ad = a;
            temsilci.soyad = b;
            temsilci.tel_no = c;
            tmsl.dükkan_id = int.Parse(d);
            emlakent2.SaveChanges();
        }

        public void temsilciDelete(int dk)
        {
          //  emlakEntities emlakent2 = new emlakEntities();
            //temsilci tmsl = new temsilci();
            var tems = emlakent2.temsilci.First(x => x.temsilci_id == dk);

            emlakent2.temsilci.Remove(tems);
            emlakent2.SaveChanges();
        }

    }
}
