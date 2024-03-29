﻿using System.Web.Mvc;
using HRM.Presentation.Category.Models;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Newtonsoft.Json;
using HRM.Infrastructure.Security;
using HRM.Presentation.Category.Models;
using HRM.Infrastructure.Utilities;
using System.Collections.Generic;
using VnResource.Helper.Security;
using System.IO;
using System;
using System.Linq;
using HRM.Presentation.Main.Controllers;

//using HRM.Infrastructure.Utilities;

namespace HRM.Presentation.Main.Web.Controllers
{

    public class Cat_CategoryController : MainBaseController
    {
        readonly string _hrm_Hr_Service = ConstantPathWeb.Hrm_Hre_Service;
        //
        //
        // GET: /CatCategory/
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult CatCategoryInfo(string id)
        {
            
            if (!string.IsNullOrEmpty(id))
            {
                var id1 = Common.ConvertToGuid(id);
                var service = new RestServiceClient<CatCategoryModel>(UserLogin);
                service.SetCookies(Request.Cookies, _hrm_Hr_Service);
                var result = service.Get(_hrm_Hr_Service, "api/CatCategory/", id1);
                return View(result);
            }
            else
            {
                return View();
            }
        }

    


        public ActionResult RemoveSelected(string selectedIds)
        {
            return RemoveOrDeleteAndReturn<CatCategoryModel>(_hrm_Hr_Service, "api/CatCategory/", selectedIds,ConstantPermission.Cat_Category,DeleteType.Remove.ToString());
        

        }

    }
}