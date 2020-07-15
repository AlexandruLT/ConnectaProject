using ConnectaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BussinesLogic.RoleProcessor;

namespace ConnectaProject.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult RoleView()
        {
            var data = LoadRoles();

            List<RoleModel> roles = new List<RoleModel>();

            foreach (var role in data)
            {
                roles.Add(new RoleModel
                {
                    BusinessRolesKey = role.BusinessRolesKey,
                    Description = role.Description,
                    EditUsers = role.EditUsers,
                    EditSurvey  = role.EditSurvey,
                    MakeSurvey = role.MakeSurvey,
                    AssignSurvey = role.AssignSurvey
                });
            }

            return View(roles);
        }

        [HttpPost]
        public ActionResult EditRole(RoleModel model)
        {
            RoleEdit(model.BusinessRolesKey, model.Description, model.EditUsers, model.MakeSurvey, model.EditSurvey, model.AssignSurvey, model.ModifyBy);

            return RedirectToAction("RoleView");
        }

        [HttpPost]
        public ActionResult AddRole(RoleModel model)
        {
            CreateRole(model.Description, model.InsertBy);

            return RedirectToAction("RoleView");
        }

        

        [HttpPost]
        public ActionResult DeleteRole(RoleModel model)
        {
            RoleDelete(model.BusinessRolesKey, model.DeletedBy);

            return RedirectToAction("RoleView");
        }
    }
}
