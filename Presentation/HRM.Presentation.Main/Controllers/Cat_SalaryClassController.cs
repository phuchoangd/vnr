﻿using System.Web.Mvc;
using HRM.Presentation.Category.Models;
using HRM.Infrastructure.Utilities;
using VnResource.Helper.Security;
using HRM.Infrastructure.Security;
using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using HRM.Presentation.Main.Controllers;
namespace HRM.Presentation.Main.Web.Controllers
{
    public class Cat_SalaryClassController : MainBaseController
    {
        private readonly string _hrm_Hr_Service = ConstantPathWeb.Hrm_Hre_Service;
        public ActionResult Index()
        {
           
            return View();
        }
        /// <summary>
        /// Edit một Record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
           
            var service = new RestServiceClient<Cat_SalaryClassModel>(UserLogin);
            service.SetCookies(this.Request.Cookies, _hrm_Hr_Service);
            var result = service.Get(_hrm_Hr_Service, "api/Cat_SalaryClass/", id);
            return View(result);
        }

        public ActionResult CatSalaryClassInfo(string id)
        {
            
            if (!string.IsNullOrEmpty(id))
            {
                var id1 = Common.ConvertToGuid(id);
                var service = new RestServiceClient<Cat_SalaryClassModel>(UserLogin);
                service.SetCookies(Request.Cookies, _hrm_Hr_Service);
                var modelResult = service.Get(_hrm_Hr_Service, "api/Cat_SalaryClass/", id1);
                return View(modelResult);
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// [Quoc.Do] - Chuyển trạng thái IsDelete của các record được chọn sang True
        /// </summary>
        /// <param name="selectedIds"></param>
        /// <returns></returns>
        public ActionResult RemoveSelected(string selectedIds)
        {
            return RemoveOrDeleteAndReturn<Cat_SalaryClassModel>(_hrm_Hr_Service, "api/Cat_SalaryClass/", selectedIds, ConstantPermission.Cat_SalaryClass, DeleteType.Remove.ToString());
        }
    }
}