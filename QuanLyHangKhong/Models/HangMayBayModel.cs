using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Mã Hãng")]
        public int MaHang { get => maHang; set => maHang = value; }
        [Display(Name = "Tên hãng")]
        public string TenHang { get => tenHang; set => tenHang = value; }
        [Display(Name = "Địa chỉ hoạt động")]
        public string DiaChi { get => diaChi; set => diaChi = value; }
        [Display(Name = "Thời gian thành lập")]
        public DateTime ThoiGianThanhLap { get => thoiGianThanhLap; set => thoiGianThanhLap = value; }
        [Display(Name = "Email")]
        public string Email { get => email; set => email = value; }
    }
}