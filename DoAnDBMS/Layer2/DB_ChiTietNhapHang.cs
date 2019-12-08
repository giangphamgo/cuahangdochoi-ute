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
    public class DB_ChiTietNhapHang
    {
        DAL db = null;
        public DB_ChiTietNhapHang()
        {
            db = new DAL();
        }
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from ChiTiet_NhapHang", CommandType.Text, null);
        }
        public bool ThemChiTiet_NhapHang(ref string err, string Ma_CTNH, string Ma_HDNH, string Ma_MH, int SoLuong)
        {
            return db.MyExecuteNonQuery("SpThemChiTiet_NhapHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_CTNH", Ma_CTNH),
                new SqlParameter("@Ma_HDNH", Ma_HDNH),
                new SqlParameter("@Ma_MH", Ma_MH),
                new SqlParameter("@SoLuong", SoLuong)
                );
        }
        public bool CapNhatChiTiet_NhapHang(ref string err, string Ma_CTNH, string Ma_HDNH, string Ma_MH, int SoLuong)
        {
            return db.MyExecuteNonQuery("SpCapNhatChiTiet_NhapHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_CTNH", Ma_CTNH),
                new SqlParameter("@Ma_HDNH", Ma_HDNH),
                new SqlParameter("@Ma_MH", Ma_MH),
                new SqlParameter("@SoLuong", SoLuong)
                );
        }
        public bool XoaChiTiet_NhapHang(ref string err, string Ma_CTNH)
        {
            return db.MyExecuteNonQuery("SpXoaChiTiet_NhapHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_CTNH", Ma_CTNH));
        }
    }
}
