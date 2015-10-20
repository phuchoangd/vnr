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
    
    public partial class Hre_ProfileCertificate
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ProfileID { get; set; }
        public Nullable<System.Guid> TraineeID { get; set; }
        public Nullable<System.Guid> TraineeCertificateID { get; set; }
        public string Status { get; set; }
        public string TraineePlace { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public Nullable<double> TraineeFee { get; set; }
        public Nullable<System.Guid> CurrencyID { get; set; }
        public Nullable<System.Guid> CertificateID { get; set; }
        public string CertificateName { get; set; }
        public Nullable<System.DateTime> DateCertificate { get; set; }
        public Nullable<System.DateTime> DateExpirCertificate { get; set; }
        public string RankingName { get; set; }
        public Nullable<bool> IsTrainningOut { get; set; }
        public Nullable<System.Guid> CourseID { get; set; }
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
        public string Note { get; set; }
    
        public virtual Cat_Currency Cat_Currency { get; set; }
        public virtual Hre_Profile Hre_Profile { get; set; }
        public virtual Tra_Certificate Tra_Certificate { get; set; }
        public virtual Tra_Course Tra_Course { get; set; }
        public virtual Tra_TraineeCertificate Tra_TraineeCertificate { get; set; }
        public virtual Tra_Trainee Tra_Trainee { get; set; }
    }
}