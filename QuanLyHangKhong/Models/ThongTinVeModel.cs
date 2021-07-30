using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyHangKhong.Models
{
    public class ThongTinVeModel
    {
        int maVe;
        string loaiVe;
        float giaVe;
        DateTime ngayDi;
        string noiDi;
        string noiDen;
        int thoiGianBay;
        int maHang;


        public ThongTinVeModel(string loaiVe, float giaVe, DateTime ngayDi, string noiDi, string noiDen, int thoiGianBay, int maHang)
        {
            this.loaiVe = loaiVe;
            this.giaVe = giaVe;
            this.ngayDi = ngayDi;
            this.noiDi = noiDi;
            this.noiDen = noiDen;
            this.thoiGianBay = thoiGianBay;
            this.maHang = maHang;
        }


        public ThongTinVeModel(int maVe, string loaiVe,  float giaVe, DateTime ngayDi, string noiDi, string noiDen, int thoiGianBay, int maHang)
        {
            this.maVe = maVe;
            this.loaiVe = loaiVe;
            this.giaVe = giaVe;
            this.ngayDi = ngayDi;
            this.noiDi = noiDi;
            this.noiDen = noiDen;
            this.thoiGianBay = thoiGianBay;
            this.maHang = maHang;
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

        public string LoaiVe
        {
            get
            {
                return loaiVe;
            }

            set
            {
                loaiVe = value;
            }
        }

        public float GiaVe
        {
            get
            {
                return giaVe;
            }

            set
            {
                giaVe = value;
            }
        }

        public DateTime NgayDi
        {
            get
            {
                return ngayDi;
            }

            set
            {
                ngayDi = value;
            }
        }

        public string NoiDi
        {
            get
            {
                return noiDi;
            }

            set
            {
                noiDi = value;
            }
        }

        public string NoiDen
        {
            get
            {
                return noiDen;
            }

            set
            {
                noiDen = value;
            }
        }

        public int ThoiGianBay
        {
            get
            {
                return thoiGianBay;
            }

            set
            {
                thoiGianBay = value;
            }
        }

        public int MaHang
        {
            get
            {
                return maHang;
            }

            set
            {
                maHang = value;
            }
        }
    }
}