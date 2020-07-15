using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class AreaModel
    {
        public int CompanyAreaKey { get; set; }

        public int OfficeKey { get; set; }

        public string Name { get; set; }

        public int ResponsibleKey { get; set; }

        public string Description { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}