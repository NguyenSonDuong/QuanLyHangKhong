using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public ThongTinVeModel()
        {

        }
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
        [Display(Name = "Loại vé")]
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
        [Display(Name = "Giá vé")]
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
        [Display(Name = "Ngày đi")]
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
        [Display(Name = "Nơi đi")]
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
        [Display(Name = "Nơi đến")]
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
        [Display(Name = "Thời gian bay (Tiếng)")]
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
        [Display(Name = "Mã hãng máy bay")]
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