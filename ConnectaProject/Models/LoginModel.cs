using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class LoginModel
    {
        public int LoginKey { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime ExpireDate { get; set; }

        public char UserType { get; set; }

        public char Active { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}