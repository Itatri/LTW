using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn.Models
{
    public class GioHang : Controller
    {
        DTDDEntities dt = new DTDDEntities();
        public int iMaSP { get; set; }
        public string sTenSP { get; set; }
        public string sAnh { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double dThanhTien
        {
            get { return iSoLuong * dDonGia; }
        }

        public GioHang(int MaSP)
        {
            iMaSP = MaSP;
            SanPham sp = dt.SanPhams.Single(s => s.MaSP == iMaSP);
            sTenSP = sp.TenSP;
            sAnh = sp.Anh   ;
            dDonGia = double.Parse(sp.GiaBan.ToString());
            iSoLuong = 1;
        }
    }

}