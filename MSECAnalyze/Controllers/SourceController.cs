using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSECAnalyze.Controllers
{
    public class SourceController : Controller
    {
        // GET: Source
        public ActionResult Index()
        {
            return View();
        }

        // GET: Source/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Source/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Source/Create
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

        // GET: Source/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Source/Edit/5
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

        // GET: Source/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Source/Delete/5
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
