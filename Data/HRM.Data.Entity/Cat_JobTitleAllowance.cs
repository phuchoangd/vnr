//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.Data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cat_JobTitleAllowance
    {
        public System.Guid ID { get; set; }
        public System.Guid JobTitleID { get; set; }
        public System.Guid AllowanceID { get; set; }
        public Nullable<double> MinPersonalAmount { get; set; }
        public Nullable<double> MaxPersonalAmount { get; set; }
        public Nullable<System.Guid> OrgStructureID { get; set; }
        public Nullable<double> MinDeptAmount { get; set; }
        public Nullable<double> MaxDeptAmount { get; set; }
        public string Description { get; set; }
        public string ServerUpdate { get; set; }
        public string ServerCreate { get; set; }
        public string UserUpdate { get; set; }
        public string UserCreate { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public Nullable<System.Guid> UserLockID { get; set; }
        public Nullable<System.DateTime> DateLock { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string IPCreate { get; set; }
        public string IPUpdate { get; set; }
    
        public virtual Cat_JobTitle Cat_JobTitle { get; set; }
        public virtual Cat_OrgStructure Cat_OrgStructure { get; set; }
        public virtual Cat_UsualAllowance Cat_UsualAllowance { get; set; }
    }
}
