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
    
    public partial class Cat_Topic
    {
        public Cat_Topic()
        {
            this.Cat_SkillTopic = new HashSet<Cat_SkillTopic>();
            this.Tra_Certificate1 = new HashSet<Tra_Certificate>();
            this.Tra_CourseTopic = new HashSet<Tra_CourseTopic>();
            this.Tra_RequirementTrain = new HashSet<Tra_RequirementTrain>();
            this.Tra_RequirementTrainDetail = new HashSet<Tra_RequirementTrainDetail>();
            this.Tra_ScoreTopic = new HashSet<Tra_ScoreTopic>();
            this.Tra_TraineeCertificate = new HashSet<Tra_TraineeCertificate>();
            this.Tra_TraineeTopic = new HashSet<Tra_TraineeTopic>();
        }
    
        public System.Guid ID { get; set; }
        public string TopicName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public Nullable<System.Guid> CorseID { get; set; }
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
        public Nullable<System.Guid> CertificateID { get; set; }
        public Nullable<double> LeadTime { get; set; }
        public string DocumentCode { get; set; }
        public string TrainingSample { get; set; }
        public string TrainingCode { get; set; }
        public Nullable<double> StandardTheory { get; set; }
        public Nullable<double> StandardPractice { get; set; }
        public Nullable<double> StandardAttendance { get; set; }
        public string CodeConstraint { get; set; }
        public string Formula { get; set; }
        public Nullable<System.Guid> RankingID { get; set; }
        public Nullable<System.Guid> RankingGroupID { get; set; }
        public string TypeHandleFomular { get; set; }
        public Nullable<bool> IsComplex { get; set; }
        public Nullable<double> MinimumScore { get; set; }
        public Nullable<double> MaximumScore { get; set; }
    
        public virtual ICollection<Cat_SkillTopic> Cat_SkillTopic { get; set; }
        public virtual Tra_Certificate Tra_Certificate { get; set; }
        public virtual Tra_Course Tra_Course { get; set; }
        public virtual Tra_RankingGroup Tra_RankingGroup { get; set; }
        public virtual ICollection<Tra_Certificate> Tra_Certificate1 { get; set; }
        public virtual ICollection<Tra_CourseTopic> Tra_CourseTopic { get; set; }
        public virtual ICollection<Tra_RequirementTrain> Tra_RequirementTrain { get; set; }
        public virtual ICollection<Tra_RequirementTrainDetail> Tra_RequirementTrainDetail { get; set; }
        public virtual ICollection<Tra_ScoreTopic> Tra_ScoreTopic { get; set; }
        public virtual ICollection<Tra_TraineeCertificate> Tra_TraineeCertificate { get; set; }
        public virtual ICollection<Tra_TraineeTopic> Tra_TraineeTopic { get; set; }
    }
}