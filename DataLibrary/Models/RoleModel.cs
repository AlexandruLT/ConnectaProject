using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class RoleModel
    {
        public int BusinessRolesKey { get; set; }

        public string Description { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }

        public bool EditUsers { get; set; }

        public bool MakeSurvey { get; set; }

        public bool EditSurvey { get; set; }

        public bool AssignSurvey { get; set; }
    }
}
