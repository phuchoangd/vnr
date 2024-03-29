﻿using HRM.Business.Category.Domain;
using HRM.Business.Category.Models;
using HRM.Infrastructure.Utilities;
using HRM.Presentation.Category.Models;
using HRM.Presentation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using VnResource.Helper.Data;
namespace HRM.Presentation.Hr.Service.Controllers.api
{
    public class Cat_GradeAttendanceController : ApiController
    {
        #region UserLogin
        private string userLogin = string.Empty;
        public string UserLogin
        {
            get
            {
                if (Request.Headers != null)
                {
                    var headerValues = Request.Headers.GetValues(HeaderObject.UserLogin);
                    userLogin = headerValues.FirstOrDefault();
                }
                return userLogin;
            }
        }
        #endregion
        /// <summary>
        /// [Tin.Nguyen] - Lấy dữ liệu Quốc Gia(Cat_Country) theo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cat_GradeAttendanceModel GetById(Guid id)
        {
            string status = string.Empty;
            var model = new Cat_GradeAttendanceModel();
            ActionService service = new ActionService(UserLogin);
            //var entity = service.GetById<Cat_GradeAttendanceEntity>(id, ref status);
            var entity = service.GetByIdUseStore<Cat_GradeAttendanceEntity>(id, ConstantSql.hrm_cat_sp_get_Cat_GradeAttendanceById, ref status);
            if (entity != null)
            {
                model = entity.CopyData<Cat_GradeAttendanceModel>();
            }
            model.ActionStatus = status;
            return model;
        }

        /// <summary>
        /// [Tin.Nguyen] - Xóa hoặc chuyển đổi trạng thái Quốc Gia(Cat_Country) sang IsDelete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cat_GradeAttendanceModel DeleteOrRemove(string id)
        {
            ActionService service = new ActionService(UserLogin);
            var result = service.DeleteOrRemove<Cat_GradeAttendanceEntity, Cat_GradeAttendanceModel>(id);
            return result;
        }

        /// <summary>
        /// [Tin.Nguyen] - Xử lý thêm mới hoặc chỉnh sửa một Quốc Gia(Cat_Country)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.RouteAttribute("api/Cat_GradeAttendance")]
        public Cat_GradeAttendanceModel Post([Bind]Cat_GradeAttendanceModel model)
        {
            model.RosterType = GradeRosterType.E_ISROSTER.ToString();
            ActionService service = new ActionService(UserLogin);
            if (model.FormulaAnnualLeave != null)
            {
                model.FormulaAnnualLeave = model.FormulaAnnualLeave.Replace("[+]", "+");
            }
            return service.UpdateOrCreate<Cat_GradeAttendanceEntity, Cat_GradeAttendanceModel>(model);
        }
    }
}
