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
    
    public partial class mahalle
    {
        public mahalle()
        {
            this.kiralık_ev = new HashSet<kiralık_ev>();
            this.satılık_ev = new HashSet<satılık_ev>();
        }
    
        public int mahalle_id { get; set; }
        public string mahalle_ad { get; set; }
        public int şehir_id { get; set; }
    
        public virtual ICollection<kiralık_ev> kiralık_ev { get; set; }
        public virtual şehir şehir { get; set; }
        public virtual ICollection<satılık_ev> satılık_ev { get; set; }
    }
}