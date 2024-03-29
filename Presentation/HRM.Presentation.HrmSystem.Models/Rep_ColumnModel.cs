﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Presentation.HrmSystem.Models
{
    public class Rep_ColumnModel : BaseViewModel
    {
        public string ColumnName { get; set; }
        public Nullable<System.Guid> MasterID { get; set; }
        public string TableName { get; set; }
        public string DisplayName { get; set; }
        public Nullable<int> ColumnOrdinal { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsSum { get; set; }
        public Nullable<bool> IsGroup { get; set; }
    }
}
