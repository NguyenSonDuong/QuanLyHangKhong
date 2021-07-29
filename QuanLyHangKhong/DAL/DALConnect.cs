using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyHangKhong.Models;

namespace QuanLyHangKhong.DAL
{
    public class DALConnect
    {
        protected string connectionString;
        protected SqlConnection cnn;
        public void Connect()
        {
            connectionString = @"Data Source=DESKTOP-ANUAD36\SQLEXPRESS;Initial Catalog=QuanLyHangKhong;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        public List<HangMayBayModel> getAllHangMB()
        {
            Connect();
            List<HangMayBayModel> hangMayBays = new List<HangMayBayModel>();
            String sql = "SELECT * FROM hangmaybay";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                hangMayBays.Add(new HangMayBayModel(data.GetInt32(0), data.GetString(1), data.GetString(2), data.GetDateTime(3), data.GetString(4)));
            }
            return hangMayBays;
        }
        public List<DatVeModel> getAllDatVe()
        {
            Connect();
            List<DatVeModel> datVe = new List<DatVeModel>();
            String sql = "SELECT * FROM datvehoadon";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                datVe.Add(new DatVeModel(data.GetInt32(0), data.GetInt32(1), data.GetString(2), data.GetString(3), data.GetString(4)));
            }
            return datVe;
        }
        public List<ThongTinVeModel> getAllThongTinVe()
        {
            Connect();
            List<ThongTinVeModel> thongTinVe = new List<ThongTinVeModel>();
            String sql = "SELECT * FROM thongTinVe";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                thongTinVe.Add(new ThongTinVeModel(data.GetInt32(0), data.GetString(1), data.GetFloat(2), data.GetDateTime(3), data.GetString(4), data.GetString(5), data.GetInt32(6), data.GetInt32(7)));
            }
            return thongTinVe;
        }
        public HangMayBayModel GetHangMayBay(int maHang)
        {
            HangMayBayModel hangMayBay = null;
            Connect();
            String sql = "SELECT * FROM hangmaybay WHERE maHang = '" + maHang + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                hangMayBay = new HangMayBayModel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));
            }
            cnn.Close();
            return hangMayBay;
        }
        public Boolean updateHangMayBay(HangMayBayModel hangMB)
        {
            Connect();
            string sql = "UPDATE hangmaybay SET tenHang = '" + hangMB.TenHang
                + "', dichi = '" + hangMB.DiaChi + "', thoigianthanhlap = '" + hangMB.ThoiGianThanhLap
                + "', email = '" + hangMB.Email + "' WHERE maHang = '" + hangMB.MaHang + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertHangMayBay(HangMayBayModel hangMB)
        {
            Connect();
            string sql = "INSERT INTO hangmaybay (tenHang, diachi, thoigianthanhlap, email) VALUES ('" + hangMB.TenHang + "', '" + hangMB.DiaChi + "', '" + hangMB.ThoiGianThanhLap + "', '" + hangMB.Email + "')";
            Connect();
            
            try
            {
                SqlCommand cmm = new SqlCommand(sql, cnn);
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean deleteHMB(int maHang)
        {
            Connect();
            string sql = "DELETE FROM hangmaybay WHERE maHang = '" + maHang + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DatVeModel GetDatVe(int maHoaDon)
        {
            DatVeModel datVe = null;
            Connect();
            String sql = "SELECT * FROM datvehoadon WHERE maHoaDon = '" + maHoaDon + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                datVe = new DatVeModel(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            cnn.Close();
            return datVe;
        }
        public Boolean updateDV(DatVeModel hdDatVe)
        {
            Connect();
            string sql = "UPDATE datvehoadon SET maVe = '" + hdDatVe.MaVe
                + "', tenkhachhang = '" + hdDatVe.TenKH + "', mahochieu = '" + hdDatVe.MaHoChieu
                + "', sodienthoai = '" + hdDatVe.Sdt + "' WHERE maHoaDon = '" + hdDatVe.MaHD + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertDV(DatVeModel hdDatVe)
        {
            Connect();
            //int id = GetALLDV()[GetALLDV().Count - 1].ID + 1;
            string sql = "INSERT INTO datvehoadon (maVe, tenkhachhang, mahochieu, sodienthoai) VALUES ('" + hdDatVe.MaVe + "', '" + hdDatVe.TenKH
                + "', '" + hdDatVe.MaHoChieu + "', '" 
                + "', '" + hdDatVe.Sdt + "')";
            Connect();
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean deleteDV(int maHD)
        {
            Connect();
            string sql = "DELETE datvehoadon DatVe WHERE maHoaDon = '" + maHD + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public ThongTinVeModel getthongtinve(int maVe)
        {
            ThongTinVeModel hangmaybay = null;
            Connect();
            string sql = "select * from thongTinVe where maVe = '" + maVe + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            SqlDataReader reader = cmm.ExecuteReader();
            while (reader.Read())
            {
                hangmaybay = new ThongTinVeModel(reader.GetInt32(0), reader.GetString(1), reader.GetFloat(2), reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7));
            }
            cnn.Close();
            return hangmaybay;
        }
        public Boolean updateTTV(ThongTinVeModel thongTinVe)
        {
            Connect();
            string sql = "UPDATE thongTinVe SET loaive = '" + thongTinVe.LoaiVe
                + "', giave = '" + thongTinVe.GiaVe + "', ngaydi = '" + thongTinVe.NgayDi
                + "', noidi = '" + thongTinVe.NoiDi + "', noiden = '" + thongTinVe.NoiDen + "', thoigianbay = '" + thongTinVe.ThoiGianBay
                + "', maHang = '" + thongTinVe.MaHang + "' WHERE maVe = '" + thongTinVe.MaVe + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean insertTTV(ThongTinVeModel thongTinVe)
        {
            Connect();
            //int id = GetALLTTV()[GetALLTTV().Count - 1].ID + 1;
            string sql = "INSERT INTO thongTinVe (loaive, giave, ngaydi, noidi, noiden, thoigianbay, maHang) VALUES ('" + thongTinVe.LoaiVe + "', '" + thongTinVe.GiaVe + "', '" + thongTinVe.NgayDi + "', '" + thongTinVe.NoiDi + "', '" + thongTinVe.NoiDen + "', '" + thongTinVe.ThoiGianBay + "', '" + thongTinVe.MaHang + "')";
            Connect();
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean deleteThongTinVe(int maVe)
        {
            Connect();
            string sql = "DELETE FROM thongTinVe WHERE maVe = '" + maVe + "'";
            SqlCommand cmm = new SqlCommand(sql, cnn);
            try
            {
                cmm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}