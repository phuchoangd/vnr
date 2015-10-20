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
    
    public partial class Tra_TraineeTopic
    {
        public Tra_TraineeTopic()
        {
            this.Tra_TraineeScore = new HashSet<Tra_TraineeScore>();
        }
    
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> TraineeID { get; set; }
        public Nullable<System.Guid> TopicID { get; set; }
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
        public Nullable<double> Score { get; set; }
    
        public virtual Cat_Topic Cat_Topic { get; set; }
        public virtual Tra_Trainee Tra_Trainee { get; set; }
        public virtual ICollection<Tra_TraineeScore> Tra_TraineeScore { get; set; }
    }
}