using ConnectaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BussinesLogic.DepartmentProcessor;

namespace ConnectaProject.Controllers
{
    public class DepartmentController : Controller
    {
        [Route("/Department")]
        public ActionResult DepartmentView()
        {
            var data = LoadDepartments();
            List<DepartementViewModel> deps = new List<DepartementViewModel>();

            foreach (var dep in data)
            {
                deps.Add(new DepartementViewModel
                {
                    DepartmentKey = dep.DepartmentKey,
                    Name = dep.Name,
                    OfficeName = dep.OfficeName
                });
            }

            return View(deps);
        }

        public ActionResult DepartmentDetails(string id)
        {
            var data = LoadDepartmentDetails(id);

            var nameList = LoadUnits();

            Dictionary<int, string> offices = new Dictionary<int, string>();

            offices.Add(0, "Select");

            foreach (var dep in nameList)
            {
                offices.Add(dep.OfficeKey, dep.OfficeName);
            }

            ViewData["namesList"] = offices;

            DepartementViewModel model = new DepartementViewModel
            {

                DepartmentKey = data[0].DepartmentKey,
                OfficeKey = data[0].OfficeKey,
                Name = data[0].Name,
                ResponsibleKey = data[0].ResponsibleKey,
                Description = data[0].Description,
                OfficeName = data[0].OfficeName
            };

            ViewBag.Message = "EDIT";


            return PartialView("_CreateEditDepartmentView", model);
        }

        [HttpPost]
        public ActionResult DepartmentDetails(DepartementViewModel model, string id)
        {
            EditDepartment(model.DepartmentKey, model.Name, model.ResponsibleKey, model.Description, model.OfficeKey, model.ModifyBy);

            return RedirectToAction("DepartmentView");
        }

        public ActionResult AddDepartment()
        {
            ViewBag.Message = "CREATE";

            var data = LoadUnits();

            Dictionary<int, string> offices = new Dictionary<int, string>();

            offices.Add(0, "Select");

            foreach (var dep in data)
            {
                offices.Add(dep.OfficeKey, dep.OfficeName);
            }

            ViewData["namesList"] = offices;

            return PartialView("_CreateEditDepartmentView");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDepartment(DepartementViewModel model)
        {

            CreateDepartment(model.Name, model.ResponsibleKey, model.Description, model.OfficeKey, model.InsertBy);

            return RedirectToAction("DepartmentView");
        }

        [HttpPost]
        public ActionResult DeleteDepartment(int Id)
        {
            DepartmentDelete(Id);

            return RedirectToAction("DepartmentView");
        }
    }
}
