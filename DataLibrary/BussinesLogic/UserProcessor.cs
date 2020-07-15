using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BussinesLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(string username, string password, string insertBy)
        {
            UserModel data = new UserModel
            {
                Username = username,
                Password = password,
                InsertBy = insertBy,
                InsertDate = DateTime.Now
            };


            if (LoadUser(username) == null)
            {
                string sql = @"insert into dbo.LOGIN ( username, password, insert_by, insert_date)
                                values (@Username, @Password, @InsertBy, @InsertDate);";

                return SqlDataAccess.SaveData(sql, data);
            }

            return -1;
        }

        //public static void RoleEdit(int roleKey, string description, bool editUser, bool makeSurvey, bool editSurvey, bool assignSurvey, string modifyBy)
        //{
        //    RoleModel data = new RoleModel
        //    {
        //        Description = description,
        //        BusinessRolesKey = roleKey,
        //        EditUsers = editUser,
        //        EditSurvey = editSurvey,
        //        MakeSurvey = makeSurvey,
        //        AssignSurvey = assignSurvey,
        //        ModifyBy = modifyBy,
        //        ModifyDate = DateTime.Now
        //    };

        //    string sql = @"update dbo.BUSINESS_ROLES
        //                set 
        //                description = @Description,
        //                edit_user = @EditUsers,
        //                edit_survey = @EditSurvey,
        //                make_survey = @MakeSurvey,
        //                assign_survey = @AssignSurvey,
        //                modify_by = @ModifyBy,
        //                modify_date = @ModifyDate
        //                where business_roles_key = @BusinessRolesKey;";

        //    SqlDataAccess.SaveData(sql, data);
        //}

        public static List<UserModel> LoadUser(string username)
        {
            UserModel data = new UserModel
            {
                Username = username
            };
                
            string sql = @"select username as Username, password as Password
                    from dbo.LOGIN
                    where dbo.LOGIN.deleted_date is null and username = @Username;";

            return SqlDataAccess.LoadRow<UserModel>(sql, data);
        }
        
        //public static void RoleDelete(int roleKey, string deletedBy)
        //{
        //    RoleModel data = new RoleModel
        //    {
        //        BusinessRolesKey = roleKey,
        //        DeletedBy = deletedBy,
        //        DeletedDate = DateTime.Now
        //    };

        //    string sql = @"update dbo.BUSINESS_ROLES
        //                    set
        //                    deleted_date = @DeletedDate, deleted_by = @DeletedBy
        //                    where business_roles_key = @BusinessRolesKey;";

        //    SqlDataAccess.SaveData(sql, data);
        //}

    }
}
