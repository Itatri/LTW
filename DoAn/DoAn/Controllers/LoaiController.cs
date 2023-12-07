using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn.Models;

namespace DoAn.Controllers
{
    public class LoaiController : Controller
    {
        DTDDEntities dt = new DTDDEntities();
        public ActionResult LoaiPartial()
        {
            return View(dt.Loais.Take(5).ToList());
        }

        public ActionResult DienThoaiPartial()
        {
            var tk = dt.Loais.Where(t => t.Note == "DT").ToList();
            return View(tk);
        }

        public ActionResult LapTopPartial( )
        {
            var tk = dt.Loais.Where(t => t.Note == "Lap").ToList();
            return View(tk);
        }

        public ActionResult PhuKienPartial()
        {
            var tk = dt.Loais.Where(t => t.Note == "PK").ToList();
            return View(tk);
        }

        public ActionResult SPTheoLoai(int maLoai)
        {
            var tk = dt.SanPhams.Where(s => s.MaLoai == maLoai).ToList();
            if (tk.Count == 0)
            {
                ViewBag.TB = "Không có sản phẩm thuộc loại này";
            }
            return View(tk);
        }
    }
}