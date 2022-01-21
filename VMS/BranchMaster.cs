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
    
    public partial class BranchMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BranchMaster()
        {
            this.DepartmentMasters = new HashSet<DepartmentMaster>();
            this.UserMasters = new HashSet<UserMaster>();
        }
    
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Contact { get; set; }
        public bool StatusId { get; set; }
        public string ImageUrl { get; set; }
        public string EditedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public System.Guid CompanyID { get; set; }
    
        public virtual CompanyMaster CompanyMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentMaster> DepartmentMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMaster> UserMasters { get; set; }
    }
}