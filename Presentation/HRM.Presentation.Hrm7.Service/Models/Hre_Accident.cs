//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRM.Presentation.Hrm7.Service.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hre_Accident
    {
        public System.Guid ID { get; set; }
        public System.Guid ProfileID { get; set; }
        public System.DateTime Date { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
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
        public Nullable<System.Guid> AccidentTypeID { get; set; }
        public Nullable<double> FirstMoney { get; set; }
        public Nullable<double> RealMoney { get; set; }
        public Nullable<double> CompanyPay { get; set; }
        public Nullable<double> InsPay { get; set; }
    
        public virtual Cat_AccidentType Cat_AccidentType { get; set; }
        public virtual Hre_Profile Hre_Profile { get; set; }
    }
}