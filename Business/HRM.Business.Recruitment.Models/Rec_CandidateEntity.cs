﻿using System;

namespace HRM.Business.Recruitment.Models
{
    public class Rec_CandidateEntity : HRM.Business.BaseModel.HRMBaseModel
    {
        public Nullable<System.Guid> WorkPlaceID { get; set; }
        public string WorkPlaceName { get; set; }
        public Nullable<System.DateTime> DateInterview1 { get; set; }
        public Nullable<System.DateTime> DateInterview2 { get; set; }
        public Nullable<System.DateTime> DateInterview3 { get; set; }
        public Nullable<System.DateTime> DateInterview4 { get; set; }
        public Nullable<System.DateTime> DateInterview5 { get; set; }
        public string LanguageCode1 { get; set; }
        public string LanguageCode2 { get; set; }
        public string LanguageCode3 { get; set; }
        public string LanguageCode4 { get; set; }
        public string LanguageCode5 { get; set; }
        public double? Score1_1 { get; set; }
        public double? Score1_2 { get; set; }
        public double? Score1_3 { get; set; }
        public string KQ1 { get; set; }

        public double? Score2_1 { get; set; }
        public double? Score2_2 { get; set; }
        public double? Score2_3 { get; set; }
        public string KQ2 { get; set; }

        public double? Score3_1 { get; set; }
        public double? Score3_2 { get; set; }
        public double? Score3_3 { get; set; }
        public string KQ3 { get; set; }

        public double? Score4_1 { get; set; }
        public double? Score4_2 { get; set; }
        public double? Score4_3 { get; set; }
        public string KQ4 { get; set; }

        public double? Score5_1 { get; set; }
        public double? Score5_2 { get; set; }
        public double? Score5_3 { get; set; }
        public string KQ5 { get; set; } 



        public double? Score1 { get; set; }
        public double? Score2 { get; set; }
        public double? Score3 { get; set; }
        public string ResultInterview { get; set; }
        public string PositionCode { get; set; } 
        public string JobVacancyCode { get; set; }
        public string Experience { get; set; }
        public string HealthStatusView { get; set; }
        public Nullable<double> LevelEye { get; set; }
        public Guid? SourceAdsID { get; set; }
        public string SourceAdsName { get; set; }
        public string CandidateName { get; set; }
        public Nullable<int> CandidateNumber { get; set; }
        public string Gender { get; set; }
        public string udGender { get; set; }
        public string udStatus { get; set; }
        public string GenderView { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string IdentifyNumber { get; set; }
        public string PassportNo { get; set; }
        public Nullable<System.DateTime> DateIssuePassport { get; set; }
        public Nullable<System.DateTime> DateExpiresPassport { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mobile2 { get; set; }
        public string Email { get; set; }
        public string Eyesight { get; set; }
        public string TimeWorkType { get; set; }
        public Nullable<bool> IsAcceptOvertime { get; set; }
        public string PeopleGuarantee { get; set; }
        public string PositionGuarantee { get; set; }
        public string Vehicles { get; set; }
        public string SourceAds { get; set; }
        public string HealthStatus { get; set; }
        public Guid? EthnicID { get; set; }
        public string EthnicName { get; set; }
        public Guid? ReligionID { get; set; }
        public string ReligionName { get; set; }
        public Nullable<double> Height { get; set; }
        public Nullable<double> Weight { get; set; }
        public Guid? MarriageStatusID { get; set; }
        public string MarriageStatusView { get; set; }
        public Guid? UserWaitApproveID { get; set; }
        public string UserWaitApproveName { get; set; }
        public Nullable<System.DateTime> DateApprove { get; set; }
        public string PersonalPlan { get; set; }
        public string PersionalWebsite { get; set; }
        public string PersonalTarget { get; set; }
        public string SpecialSkill { get; set; }
        public string OrientationCareer { get; set; }
        public string LongtermOrientation { get; set; }
        public string ShorttermOrientation { get; set; }
        public string MemberOfAssociation { get; set; }
        public string WorkplaceSuggestion { get; set; }
        public string Status { get; set; }
        public string StatusView { get; set; }
        public string StatusLast { get; set; }
        public Nullable<System.DateTime> DateApply { get; set; }
        public Nullable<System.DateTime> DateStartWorking { get; set; }
        public string WorkingType { get; set; }
        public string WorkingTypePeriod { get; set; }
        public string Assessment { get; set; }
        public Nullable<double> ScorePotential { get; set; }
        public Guid? RecruitmentCampaignID { get; set; }
        public string RecruitmentCampaignName { get; set; }
        public Guid? OrgStructureID { get; set; }
        public string OrgStructureName { get; set; }
        public Guid? JobVacancyID { get; set; }
        public string JobVacancyName { get; set; }
        public Guid? TagID { get; set; }
        public string TagName { get; set; }
        public Guid? PositionID { get; set; }
        public string PositionName { get; set; }
        public string SalarySuggest { get; set; }
        public string SalaryApprove { get; set; }
        public string SalaryCurrent { get; set; }
        public Guid? CurrencyID { get; set; }
        public string CurrencyName { get; set; }
        public string Weak { get; set; }
        public string Strong { get; set; }
        public Nullable<bool> IsReadyBizTrip { get; set; }
        public Nullable<double> YearOfExperience { get; set; }
        public Nullable<bool> IsAnnounceResult { get; set; }
        public string AssociationProfessional { get; set; }
        public string IntroducePerson { get; set; }
        public string FileAttachment { get; set; }
        //public Guid? CurrencyID { get; set; }
        //public string CurrencyName { get; set; }
        public Guid? CurrencyID1 { get; set; }
        public string CurrencyName1 { get; set; }
        public Guid? CurrencyID2 { get; set; }
        public string CurrencyName2 { get; set; }
        public Guid? CurrencyID3 { get; set; }
        public string CurrencyName3 { get; set; }
        public Guid? RecSourceID { get; set; }
        public string RecSourceName { get; set; }
        public Nullable<System.DateTime> IDDateOfIssue { get; set; }
        public string IDPlaceOfIssue { get; set; }
        public string TAddress { get; set; }
        public Guid? TCountryID { get; set; }
        public string TCountryName { get; set; }
        public Guid? TProvinceID { get; set; }
        public string TProvinceName { get; set; }
        public Guid? TDistrictID { get; set; }
        public string TDistrictName { get; set; }
        public string PAddress { get; set; }
        public Guid? PCountryID { get; set; }
        public string PCountryName { get; set; }
        public Guid? PProvinceID { get; set; }
        public string PProvinceName { get; set; }
        public Guid? PDistrictID { get; set; }
        public string PDistrictName { get; set; }
        public Guid? NationalityID { get; set; }
        public string NationalityName { get; set; }
        public string MarriageStatus { get; set; }
        public Nullable<double> Allowance { get; set; }
        public Guid? JobTitleID { get; set; }
        public string JobTitleName { get; set; }
        public Nullable<int> ProbationDay { get; set; }
        public string SkillLevel { get; set; }
        public Nullable<System.DateTime> DateHire { get; set; }
        public string NameEnglish { get; set; }
        public Guid? BirthDayID { get; set; }
        public string PlaceOfBirth { get; set; }
        public Guid? PlaceOfIssueID { get; set; }
        public string PlaceOfIssueName { get; set; }
        public Guid? EducationLevelID { get; set; }
        public string EducationLevelName { get; set; }
        public string Origin { get; set; }
       // public Guid? CurrencyID1 { get; set; }
        public string CurrencyIDName { get; set; }
        public string ImagePath { get; set; }
        public string PlaceWrokLast { get; set; }
        public Nullable<bool> IsRecruiting { get; set; }
        public string CodeCandidate { get; set; }
        public string PepolePresent { get; set; }
        public string SalaryPayment { get; set; }
        public string ApproveHistory { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsBlackList { get; set; }
        public Nullable<bool> PassFilterResume { get; set; }
        public Nullable<int> LevelInterview { get; set; }

        public Nullable<double> SalaryProbationary { get; set; }
        public Nullable<double> Allowance1 { get; set; }
        public Nullable<System.Guid> AllowanceID1 { get; set; }
        public Nullable<double> Allowance2 { get; set; }
        public Nullable<System.Guid> AllowanceID2 { get; set; }
        public Nullable<double> Allowance3 { get; set; }
        public Nullable<System.Guid> AllowanceID3 { get; set; }
        public Nullable<double> Allowance4 { get; set; }
        public Nullable<System.Guid> AllowanceID4 { get; set; }
        public Nullable<bool> IsFilteredFile { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
        public Nullable<System.DateTime> WorkingTime { get; set; }
        public Nullable<System.Guid> SalaryClassID { get; set; }
        public string JobConditionIDs { get; set; }

        public Nullable<int> CallNumber { get; set; }
        public string ReasonDeny { get; set; }
        public string StatusHire { get; set; }
        public double? GenaralHealth { get; set; }
        public double? WriteTest { get; set; }
        public double? Interview { get; set; }
        public string DiseaseListIDs { get; set; }
        public Nullable<double> LevelEyeRight { get; set; }
        public Nullable<double> Musculoskeletal { get; set; }
        public Nullable<double> BloodPressure { get; set; }
        public Nullable<double> HeartBeat { get; set; }
        public string DiseaseListCodes { get; set; }
        public Nullable<System.DateTime> DateExam { get; set; }
        public string RankName { get; set; }
        public string ReasonFailFilter { get; set; }
        public string GraduateSchool { get; set; }
        public string Specialisation { get; set; }
        public Nullable<System.DateTime> YearGraduation { get; set; }
        public Nullable<bool> IsFilterCV { get; set; }
        public string ReasonBlackListName { get; set; }
        public string ContractNo { get; set; }
        public DateTime? DateApplyContract { get; set; }
        public DateTime? DateSignedConstract { get; set; }
        public double? Salary { get; set; }
        public string Currency { get; set; }
        public Guid? ProfileId { get; set; }
    }

    public class Rec_CandidateMultiEntity
    {
        public Guid ID { get; set; }
        public string CandidateName { get; set; }
    }
}