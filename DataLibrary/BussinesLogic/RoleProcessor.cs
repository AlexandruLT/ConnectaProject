using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinesLogic
{
    public static class RoleProcessor
    {
        public static int CreateRole(string description, string insertBy)
        {
            RoleModel data = new RoleModel
            {
                Description = description,
                InsertBy = insertBy,
                InsertDate = DateTime.Now
            };

            string sql = @"insert into dbo.BUSINESS_ROLES ( description, insert_by, insert_date)
                            values (@Description, @InsertBy, @InsertDate);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static void RoleEdit(int roleKey, string description, bool editUser, bool makeSurvey, bool editSurvey, bool assignSurvey, string modifyBy)
        {
            RoleModel data = new RoleModel
            {
                Description = description,
                BusinessRolesKey = roleKey,
                EditUsers = editUser,
                EditSurvey = editSurvey,
                MakeSurvey = makeSurvey,
                AssignSurvey = assignSurvey,
                ModifyBy = modifyBy,
                ModifyDate = DateTime.Now
            };

            string sql = @"update dbo.BUSINESS_ROLES
                        set 
                        description = @Description,
                        edit_user = @EditUsers,
                        edit_survey = @EditSurvey,
                        make_survey = @MakeSurvey,
                        assign_survey = @AssignSurvey,
                        modify_by = @ModifyBy,
                        modify_date = @ModifyDate
                        where business_roles_key = @BusinessRolesKey;";

            SqlDataAccess.SaveData(sql, data);
        }

        public static List<RoleModel> LoadRoles()
        {
            string sql = @"select business_roles_key as BusinessRolesKey, description, edit_user as EditUsers, edit_survey as EditSurvey,  make_survey as MakeSurvey, assign_survey as AssignSurvey
                    from dbo.BUSINESS_ROLES
                    where dbo.BUSINESS_ROLES.deleted_date is null;";

            return SqlDataAccess.LoadData<RoleModel>(sql);
        }

        public static void RoleDelete(int roleKey, string deletedBy)
        {
            RoleModel data = new RoleModel
            {
                BusinessRolesKey = roleKey,
                DeletedBy = deletedBy,
                DeletedDate = DateTime.Now
            };

            string sql = @"update dbo.BUSINESS_ROLES
                            set
                            deleted_date = @DeletedDate, deleted_by = @DeletedBy
                            where business_roles_key = @BusinessRolesKey;";

            SqlDataAccess.SaveData(sql, data);
        }
    }
}
