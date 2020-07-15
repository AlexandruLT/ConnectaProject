using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class SurveyUserModel
    {
        public int SurveyUsersKey { get; set; }

        public int SurveyProcessKey { get; set; }

        public int EmployeeKey { get; set; }

        public int AssignedToKey { get; set; }

        public DateTime AssignedDate { get; set; }

        public int MaxCompilationDays { get; set; }

        public DateTime CampiledDate { get; set; }

        public int ValidatedKey { get; set; }

        public DateTime ValidatedDate { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}