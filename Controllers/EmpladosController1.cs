using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tienda.Contexts;

namespace tienda.Controllers
{
    public class EmpladosController1 : Controller
    {
        private AppDbContext context;

        public EmpladosController1(AppDbContext context)
        {
            this.context = context;
        }
        // GET: EmpladosController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: EmpladosController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpladosController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpladosController1/Create
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

        // GET: EmpladosController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpladosController1/Edit/5
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

        // GET: EmpladosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpladosController1/Delete/5
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
