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
    
    public partial class Sys_LockObject
    {
        public Sys_LockObject()
        {
            this.Sys_LockObjectItem = new HashSet<Sys_LockObjectItem>();
        }
    
        public System.Guid ID { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public string Type { get; set; }
        public Nullable<System.Guid> UserApprove1ID { get; set; }
        public Nullable<System.Guid> UserApprove2ID { get; set; }
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
        public string Status { get; set; }
        public byte[] OrgStructures { get; set; }
        public byte[] PayrollGroups { get; set; }
        public string Commend { get; set; }
        public Nullable<System.Guid> WorkPlaceID { get; set; }
    
        public virtual Cat_WorkPlace Cat_WorkPlace { get; set; }
        public virtual Sys_UserInfo Sys_UserInfo { get; set; }
        public virtual Sys_UserInfo Sys_UserInfo1 { get; set; }
        public virtual ICollection<Sys_LockObjectItem> Sys_LockObjectItem { get; set; }
    }
}