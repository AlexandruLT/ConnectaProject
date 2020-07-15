using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinesLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeKey, string name, string surname, string phone, string mobile, string email, char active, string note, string insertBy, DateTime insertDate)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeKey = employeeKey,
                Name = name,
                Surname = surname,
                Phone = phone,
                Mobile = mobile,
                Email = email,
                Active = active,
                Note = note,
                InsertBy = insertBy,
                InsertDate = insertDate
            };

            string sql = @"insert into dbo.EMPLOYEE ( employee_key, name, surname, phone, mobile, email, active, note, insert_by, insert_date)
                        values (@EmployeeKey, @Name, @Surname, @Phone, @Mobile, @Email, @Active, @Note, @InsertBy, @InsertDate);";

            return SqlDataAccess.SaveData<EmployeeModel>(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            //TO DO : cross with department/ unit / type
            string sql = @"select name, surname, active
                        from dbo.EMPLOYEE;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
