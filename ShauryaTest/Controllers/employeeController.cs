using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShauryaTest.Controllers
{
    public class employeeController : Controller
    {
        // GET: employeeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: employeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: employeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: employeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: employeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: employeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: employeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: employeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
