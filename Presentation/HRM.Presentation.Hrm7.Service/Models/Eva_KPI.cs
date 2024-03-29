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
    
    public partial class Eva_KPI
    {
        public Eva_KPI()
        {
            this.Eva_PerformanceDetail = new HashSet<Eva_PerformanceDetail>();
            this.Eva_PerformanceResults = new HashSet<Eva_PerformanceResults>();
        }
    
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> NameEntityID { get; set; }
        public double MinimumRating { get; set; }
        public double MaximumRating { get; set; }
        public double Rate { get; set; }
        public string Comment { get; set; }
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
        public string KPIName { get; set; }
    
        public virtual Cat_NameEntity Cat_NameEntity { get; set; }
        public virtual ICollection<Eva_PerformanceDetail> Eva_PerformanceDetail { get; set; }
        public virtual ICollection<Eva_PerformanceResults> Eva_PerformanceResults { get; set; }
    }
}
