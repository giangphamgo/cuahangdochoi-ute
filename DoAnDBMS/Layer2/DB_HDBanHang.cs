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
    public class DB_HDBanHang
    {
        DAL db = null;
        public DB_HDBanHang()
        {
            db = new DAL();
        }
        public DataSet HoaDonTheoMaHD(string Ma_HDBH)
        {
            string query = string.Format("SELECT * FROM HoaDonTheoMaHD('{0}');", Ma_HDBH);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet Func_HoaDoncuaNhanVien(string MaNV)
        {
            string query = string.Format("SELECT * FROM Func_HoaDoncuaNhanVien('{0}');", MaNV);
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from HD_BanHang", CommandType.Text, null);
        }
        public bool ThemHD_BanHang(ref string err, string Ma_HDBH, string Ma_NV, string Ma_KH, float TongTien, DateTime NgayXuatHD)
        {
            return db.MyExecuteNonQuery("spThemHoaDonBanHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_HDBH", Ma_HDBH),
                new SqlParameter("@Ma_NV", Ma_NV),
                new SqlParameter("@Ma_KH", Ma_KH),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@NgayXuatHD", NgayXuatHD)
                );
        }
        public bool CapNhatHD_BanHang(ref string err, string Ma_HDBH, string Ma_NV, string Ma_KH, float TongTien, DateTime NgayXuatHD)
        {
            return db.MyExecuteNonQuery("spCapNhatHoaDonBanHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_HDBH", Ma_HDBH),
                new SqlParameter("@Ma_NV", Ma_NV),
                new SqlParameter("@Ma_KH", Ma_KH),
                new SqlParameter("@TongTien", TongTien),
                new SqlParameter("@NgayXuatHD", NgayXuatHD)
                );
        }
        public bool XoaHD_BanHang(ref string err, string Ma_HDBH)
        {
            return db.MyExecuteNonQuery("spXoaHoaDonBanHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_HDBH", Ma_HDBH));
        }

        public DataSet HoaDonChuaXai()
        {
            string query = string.Format("SELECT * FROM HD_ChuaXai();");
            return db.ExcuteQuerryDataSet(query, CommandType.Text, null);
        }
    }
}
