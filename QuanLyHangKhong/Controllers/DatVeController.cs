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
        DALConnect connect = new DALConnect();
        // GET: DatVe
        public ActionResult Ve()
        {

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
        public ActionResult Create(DatVeModel datVeModel)
        {
            try
            {
                if (connect.insertDV(datVeModel))
                {
                    return RedirectToAction("Ve", "DatVe");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: DatVe/Edit/5
        public ActionResult Edit(int maHoaDon)
        {
            DatVeModel datVe = connect.GetDatVe(maHoaDon);
            return View(datVe);
        }

        // POST: DatVe/Edit/5
        [HttpPost]
        public ActionResult Edit(DatVeModel datVe)
        {
            try
            {
                if (connect.updateDV(datVe))
                {
                    return RedirectToAction("Ve","DatVe");
                }
                ViewBag.mess = "Sửa vé không thành công";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: DatVe/Delete/5
        public ActionResult Delete(int maHoaDon)
        {
            try
            {
                if (connect.deleteDV(maHoaDon))
                {
                    return RedirectToAction("Ve", "DatVe");
                }
                return RedirectToAction("Ve", "DatVe");
            }
            catch
            {
                return View();
            }
        }

        // POST: DatVe/Delete/5
        [HttpPost]
        public ActionResult Delete(DatVeModel datVe)
        {
            try
            {
                if (connect.deleteDV(datVe.MaHD))
                {
                    return RedirectToAction("Ve", "DatVe");
                }
                return RedirectToAction("Ve", "DatVe");
            }
            catch
            {
                return View();
            }
        }
    }
}
