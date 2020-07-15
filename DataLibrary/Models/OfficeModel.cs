using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class OfficeModel
    {
        public int OfficeKey { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string District { get; set; }

        public string PostalCode { get; set; }

        public string Locality { get; set; }

        public string City { get; set; }

        public string Vat { get; set; }

        public string Phone { get; set; }

        public string Pec { get; set; }

        public string Email { get; set; }

        public string InsertBy { get; set; }

        public DateTime InsertDate { get; set; }

        public string ModifyBy { get; set; }

        public DateTime ModifyDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }

        public string Type { get; set; }
    }
}
