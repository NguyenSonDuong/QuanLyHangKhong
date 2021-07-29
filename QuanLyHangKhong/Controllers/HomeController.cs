using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyHangKhong.Models;
using QuanLyHangKhong.DAL;

namespace QuanLyHangKhong.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DALConnect connect = new DALConnect();
            var list = connect.getAllThongTinVe();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: ThongTinVe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongTinVe/Create
        [HttpPost]
        public ActionResult Create(ThongTinVeModel ttVe)
        {
            try
            {
                DALConnect connect = new DALConnect();
                if (connect.insertTTV(ttVe))
                {
                    return RedirectToAction("Index", "Home");
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

        // GET: ThongTinVe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThongTinVe/Edit/5
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

        // GET: ThongTinVe/Delete/5
        public ActionResult Delete(int maVe)
        {
            DALConnect connect = new DALConnect();
            ThongTinVeModel tTin = connect.getthongtinve(maVe);
            return View(tTin);
           
        }

        // POST: ThongTinVe/Delete/5
        [HttpPost]
        public ActionResult Delete(int maVe, FormCollection collection)
        {
            try
            {
                DALConnect connect = new DALConnect();
                if (!connect.deleteThongTinVe(maVe))
                {
                    ViewBag.mess = "Xóa không thành công";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}