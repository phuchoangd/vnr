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
    
    public partial class Med_HistoryMedical
    {
        public Med_HistoryMedical()
        {
            this.Med_PatientMedicineDetail = new HashSet<Med_PatientMedicineDetail>();
        }
    
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> ProfileID { get; set; }
        public string UserApprove { get; set; }
        public Nullable<System.DateTime> DateApprove { get; set; }
        public string Status { get; set; }
        public string HistoryMedicalName { get; set; }
        public Nullable<System.DateTime> DateIn { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> DiseaseID { get; set; }
        public Nullable<System.DateTime> DateRestFrom { get; set; }
        public Nullable<System.DateTime> DateRestTo { get; set; }
        public string MedicName { get; set; }
        public string MedicNote { get; set; }
        public string DiseaseType { get; set; }
        public Nullable<bool> IsPregnant { get; set; }
        public string IPCreate { get; set; }
        public string IPUpdate { get; set; }
        public string ServerUpdate { get; set; }
        public string ServerCreate { get; set; }
        public string UserUpdate { get; set; }
        public string UserCreate { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public Nullable<System.Guid> UserLockID { get; set; }
        public Nullable<System.DateTime> DateLock { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string Injury { get; set; }
        public string Cause { get; set; }
        public Nullable<System.Guid> ShiftID { get; set; }
        public Nullable<bool> IsInWorking { get; set; }
        public string InWorkingType { get; set; }
        public Nullable<System.Guid> LineID { get; set; }
        public Nullable<System.DateTime> DateBackToWork { get; set; }
        public string PlaceTreatment { get; set; }
        public Nullable<System.DateTime> DateTreatmentStart { get; set; }
        public Nullable<System.DateTime> DateTreatmentEnd { get; set; }
        public string HospitalDiagnosis { get; set; }
        public string NoteTreatment { get; set; }
        public string AddressPatient { get; set; }
        public string DiseasesInPast { get; set; }
        public Nullable<int> NoOrder { get; set; }
    
        public virtual Cat_Shift Cat_Shift { get; set; }
        public virtual Hre_Profile Hre_Profile { get; set; }
        public virtual Med_Disease Med_Disease { get; set; }
        public virtual ICollection<Med_PatientMedicineDetail> Med_PatientMedicineDetail { get; set; }
    }
}
