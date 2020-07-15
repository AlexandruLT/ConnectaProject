using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConnectaProject.Models
{
    public class OfficeModel
    {
        [Required]
        public int OfficeKey { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string District { get; set; }

        public string PostalCode { get; set; }

        public string Locality { get; set; }

        public string City { get; set; }

        public string Vat { get; set; }

        [Phone]
        public string Phone { get; set; }

        public string Pec { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }

        [Display (Name = "Unit Type")]
        public string Type { get; set; }
    }
}