//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Production.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            this.OrderActivities = new HashSet<OrderActivity>();
        }
    
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerDescription { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual ICollection<OrderActivity> OrderActivities { get; set; }
    }
}
