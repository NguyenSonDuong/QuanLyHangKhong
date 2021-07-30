using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyHangKhong.Models
{
    public class HangMayBayModel
    {
        private int maHang;
        private string tenHang;
        private string diaChi;
        private DateTime thoiGianThanhLap;
        private string email;
        public HangMayBayModel(string tenHang, string diaChi, DateTime thoiGianThanhLap, string email)
        {
            this.TenHang = tenHang;
            this.DiaChi = diaChi;
            this.ThoiGianThanhLap = thoiGianThanhLap;
            this.Email = email;
        }
        public HangMayBayModel()
        {

        }
        public HangMayBayModel(int maHang, string tenHang, string diaChi, DateTime thoiGianThanhLap, string email)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.DiaChi = diaChi;
            this.ThoiGianThanhLap = thoiGianThanhLap;
            this.Email = email;
        }

        public int MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime ThoiGianThanhLap { get => thoiGianThanhLap; set => thoiGianThanhLap = value; }
        public string Email { get => email; set => email = value; }
    }
}