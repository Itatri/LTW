using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn.Models;

namespace DoAn.Controllers
{
    public class SanPhamController : Controller
    {
        DTDDEntities dt = new DTDDEntities();
        public ActionResult SanPhamPartial()
        {
            var ListSanPham = dt.SanPhams.OrderBy(s => s.TenSP).ToList();
            return View(ListSanPham);
        }
        public ActionResult XemChiTiet(int ms)
        {
            var ChiTiet = dt.SanPhams.Single(t => t.MaSP == ms);
            if (ChiTiet == null)
                return HttpNotFound();
            return View(ChiTiet);
        }

    }
}