using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using fbTest.Models;


namespace fbTest.Controllers
{
    public class imageController : Controller
    {
        // GET: image
        public ActionResult Index()
        {
            return View();
        }

        //Get SignUp Page
        public ActionResult SignUp()
        {
            return View();
        }


        // GET: image/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: image/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: image/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: image/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: image/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: image/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: image/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}