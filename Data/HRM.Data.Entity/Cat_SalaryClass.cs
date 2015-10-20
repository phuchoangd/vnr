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
    
    public partial class Cat_SalaryClass
    {
        public Cat_SalaryClass()
        {
            this.Cat_SalaryRank = new HashSet<Cat_SalaryRank>();
            this.Eva_Performance = new HashSet<Eva_Performance>();
            this.Hre_AppendixContract = new HashSet<Hre_AppendixContract>();
            this.Hre_AppendixContract1 = new HashSet<Hre_AppendixContract>();
            this.Hre_Contract = new HashSet<Hre_Contract>();
            this.Hre_WorkHistory = new HashSet<Hre_WorkHistory>();
            this.Hre_Profile = new HashSet<Hre_Profile>();
            this.Rec_Candidate = new HashSet<Rec_Candidate>();
            this.Sal_BasicSalary = new HashSet<Sal_BasicSalary>();
            this.Tra_Course = new HashSet<Tra_Course>();
            this.Hre_CandidateGeneral = new HashSet<Hre_CandidateGeneral>();
        }
    
        public System.Guid ID { get; set; }
        public string SalaryClassName { get; set; }
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
        public string Code { get; set; }
        public Nullable<System.Guid> SalaryClassTypeID { get; set; }
        public string AbilityTitleVNI { get; set; }
        public string AbilityTitleENG { get; set; }
        public string AbilityTitle_VNI { get; set; }
        public string AbilityTitle_ENG { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public Nullable<System.Guid> AbilityTitleID { get; set; }
    
        public virtual Cat_AbilityTile Cat_AbilityTile { get; set; }
        public virtual Cat_SalaryClassType Cat_SalaryClassType { get; set; }
        public virtual ICollection<Cat_SalaryRank> Cat_SalaryRank { get; set; }
        public virtual ICollection<Eva_Performance> Eva_Performance { get; set; }
        public virtual ICollection<Hre_AppendixContract> Hre_AppendixContract { get; set; }
        public virtual ICollection<Hre_AppendixContract> Hre_AppendixContract1 { get; set; }
        public virtual ICollection<Hre_Contract> Hre_Contract { get; set; }
        public virtual ICollection<Hre_WorkHistory> Hre_WorkHistory { get; set; }
        public virtual ICollection<Hre_Profile> Hre_Profile { get; set; }
        public virtual ICollection<Rec_Candidate> Rec_Candidate { get; set; }
        public virtual ICollection<Sal_BasicSalary> Sal_BasicSalary { get; set; }
        public virtual ICollection<Tra_Course> Tra_Course { get; set; }
        public virtual ICollection<Hre_CandidateGeneral> Hre_CandidateGeneral { get; set; }
    }
}