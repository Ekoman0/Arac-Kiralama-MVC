//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb1_Rezervasyonlar
    {
        public int RezervasyonId { get; set; }
        public Nullable<int> AracId { get; set; }
        public string TcKimlik { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<System.DateTime> AlmaTarihi { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
        public Nullable<decimal> Ucret { get; set; }
    }
}
