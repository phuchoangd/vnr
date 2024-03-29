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
    
    public partial class Sal_UnusualPay
    {
        public Sal_UnusualPay()
        {
            this.Sal_UnusualPayItem = new HashSet<Sal_UnusualPayItem>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid ProfileID { get; set; }
        public Nullable<System.DateTime> MonthYear { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Type { get; set; }
        public string TypeOfIssuance { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<System.DateTime> DateOfPayment { get; set; }
        public string ReceiptCode { get; set; }
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
        public double Amount { get; set; }
        public double AmountPaidPITCom { get; set; }
        public double AmountPaidPITEmp { get; set; }
        public Nullable<double> Budget { get; set; }
        public Nullable<System.Guid> UserApproveID { get; set; }
        public Nullable<System.Guid> UserApproveID1 { get; set; }
        public string Description { get; set; }
        public string AttachFile { get; set; }
        public Nullable<System.Guid> CurrentcyID { get; set; }
        public Nullable<bool> IsSubSalary { get; set; }
    
        public virtual Cat_Currency Cat_Currency { get; set; }
        public virtual Hre_Profile Hre_Profile { get; set; }
        public virtual ICollection<Sal_UnusualPayItem> Sal_UnusualPayItem { get; set; }
        public virtual Sys_UserInfo Sys_UserInfo { get; set; }
        public virtual Sys_UserInfo Sys_UserInfo1 { get; set; }
    }
}
