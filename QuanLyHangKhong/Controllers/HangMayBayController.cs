using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyHangKhong.Models;
using QuanLyHangKhong.DAL;

namespace QuanLyHangKhong.Controllers
{
    public class HangMayBayController : Controller
    {
        // GET: HangMayBay
        public ActionResult Hang()
        {
            DALConnect connect = new DALConnect();
            var list = connect.getAllHangMB();
            return View(list);
        }

        // GET: HangMayBay/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HangMayBay/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HangMayBay/Create
        [HttpPost]
        public ActionResult Create(HangMayBayModel hangMB)
        {
            try
            {
                DALConnect connect = new DALConnect();
                if (connect.insertHangMayBay(hangMB)==true)
                {
                    return RedirectToAction("Hang", "HangMayBay");
                }
                else
                {
                    return View();
                }

   
            }
            catch
            {
                return View();
            }
        }

        // GET: HangMayBay/Edit/5
        public ActionResult Edit(int maHang)
        {
            DALConnect connect = new DALConnect();
            HangMayBayModel mayBay = connect.GetHangMayBay(maHang);
            return View(mayBay);
        }

        // POST: HangMayBay/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HangMayBayModel hangMB)
        {
            try
            {
                DALConnect connect = new DALConnect();
                if (connect.updateHangMayBay(hangMB))
                {
                    return RedirectToAction("Hang", "HangMayBay");
                }
                ViewBag.mess = "Update không thành công";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: HangMayBay/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HangMayBay/Delete/5
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
