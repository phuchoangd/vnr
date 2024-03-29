﻿using System;
using HRM.Infrastructure.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Linq;
using HRM.Data.HrmSystem.Model;

namespace HRM.Business.HrmSystem.Domain.NUnitTest
{
    [TestFixture]
    public class Sys_DataPermissionServices_NUnitTest
    {
        string status = string.Empty;
        /// <summary>
        /// Lấy tổng số bản ghi có trong table
        /// </summary>
        [Test]
        public void NUnit_DataPermission_Domain_Get()
        {
            Sys_DataPermissionServices service = new Sys_DataPermissionServices();
            var repo = service.GetAllUseEntity<Sys_DataPermission>(ref status);
            Console.Write("Total Record: " + repo.Count());
        }

        /// <summary>
        /// Tìm kiếm dữ liệu theo Id
        /// </summary>
        [Test]
        public void NUnit_DataPermission_Domain_GetById()
        {
            Sys_DataPermissionServices service = new Sys_DataPermissionServices();
            var model = new Sys_DataPermission { Id = 3 };
            var result = service.GetById<Sys_DataPermission>(model.Id, ref status) as Sys_DataPermission;
            NUnit.Framework.Assert.IsNotNull(result);
            Console.Write("SearchResult: " + result.Id
                + " | " + result.Code
                + " | " + result.UserID
                + " | " + result.GroupID
                );
        }

        /// <summary>
        /// Thêm mới 10 bản ghi, in ra các bản ghi và tổng số bản ghi insert thành công
        /// </summary>
        [Test]
        public void NUnit_DataPermission_Domain_Add()
        {
            Sys_DataPermissionServices service = new Sys_DataPermissionServices();
            bool result = true;
            int countSC = 0;
            for (int i = 1; i <= 10; i++)
            {

                var model = new Sys_DataPermission
                {
                    Id = i,
                    Code = i.ToString(),
                    GroupID = 1,
                    UserID = 1
                };
             var   result1 = service.Add<Sys_DataPermission>(model);
                NUnit.Framework.Assert.IsTrue(result);
                if (result == true)
                {
                    countSC += 1;
                    Console.WriteLine("Process Success >>> Create >>> " + model.Id
                        + " | " + model.Code
                        );
                }
            }
            Console.WriteLine("Total success record: " + countSC);
        }

        /// <summary>
        /// Update dữ liệu theo Id
        /// </summary>
        [Test]
        public void NUnit_DataPermission_Domain_Edit()
        {
            Sys_DataPermissionServices service = new Sys_DataPermissionServices();
            var model = new Sys_DataPermission
            {
                Id = 3,
                Code = "3",
                UserID = 1,
                GroupID = 1
            };
            var result = service.Edit<Sys_DataPermission>(model);
           // NUnit.Framework.Assert.IsTrue(result);
            if (result == ActionStatus.EditSucceed.ToString())
            {
                Console.WriteLine("Process Success >>> Update >>> " + model.Id
                        + " | " + model.Code
                        + " | " + model.UserID
                        + " | " + model.GroupID
                        );
            }
        }

        /// <summary>
        /// Chuyển đổi trạng thái IsDelete của bản ghi thành true, 
        /// </summary>
        [Test]
        public void NUnit_DataPermission_Domain_Remove()
        {
            Sys_DataPermissionServices service = new Sys_DataPermissionServices();
            int rs = 0;
            var model = new Sys_DataPermission { Id = 2 };
            var result = service.Delete<Sys_DataPermission>(model.Id);
          //  NUnit.Framework.Assert.IsTrue(result);
            if (result == ActionStatus.DeleteSucceed.ToString())
            {
                rs += 1;
                Console.WriteLine("Process Success >>> Remove >>> " + model.Id);
            }
        }

        /// <summary>
        /// Xóa bản ghi theo Id có trong table
        /// </summary>
        [Test]
        public void NUnit_DataPermission_Domain_Delete()
        {
            Sys_DataPermissionServices service = new Sys_DataPermissionServices();
            int rs = 0;
            var model = new Sys_DataPermission { Id = 3 };
            var result = service.Delete<Sys_DataPermission>(model.Id);
         //   NUnit.Framework.Assert.IsTrue(result);
            if (result == ActionStatus.DeleteSucceed.ToString())
            {
                rs += 1;
                Console.WriteLine("Process Success >>> Delete >>> " + model.Id);
            }
        }
    }
}
