using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyHangKhong.Models
{
    public class HangMayBayModel
    {
        int maHang;
        string tenHang;
        string diaChi;
        DateTime thoiGianThanhLap;
        string email;

        public HangMayBayModel(int maHang, string tenHang, string diaChi, DateTime thoiGianThanhLap, string email)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.diaChi = diaChi;
            this.thoiGianThanhLap = thoiGianThanhLap;
            this.email = email;
        }
        public HangMayBayModel(string tenHang, string diaChi, DateTime thoiGianThanhLap, string email)
        {
            this.tenHang = tenHang;
            this.diaChi = diaChi;
            this.thoiGianThanhLap = thoiGianThanhLap;
            this.email = email;
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

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public DateTime ThoiGianThanhLap
        {
            get
            {
                return thoiGianThanhLap;
            }

            set
            {
                thoiGianThanhLap = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}