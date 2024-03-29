﻿using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using HRM.Presentation.Category.Models;
using HRM.Infrastructure.Utilities;
using System.Collections.Generic;
using VnResource.Helper.Security;
using HRM.Infrastructure.Security;
using System.IO;
using System;
using System.Linq;
using HRM.Presentation.Main.Controllers;

namespace HRM.Presentation.Main.Web.Controllers
{
    public class Cat_DistrictController : MainBaseController
    {

        readonly string _hrm_Hre_Service = ConstantPathWeb.Hrm_Hre_Service;
        //
        // GET: /CatDistrict/
        public ActionResult Index()
        {
            
            //var catProvince = GetAllCatProvince();
            //ViewData["catProvince"] = catProvince;
            return View();
        }

        /// <summary>
        /// Lấy tất cả dữ liệu trong table CatDistrict
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatProvinceModel> GetAllCatProvince()
        {           
            var service = new RestServiceClient<IEnumerable<CatProvinceModel>>(UserLogin);
            service.SetCookies(Request.Cookies, _hrm_Hre_Service);
            var result = service.Get(_hrm_Hre_Service, "api/CatProvince/");
            return result;
        }

        /// <summary>
        /// Lấy tất cả dữ liệu trong table CatDistrict
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ActionResult GetAllCatDistrict([DataSourceRequest] DataSourceRequest request)
        {            
            var service = new RestServiceClient<IEnumerable<CatDistrictModel>>(UserLogin);
            service.SetCookies(Request.Cookies, _hrm_Hre_Service);
            var result = service.Get(_hrm_Hre_Service, "api/CatDistrict/");
            return Json(result.ToDataSourceResult(request));
        }

        /// <summary>
        /// Lấy tất cả dữ liệu cho control multiselect
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult GetMultiselect()
        {
            var service = new RestServiceClient<IEnumerable<CatDistrictModel>>(UserLogin);
            service.SetCookies(Request.Cookies, _hrm_Hre_Service);
            var result = service.Get(_hrm_Hre_Service, "api/CatDistrict/");
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Tạo mời một CatDistrict
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ActionResult Create([Bind] CatDistrictModel model)
        {
            
            var service = new RestServiceClient<CatDistrictModel>(UserLogin);
            service.SetCookies(this.Request.Cookies, _hrm_Hre_Service);
            var result = service.Put(_hrm_Hre_Service, "api/CatDistrict/", model);
            return Json(result);
        }

        /// <summary>
        /// Delete bằng id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Remove(string id)
        {
           
            var service = new RestServiceClient<CatDistrictModel>(UserLogin);
            service.SetCookies(this.Request.Cookies, _hrm_Hre_Service);
            var result = service.Delete(_hrm_Hre_Service, "api/CatDistrict/", id);
            return Json(result);
        }

        public ActionResult CreateOrUpdate(string id)
        {
            
            if (!string.IsNullOrEmpty(id))
            {
                var idModel = Common.ConvertToGuid(id);
                var service = new RestServiceClient<CatDistrictModel>(UserLogin);
                service.SetCookies(Request.Cookies, _hrm_Hre_Service);
                var result = service.Get(_hrm_Hre_Service, "api/CatDistrict/", idModel);
                return View(result);
            }
            else
            {
                return View();
            }
        }

        public ActionResult RemoveSelected(string selectedIds)
        {
            return RemoveOrDeleteAndReturn<CatDistrictModel>(_hrm_Hre_Service, "api/CatDistrict/", selectedIds, ConstantPermission.Cat_District, DeleteType.Remove.ToString());
    
        }
    }
}