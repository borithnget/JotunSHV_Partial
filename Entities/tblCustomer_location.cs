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
    
    public partial class tblCustomer_location
    {
        public int id { get; set; }
        public string customer_id { get; set; }
        public string location { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
