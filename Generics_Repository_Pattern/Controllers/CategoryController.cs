using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Generics_Repository_Pattern.Models.DAL;
using Generics_Repository_Pattern.Models;

namespace Generics_Repository_Pattern.Controllers
{
    public class CategoryController : Controller
    {
        private IAllRepository<Category> _Instance;
        public CategoryController()
        {
            this._Instance = new AllRepository<Category>();
        }
        // GET: Category changes all done accordingly
        //Changes done at VS
        //Changes done at GitHub
        public ActionResult Index()
        {
            return View(_Instance.GetModel());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        //Changes done at VS
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        //Changes done at VS
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

        // GET: Category/Edit/5
        //Changes done at VS
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        //Changes done at VS
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
