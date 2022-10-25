using Task_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace Task_4.Controllers
{
    public class ProductController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AllProducts(lab_taskEntities1 db)
        {
            var products = db.products.ToList(); 
            return View(products);
        }

        [HttpGet]
        public ActionResult Details(lab_taskEntities1 db, int id)
        {
            var product = (from prod in db.products
                           where prod.Id == id
                           select prod).SingleOrDefault();
            return View(product);
        }

        [HttpGet]
        public ActionResult Delete(lab_taskEntities1 db, int id)
        {
            var product = (from prod in db.products
                           where prod.Id == id
                           select prod).SingleOrDefault();
            db.products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("AllProducts", "Product");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(lab_taskEntities1 db, product prod)
        {
            db.products.Add(prod);
            db.SaveChanges();
            return RedirectToAction("AllProducts", "Product");
        }

        [HttpGet]
        public ActionResult Edit(lab_taskEntities1 db, int id)
        {
            var product = (from prod in db.products
                           where prod.Id == id
                           select prod).SingleOrDefault();

            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(lab_taskEntities1 db, product prod)
        {
            var ext = (from p in db.products
                       where p.Id == prod.Id
                       select p).FirstOrDefault();

            db.Entry(ext).CurrentValues.SetValues(prod);
            db.SaveChanges();
            TempData["msg"] = "Update successful";
            return View();
        }
    }
}