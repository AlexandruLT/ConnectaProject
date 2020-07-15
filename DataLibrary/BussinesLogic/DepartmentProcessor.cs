using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinesLogic
{
    public static class DepartmentProcessor
    {
        public static int CreateDepartment(string name, int responsibleKey, string description, int officeKey, string insertBy)
        {
                DepartmentModel data = new DepartmentModel
            {
                Name = name,
                ResponsibleKey = responsibleKey,
                Description = description,
                OfficeKey = officeKey,
                InsertBy = insertBy,
                InsertDate = DateTime.Now
            };

            string sql = @"insert into dbo.COMPANY_AREAS ( name, responsible_key, description, office_key, insert_by, insert_date)
                            values (@Name, @ResponsibleKey, @Description, @OfficeKey, @InsertBy, @InsertDate);";

                return SqlDataAccess.SaveData(sql, data);
        }

    public static void EditDepartment(int departmentKey, string name, int responsibleKey, string description, int officeKey, string modifyBy)
    {
        DepartmentModel data = new DepartmentModel
        {
            DepartmentKey = departmentKey,
            Name = name,
            ResponsibleKey = responsibleKey,
            Description = description,
            OfficeKey = officeKey,
            ModifyBy = modifyBy,
            ModifyDate = DateTime.Now
        };

        string sql = @"update dbo.COMPANY_AREAS
                        set 
                        name = @Name,
                        responsible_key = @ResponsibleKey,
                        description = @Description,
                        office_key = @OfficeKey,
                        modify_by = @ModifyBy,
                        modify_date = @ModifyDate
                        where company_areas_key = @DepartmentKey;";

        SqlDataAccess.SaveData(sql, data);
    }

    public static List<DepartmentModel> LoadDepartments()
    {
        string sql = @"select company_areas_key as DepartmentKey, dbo.COMPANY_AREAS.name, dbo.OFFICES.offices_key as OfficeKEy, dbo.OFFICES.name + ', ' + dbo.OFFICES.city as OfficeName 
                    from dbo.COMPANY_AREAS
                    left join dbo.OFFICES on  .OFFICES.offices_key = dbo.COMPANY_AREAS.office_key
                    where dbo.COMPANY_AREAS.deleted_date is null;";

        return SqlDataAccess.LoadData<DepartmentModel>(sql);
    }

    public static List<DepartmentModel> LoadDepartmentDetails(string departmentKey)
    {
        DepartmentModel data = new DepartmentModel
        {
            DepartmentKey = Int32.Parse(departmentKey)
        };

            string sql = @"select company_areas_key as DepartmentKey, dbo.COMPANY_AREAS.name as Name, responsible_key as ResponsibleKey, description, dbo.OFFICES.offices_key as OfficeKey, dbo.OFFICES.name as OfficeName
                    from dbo.COMPANY_AREAS
                    left join  dbo.OFFICES on  .OFFICES.offices_key = dbo.COMPANY_AREAS.office_key
                    where company_areas_key = @DepartmentKey;";


        return SqlDataAccess.LoadRow<DepartmentModel>(sql, data);
    }

    public static void DepartmentDelete(int departmentKey)
    {
        DepartmentModel data = new DepartmentModel
        {
            DepartmentKey = departmentKey,
            DeletedDate = DateTime.Now
        };

        string sql = @"update dbo.COMPANY_AREAS
                            set
                            deleted_date = @DeletedDate
                            where company_areas_key = @DepartmentKey;";

        SqlDataAccess.SaveData(sql, data);
    }

        public static List<DepartmentModel> LoadUnits()
        {
            string sql = @"select dbo.OFFICES.offices_key as OfficeKEy, dbo.OFFICES.name + ', ' + dbo.OFFICES.city as OfficeName from dbo.OFFICES
                            where dbo.OFFICES.deleted_date is null;";

            return SqlDataAccess.LoadData<DepartmentModel>(sql);
        }
    }
}
