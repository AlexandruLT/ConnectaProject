using ConnectaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using static DataLibrary.BussinesLogic.UserProcessor;

namespace ConnectaProject.Controllers
{
    public class UserController : Controller
    {

        public ActionResult RegisterView()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterView(RegisterViewModel model)
        {
            if (ModelState.IsValid)
                CreateUser(model.Username, Crypto.HashPassword(model.Password), model.InsertBy);

            return RedirectToAction("Index","Home");
        }

        public ActionResult Login()
        {
            //if (ModelState.IsValid)
            // ConfirmUser(model.Username, model.Password);


            return PartialView("_LoginView");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var data = LoadUser(model.Username);

                if (Crypto.VerifyHashedPassword(data[0].Password, model.Password))
                {

                }

            }



            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
