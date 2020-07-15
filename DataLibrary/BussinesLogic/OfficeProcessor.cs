using DataLibrary.Models;
using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinesLogic
{
    public static class OfficeProcessor
    {
        public static int CreateOffice(string name, string address, string district, string postalCode, string locality, string city, string vat, string phone, string pec, string email, string insertBy, string type)
        {
            OfficeModel data = new OfficeModel
            {
                Name = name,
                Address = address,
                District = district,
                PostalCode = postalCode,
                Locality = locality,
                City = city,
                Vat = vat,
                Phone = phone,
                Pec = pec,
                Email = email,
                InsertBy = insertBy,
                InsertDate = DateTime.Now,
                Type = type
            };

            string sql = @"insert into dbo.OFFICES ( name, address, district, postal_code, locality, city, vat, phone, pec, email, insert_by, insert_date, type)
                        values (@Name, @Address, @District, @PostalCode, @Locality, @City, @Vat, @Phone, @Pec, @Email, @InsertBy, @InsertDate, @Type);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static void EditOffice(int officeKey, string name, string address, string district, string postalCode, string locality, string city, string vat, string phone, string pec, string email, string modifyBy, string type)
        {
            OfficeModel data = new OfficeModel
            {
                OfficeKey = officeKey,
                Name = name,
                Address = address,
                District = district,
                PostalCode = postalCode,
                Locality = locality,
                City = city,
                Vat = vat,
                Phone = phone,
                Pec = pec,
                Email = email,
                ModifyBy = modifyBy,
                ModifyDate = DateTime.Now,
                Type = type
            };

            string sql = @"update dbo.OFFICES
                        set 
                        name = @Name,
                        address = @Address,
                        district = @District,
                        postal_code = @PostalCode,
                        locality = @Locality,
                        city = @City,
                        vat = @Vat,
                        phone = @Phone,
                        pec = @Pec,
                        email = @Email,
                        modify_by = @ModifyBy,
                        modify_date = @ModifyDate,
                        type = @Type
                        where offices_key = @OfficeKey;";

            SqlDataAccess.SaveData(sql, data);
        }

        public static List<OfficeModel> LoadUnits()
        {
            string sql = @"select offices_key as OfficeKey, name, city, address, type from dbo.OFFICES
                            where deleted_date is null;";

            return SqlDataAccess.LoadData<OfficeModel>(sql);
        }

        public static List<OfficeModel> LoadOfficeDetails(string officeKey)
        {
            OfficeModel data = new OfficeModel
            {
                OfficeKey = Int32.Parse(officeKey)
            };

            string sql = @"select offices_key as OfficeKey, name, address, district, postal_code as PostalCode, locality, city, vat, phone, pec, email, type from dbo.OFFICES
                        where offices_key = @OfficeKey;";

            return SqlDataAccess.LoadRow<OfficeModel>(sql, data);
        }

        public static void UnitDelete (int officeKey)
        {
            OfficeModel data = new OfficeModel
            {
                OfficeKey = officeKey,
                DeletedDate = DateTime.Now
            };

            string sql = @"update dbo.Offices
                            set
                            deleted_date = @DeletedDate
                            where offices_key = @OfficeKey;";

            SqlDataAccess.SaveData(sql, data);
        }
    }
}
