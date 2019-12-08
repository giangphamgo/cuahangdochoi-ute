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
    public class DB_NhanVien
    {
        DAL db = null;
        public DB_NhanVien()
        {
            db = new DAL();
        }
        public DataSet GetDaTa()
        {

            return db.ExcuteQuerryDataSet("select * from NhanVien", CommandType.Text, null);
        }
        public DataSet LayNV()
        {
            return db.ExcuteQuerryDataSet("Select * from LayNV();", CommandType.Text, null);
        }
        public DataSet NhanVienChuaXai()
        {
            string query = string.Format("SELECT * FROM NV_ChuaXai();");
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet NhanVientheoMaNV(string Ma_NV)
        {
            string query = string.Format("SELECT * FROM NhanVientheoMaNV('{0}');", Ma_NV);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public bool ThemNhanVien(ref string err, string Ma_NV, string Ten_NV, string Cmnd, string DienThoai, DateTime Ngay_lamviec,float Luong)
        {
            return db.MyExecuteNonQuery("SpThemNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_NV", Ma_NV),
                new SqlParameter("@Ten_NV", Ten_NV),
                new SqlParameter("@Cmnd", Cmnd),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Ngay_lamviec", Ngay_lamviec),
                new SqlParameter("@Luong", Luong)
                );
        }
        public bool CapNhapNhanVien(ref string err, string Ma_NV, string Ten_NV, string Cmnd, string DienThoai, DateTime Ngay_lamviec, float Luong)
        {
            return db.MyExecuteNonQuery("SpCapNhatNhanVien", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_NV", Ma_NV),
                new SqlParameter("@Ten_NV", Ten_NV),
                new SqlParameter("@Cmnd", Cmnd),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Ngay_lamviec", Ngay_lamviec),
                new SqlParameter("@Luong", Luong)
                );
        }
        public bool XoaNhanVien(ref string err, string Ma_NV)
        {
            return db.MyExecuteNonQuery("SpXoaNhanVien", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_NV", Ma_NV));
        }
    }
}
