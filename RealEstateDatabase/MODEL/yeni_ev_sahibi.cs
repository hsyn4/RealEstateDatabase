//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateDatabase.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class yeni_ev_sahibi
    {
        public yeni_ev_sahibi()
        {
            this.satış_kaydı = new HashSet<satış_kaydı>();
        }
    
        public int yeni_ev_sahibi_id { get; set; }
        public string adı { get; set; }
        public string soyadı { get; set; }
        public string telno { get; set; }
    
        public virtual ICollection<satış_kaydı> satış_kaydı { get; set; }
    }
}
