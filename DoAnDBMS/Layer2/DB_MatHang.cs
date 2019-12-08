using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Layer1;

namespace Layer2
{
    public class DB_MatHang
    {
        DAL db = null;
        public DB_MatHang()
        {
            db = new DAL();
        }
        // Lấy dữ liệu từ 1 bảng 
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from MatHang", CommandType.Text, null);
        }
        public DataSet MatHangChuaXai()
        {
            string query = string.Format("SELECT * FROM MH_ChuaXai();");
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        // Lấy dữ liệu từ 1 bảng mà dung index
        public DataSet MatHangtheoMaMH(string Ma_MH)
        {
            string query = string.Format("SELECT * FROM MatHangtheoMaMH('{0}');", Ma_MH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text,null );
        }
        // Tìm kiếm mặt hàng
        public DataSet TimMHtheoMaMH(string Ma_MH)
        {
            string query = string.Format("SELECT * FROM TimMHtheoMaMH('{0}');", Ma_MH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet TimMHtheoMaloaiMH(string Ma_loaiMH)
        {
            string query = string.Format("SELECT * FROM TimMHtheoMaloaiMH('{0}');", Ma_loaiMH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet TimMHtheoTenMH(string Ten_MH)
        {
            string query = string.Format("SELECT * FROM TimMHtheoTenMH('{0}');", Ten_MH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet TimMHtheoSoLuong(string SoLuong)
        {
            string query = string.Format("SELECT * FROM TimMHtheoSoLuong('{0}');", SoLuong);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet TimMHtheoGiaBan(string GiaBan)
        {
            string query = string.Format("SELECT * FROM TimMHtheoGiaBan('{0}');", GiaBan);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet TimMHtheoGiaNhap(string GiaNhap)
        {
            string query = string.Format("SELECT * FROM TimMHtheoGiaNhap('{0}');", GiaNhap);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        // Insert   Delete  Update
        public bool ThemMatHang(ref string err, string Ma_MH, string Ma_loaiMH, string Ten_MH, int SoLuong, float GiaNhap, float GiaBan, DateTime ThoiGianBaoHanh)
        {
            return db.MyExecuteNonQuery("SpThemMatHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_MH", Ma_MH),
                new SqlParameter("@Ma_loaiMH", Ma_loaiMH),
                new SqlParameter("@Ten_MH", Ten_MH),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@GiaNhap", GiaNhap),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@ThoiGianBaoHanh", ThoiGianBaoHanh)
                );
        }
        public bool CapNhatMatHang(ref string err, string Ma_MH, string Ma_loaiMH, string Ten_MH, int SoLuong, float GiaNhap, float GiaBan, DateTime ThoiGianBaoHanh)
        {
            return db.MyExecuteNonQuery("SpCapNhatMatHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_MH", Ma_MH),
                new SqlParameter("@Ma_loaiMH", Ma_loaiMH),
                new SqlParameter("@Ten_MH", Ten_MH),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@GiaNhap", GiaNhap),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@ThoiGianBaoHanh", ThoiGianBaoHanh)
                );
        }
        public bool XoaMatHang(ref string err, string Ma_MH)
        {
            return db.MyExecuteNonQuery("SpXoaMatHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_MH", Ma_MH));
        }
    }
}
