using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyHangKhong.Models
{
    public class DatVeModel
    {
        int maHD;
        int maVe;
        string tenKH;
        string maHoChieu;
        string sdt;

        public DatVeModel()
        {

        }

        public DatVeModel(int maVe, string tenKH, string maHoChieu, string sdt)
        {
            this.maVe = maVe;
            this.tenKH = tenKH;
            this.maHoChieu = maHoChieu;
            this.sdt = sdt;
        }

        public DatVeModel(int maHD, int maVe, string tenKH,  string maHoChieu, string sdt)
        {
            this.maHD = maHD;
            this.maVe = maVe;
            this.tenKH = tenKH;
            this.maHoChieu = maHoChieu;
            this.sdt = sdt;
        }
        [Display(Name = "Mã hóa đơn vé")]
        public int MaHD
        {
            get
            {
                return maHD;
            }

            set
            {
                maHD = value;
            }
        }

        [Display(Name = "Mã vé")]
        public int MaVe
        {
            get
            {
                return maVe;
            }

            set
            {
                maVe = value;
            }
        }

        [Display(Name = "Tên khách hàng")]
        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }
        [Display(Name = "Số hộ chiếu")]
        public string MaHoChieu
        {
            get
            {
                return maHoChieu;
            }

            set
            {
                maHoChieu = value;
            }
        }
        [Display(Name = "Số điện thoại")]
        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }
    }
}