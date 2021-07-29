using System;
using System.Collections.Generic;
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