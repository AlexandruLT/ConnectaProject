using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class RelEmployeeOfficesModel
    {
        public int RelEmployeeOfficeKey { get; set; }

        public int RelEmployeeKey { get; set; }

        public int RelOfficeKey { get; set; }

        public int RelComapnyAreaKey { get; set; }

        public int RelBusinessRoleKey { get; set; }

        public DateTime RelStartDate { get; set; }

        public DateTime RelEndDate { get; set; }

        public string RelEmployeeOfficeNote { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}