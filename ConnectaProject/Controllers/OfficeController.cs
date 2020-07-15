using ConnectaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BussinesLogic.OfficeProcessor;

namespace ConnectaProject.Controllers
{
    public class OfficeController : Controller
    {
        [Route("/Office")]
        public ActionResult UnitView()
        {
            var data = LoadUnits();
            List<OfficeModel> units = new List<OfficeModel>();

            foreach (var unit in data)
            {
                units.Add(new OfficeModel
                {
                    OfficeKey = unit.OfficeKey,
                    Name = unit.Name,
                    City = unit.City,
                    Address = unit.Address,
                    Type = unit.Type
                });
            }

            return View(units);
        }

        public ActionResult OfficeDetails(string id)
        {
            var data = LoadOfficeDetails(id);

            OfficeModel model = new OfficeModel
            {
                OfficeKey = data[0].OfficeKey,
                Name = data[0].Name,
                Address = data[0].Address,
                City = data[0].City,
                District = data[0].District,
                PostalCode = data[0].PostalCode,
                Locality = data[0].Locality,
                Type = data[0].Type,
                Vat = data[0].Vat,
                Phone = data[0].Phone,
                Pec = data[0].Pec,
                Email = data[0].Email
            };

            ViewBag.Message = "EDIT";


            return PartialView("_CreateEditOfficeView", model);
        }

        [HttpPost]
        public ActionResult OfficeDetails(OfficeModel model, string id)
        {
            EditOffice(model.OfficeKey, model.Name, model.Address, model.District, model.PostalCode, model.Locality, model.City, model.Vat, model.Phone, model.Pec, model.Email, model.ModifyBy, model.Type);

            return RedirectToAction("UnitView");
        }

        public ActionResult AddOffice()
        {
            ViewBag.Message = "CREATE";

            return PartialView("_CreateEditOfficeView");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOffice(OfficeModel model)
        {
            CreateOffice(model.Name, model.Address, model.District, model.PostalCode, model.Locality, model.City, model.Vat, model.Phone, model.Pec, model.Email, model.InsertBy, model.Type);
 
            return RedirectToAction("UnitView");
        }

        [HttpPost]
        public ActionResult DeleteOffice(int Id)
        {
            UnitDelete(Id);

            return RedirectToAction("UnitView");
        }
    }
}
