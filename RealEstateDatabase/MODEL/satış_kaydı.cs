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
    
    public partial class satış_kaydı
    {
        public int kayıt_id { get; set; }
        public int ev_sahibi_id { get; set; }
        public int temsilci_id { get; set; }
        public int satılık_ev_id { get; set; }
        public int yeni_ev_sahibi_id { get; set; }
        public int satış_fiyatı { get; set; }
    
        public virtual ev_sahibi ev_sahibi { get; set; }
        public virtual satılık_ev satılık_ev { get; set; }
        public virtual temsilci temsilci { get; set; }
        public virtual yeni_ev_sahibi yeni_ev_sahibi { get; set; }
    }
}
