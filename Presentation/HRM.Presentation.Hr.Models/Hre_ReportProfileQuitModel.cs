﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using HRM.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using HRM.Presentation.Service;

namespace HRM.Presentation.Hr.Models
{
    public class Hre_ReportProfileQuitModel : BaseViewModel
    {
        [DisplayName(ConstantDisplay.HRM_Att_Report_CodeEmp)]
        public string CodeEmp { get; set; }
        [DisplayName(ConstantDisplay.HRM_Att_Report_ProfileName)]
        public string ProfileName { get; set; }
        [DisplayName(ConstantDisplay.HRM_Canteen_MealRecordMissing_OrgStructureName)]
        public string OrgStructureName { get; set; }
        [DisplayName(ConstantDisplay.HRM_Att_Report_CodeOrg)]
        public string CodeOrg { get; set; }
        [DisplayName(ConstantDisplay.HRM_Att_Report_JobTitleName)]
        public string JobTitleName { get; set; }
        [DisplayName(ConstantDisplay.HRM_Att_Report_PositionName)]
        public string PositionName { get; set; }
        [DisplayName(ConstantDisplay.HRM_HR_Profile_DateHire)]
        public DateTime? DateHire { get; set; }
        [DisplayName(ConstantDisplay.HRM_HR_Contract_DateSigned)]
        public DateTime? DateSign { get; set; }
        [DisplayName(ConstantDisplay.HRM_HR_Profile_RequestDate)]
        public DateTime? RequestDate { get; set; }
        [DisplayName(ConstantDisplay.HRM_Att_AllowLimitOvertime_DateStart)]
        public DateTime? DateStart { get; set; }
        [DisplayName(ConstantDisplay.HRM_Att_AllowLimitOvertime_DateEnd)]
        public DateTime? DateEnd { get; set; }
        [DisplayName(ConstantDisplay.HRM_HR_Profile_DateQuit)]
        public DateTime? DateQuit { get; set; }
        [DisplayName(ConstantDisplay.HRM_HR_Profile_ResignReason)]
        public string ResignReasonName { get; set; }
        [DisplayName(ConstantDisplay.HRM_Attendance_OrgStructureID)]
        public string OrgStructureID { get; set; }
        public bool? IsExport { get; set; }
        public string ValueFields { get; set; }
        public bool IsChecked { get; set; }

        public Guid ExportID { get; set; }
        public bool IsCreateTemplate { get; set; }
        public bool IsCreateTemplateForDynamicGrid { get; set; }

        public string E_UNIT { get; set; }
        public string E_DIVISION { get; set; }
        public string E_DEPARTMENT { get; set; }
        public string E_SECTION { get; set; }
        public string E_TEAM { get; set; }


        public double? E_GrossAmount { get; set; }
        public DateTime? E_MaleBirth { get; set; }
        public DateTime? E_FeMaleBirth { get; set; }
        public int? E_ProfileCount { get; set; }
        public int? E_ProfileIsWorking { get; set; }
        public int? E_FEMALE { get; set; }
        public int? E_MALE { get; set; }
        public int? E_Profile_FEMALE { get; set; }
        public int? E_Profile_MALE { get; set; }
        public int? ProfileQuit { get; set; }


        public string AllowanceID1Name { get; set; }

        public Nullable<double> Allowance1 { get; set; }

        public string AllowanceID2Name { get; set; }

        public Nullable<double> Allowance2 { get; set; }

        public string AllowanceID3Name { get; set; }

        public Nullable<double> Allowance3 { get; set; }

        public string AllowanceID4Name { get; set; }

        public Nullable<double> Allowance4 { get; set; }

        public int? Seniority { get; set; }
        public partial class FieldNames
        {
            public const string CodeEmp = "CodeEmp";
            public const string ProfileName = "ProfileName";
            public const string CodeOrg = "CodeOrg";
            public const string OrgStructureName = "OrgStructureName";
            public const string JobTitleName = "JobTitleName";
            public const string PositionName = "PositionName";
            public const string DateHire = "DateHire";
            public const string DateSign = "DateSign";
            public const string RequestDate = "RequestDate";
            public const string DateStart = "DateStart";
            public const string DateEnd = "DateEnd";
            public const string DateQuit = "DateQuit";
            public const string ResignReasonName = "ResignReasonName";

            public const string E_UNIT = "E_UNIT";
            public const string E_DIVISION = "E_DIVISION";
            public const string E_DEPARTMENT = "E_DEPARTMENT";
            public const string E_SECTION = "E_SECTION";
            public const string E_TEAM = "E_TEAM";

            public const string E_GrossAmount = "E_GrossAmount";
            public const string E_MaleBirth = "E_MaleBirth";
            public const string E_FeMaleBirth = "E_FeMaleBirth";
            public const string E_ProfileCount = "E_ProfileCount";
            public const string E_ProfileIsWorking = "E_ProfileIsWorking";
            public const string E_FEMALE = "E_FEMALE";
            public const string E_MALE = "E_MALE";
            public const string E_Profile_FEMALE = "E_Profile_FEMALE";
            public const string E_Profile_MALE = "E_Profile_MALE";
            public const string ProfileQuit = "ProfileQuit";

            public const string AllowanceID1Name = "AllowanceID1Name";
            public const string Allowance1 = "Allowance1";

            public const string AllowanceID2Name = "AllowanceID2Name";
            public const string Allowance2 = "Allowance2";

            public const string AllowanceID3Name = "AllowanceID3Name";
            public const string Allowance3 = "Allowance3";

            public const string AllowanceID4Name = "AllowanceID4Name";
            public const string Allowance4 = "Allowance4";
            public const string Seniority = "Seniority";

        }
    }
}
