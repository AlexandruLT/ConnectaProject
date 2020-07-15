using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class UserViewModel
    {
        public int EmployeeKey { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public char Active { get; set; }

        public string Note { get; set; }


    }
}