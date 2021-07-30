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
        DALConnect connect = new DALConnect();
        public ActionResult Index()
        {
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
        public ActionResult Edit(int maVe)
        {
            ThongTinVeModel thongTinVeModel = connect.getthongtinve(maVe);
            return View(thongTinVeModel);
        }

        // POST: ThongTinVe/Edit/5
        [HttpPost]
        public ActionResult Edit(ThongTinVeModel thongTinV)
        {
            try
            {
                if (connect.updateTTV(thongTinV))
                {
                    return RedirectToAction("Index");
                }
                ViewBag.mess = "Update không thành công";
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ThongTinVe/Delete/5
        public ActionResult Delete(int maVe)
        {
            ThongTinVeModel tTin = connect.getthongtinve(maVe);
            return View(tTin);

        }

        // POST: ThongTinVe/Delete/5
        [HttpPost]
        public ActionResult Delete(int maVe, FormCollection collection)
        {
            try
            {
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