using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models 
{
    public class RoleModel
    {
        public int BusinessRolesKey { get; set; }

        [Display (Name = "Type")]
        public string Description { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }

        [Display(Name = "Edit Users")]
        public bool EditUsers { get; set; }

        [Display(Name = "Make Survey")]
        public bool MakeSurvey { get; set; }

        [Display(Name = "Edit Survey")]
        public bool EditSurvey { get; set; }

        [Display(Name = "Assign Survey")]
        public bool AssignSurvey { get; set; }
    }
}