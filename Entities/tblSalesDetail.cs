//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jotun.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSalesDetail
    {
        public string Id { get; set; }
        public string SaleId { get; set; }
        public string ProductId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string UnitTypeId { get; set; }
        public string color_code { get; set; }
        public Nullable<decimal> actual_price { get; set; }
        public Nullable<decimal> cost { get; set; }
    
        public virtual tblSale tblSale { get; set; }
    }
}
