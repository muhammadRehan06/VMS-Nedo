//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class VisitorMaster
    {
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public System.Guid CityID { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Notes { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ValidUntill { get; set; }
        public System.Guid VisitorStatusID { get; set; }
        public System.Guid VisitorTypeID { get; set; }
        public string Reason { get; set; }
        public string ImageURL { get; set; }
    }
}
