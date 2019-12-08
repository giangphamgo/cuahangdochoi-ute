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
    public class DB_KhachHang
    {
        DAL db = null;
        public DB_KhachHang()
        {
            db = new DAL();
        }
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from KhachHang", CommandType.Text, null);
        }
        public DataSet KhachHangtheoMaKH(string Ma_KH)
        {
            string query = string.Format("SELECT * FROM KhachHangtheoMaKH('{0}');", Ma_KH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet KhachHangchuaxai()
        {
            string query = string.Format("SELECT * FROM KH_ChuaXai();");
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public bool ThemKhachHang(ref string err, string Ma_KH, string Ten_KH, string DiaChi, string DienThoai, string Email)
        {
            return db.MyExecuteNonQuery("SpThemKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_KH", Ma_KH),
                new SqlParameter("@Ten_KH", Ten_KH),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Email", Email)
                );
        }
        public bool CapNhatKhachHang(ref string err, string Ma_KH, string Ten_KH, string DiaChi, string DienThoai, string Email)
        {
            return db.MyExecuteNonQuery("SpCapNhatKhachHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_KH", Ma_KH),
                new SqlParameter("@Ten_KH", Ten_KH),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@DienThoai", DienThoai),
                new SqlParameter("@Email", Email)
                );
        }
        public bool XoaKhachHang(ref string err, string Ma_KH)
        {
            return db.MyExecuteNonQuery("SpXoaKhachHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_KH", Ma_KH));
        }
    }
}
