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
    
    public partial class Cat_NameEntity
    {
        public Cat_NameEntity()
        {
            this.Eva_KPI = new HashSet<Eva_KPI>();
            this.Hre_Contract = new HashSet<Hre_Contract>();
            this.Hre_Profile = new HashSet<Hre_Profile>();
            this.Hre_ProfileComputingLevel = new HashSet<Hre_ProfileComputingLevel>();
            this.Hre_ProfileComputingLevel1 = new HashSet<Hre_ProfileComputingLevel>();
            this.Hre_ProfileLanguageLevel = new HashSet<Hre_ProfileLanguageLevel>();
            this.Hre_ProfileLanguageLevel1 = new HashSet<Hre_ProfileLanguageLevel>();
            this.Hre_ProfileLanguageLevel2 = new HashSet<Hre_ProfileLanguageLevel>();
            this.Hre_ProfileQualification = new HashSet<Hre_ProfileQualification>();
            this.Rec_Candidate = new HashSet<Rec_Candidate>();
            this.Rec_Candidate1 = new HashSet<Rec_Candidate>();
            this.Rec_CandidateComputingLevel = new HashSet<Rec_CandidateComputingLevel>();
            this.Rec_CandidateComputingLevel1 = new HashSet<Rec_CandidateComputingLevel>();
            this.Rec_CandidateLanguageLevel = new HashSet<Rec_CandidateLanguageLevel>();
            this.Rec_CandidateLanguageLevel1 = new HashSet<Rec_CandidateLanguageLevel>();
            this.Rec_CandidateLanguageLevel2 = new HashSet<Rec_CandidateLanguageLevel>();
            this.Rec_CandidateQualification = new HashSet<Rec_CandidateQualification>();
            this.Rec_CandidateQualification1 = new HashSet<Rec_CandidateQualification>();
            this.Rec_JobVacancy = new HashSet<Rec_JobVacancy>();
            this.Rec_Relative = new HashSet<Rec_Relative>();
        }
    
        public System.Guid ID { get; set; }
        public string Code { get; set; }
        public string NameEntityName { get; set; }
        public string NameEntityType { get; set; }
        public string EnumType { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
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
        public Nullable<int> Order { get; set; }
    
        public virtual ICollection<Eva_KPI> Eva_KPI { get; set; }
        public virtual ICollection<Hre_Contract> Hre_Contract { get; set; }
        public virtual ICollection<Hre_Profile> Hre_Profile { get; set; }
        public virtual ICollection<Hre_ProfileComputingLevel> Hre_ProfileComputingLevel { get; set; }
        public virtual ICollection<Hre_ProfileComputingLevel> Hre_ProfileComputingLevel1 { get; set; }
        public virtual ICollection<Hre_ProfileLanguageLevel> Hre_ProfileLanguageLevel { get; set; }
        public virtual ICollection<Hre_ProfileLanguageLevel> Hre_ProfileLanguageLevel1 { get; set; }
        public virtual ICollection<Hre_ProfileLanguageLevel> Hre_ProfileLanguageLevel2 { get; set; }
        public virtual ICollection<Hre_ProfileQualification> Hre_ProfileQualification { get; set; }
        public virtual ICollection<Rec_Candidate> Rec_Candidate { get; set; }
        public virtual ICollection<Rec_Candidate> Rec_Candidate1 { get; set; }
        public virtual ICollection<Rec_CandidateComputingLevel> Rec_CandidateComputingLevel { get; set; }
        public virtual ICollection<Rec_CandidateComputingLevel> Rec_CandidateComputingLevel1 { get; set; }
        public virtual ICollection<Rec_CandidateLanguageLevel> Rec_CandidateLanguageLevel { get; set; }
        public virtual ICollection<Rec_CandidateLanguageLevel> Rec_CandidateLanguageLevel1 { get; set; }
        public virtual ICollection<Rec_CandidateLanguageLevel> Rec_CandidateLanguageLevel2 { get; set; }
        public virtual ICollection<Rec_CandidateQualification> Rec_CandidateQualification { get; set; }
        public virtual ICollection<Rec_CandidateQualification> Rec_CandidateQualification1 { get; set; }
        public virtual ICollection<Rec_JobVacancy> Rec_JobVacancy { get; set; }
        public virtual ICollection<Rec_Relative> Rec_Relative { get; set; }
    }
}