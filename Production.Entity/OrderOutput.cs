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
    
    public partial class OrderOutput
    {
        public int OrderActivityInput { get; set; }
        public int OrderActivityId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> SizeId { get; set; }
        public double Quantity { get; set; }
        public int UoMId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    
        public virtual OrderActivity OrderActivity { get; set; }
        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}