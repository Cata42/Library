//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int Id { get; set; }
        public int Book { get; set; }
        public int Reader { get; set; }
        public System.DateTime RentDate { get; set; }
        public System.DateTime ExpectedReturnDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    
        public virtual Book Book1 { get; set; }
        public virtual Reader Reader1 { get; set; }
    }
}