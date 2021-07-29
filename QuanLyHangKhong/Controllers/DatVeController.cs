using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyHangKhong.Models;
using QuanLyHangKhong.DAL;

namespace QuanLyHangKhong.Controllers
{
    public class DatVeController : Controller
    {
        // GET: DatVe
        public ActionResult Ve()
        {
            DALConnect connect = new DALConnect();
            var list = connect.getAllDatVe();
            return View(list);
        }

        // GET: DatVe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DatVe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatVe/Create
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

        // GET: DatVe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatVe/Edit/5
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

        // GET: DatVe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DatVe/Delete/5
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
