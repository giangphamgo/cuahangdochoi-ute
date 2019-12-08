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
    public class DB_ChiTietBanHang
    {
        DAL db = null;
        public DB_ChiTietBanHang()
        {
            db = new DAL();
        }
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from ChiTiet_BanHang", CommandType.Text, null);
        }
        public DataSet ChitietTheoMaHD(string Ma_HDBH)
        {
            string query = string.Format("SELECT * FROM ChitietTheoMaHD('{0}');", Ma_HDBH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet ChitietTheoMaHDvsMaHD(string Ma_HDBH, string Ma_MH)
        {
            string query = string.Format("SELECT * FROM ChitietTheoMaHDvsMaHD('{0}','{1}');", Ma_HDBH, Ma_MH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public bool ThemChiTiet_BanHang(ref string err, string Ma_HDBH, string Ma_MH, int SoLuong)
        {
            return db.MyExecuteNonQuery("spThemChiTietBanHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_HDBH", Ma_HDBH),
                new SqlParameter("@Ma_MH", Ma_MH),
                new SqlParameter("@SoLuong", SoLuong)
                );
        }
        public bool CapNhatChiTiet_BanHang(ref string err, string Ma_HDBH, string Ma_MH, int SoLuong)
        {
            return db.MyExecuteNonQuery("spCapNhatChiTietBanHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_HDBH", Ma_HDBH),
                new SqlParameter("@Ma_MH", Ma_MH),
                new SqlParameter("@SoLuong", SoLuong)
                );
        }
        public bool XoaChiTiet_BanHang(ref string err, string Ma_HDBH, string Ma_MH)
        {
            return db.MyExecuteNonQuery("spXoaChiTietBanHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_HDBH", Ma_HDBH),
                new SqlParameter("@Ma_MH", Ma_MH));
        }
    }
}
