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
    public class DB_HDNhapHang
    {
            DAL db = null;
            public DB_HDNhapHang()
            {
                db = new DAL();
            }
            public DataSet GetDaTa()
            {
                return db.ExcuteQuerryDataSet("select * from HD_NhapHang", CommandType.Text, null);
            }
            public bool ThemHD_NhapHang(ref string err, string Ma_HDNH, string Ma_NV, string Ma_NPP, float TongTien, DateTime NgayXuatHD)
            {
                return db.MyExecuteNonQuery("SpThemHD_NhapHang", CommandType.StoredProcedure, ref err,
                    new SqlParameter("@Ma_HDNH", Ma_HDNH),
                    new SqlParameter("@Ma_NV", Ma_NV),
                    new SqlParameter("@Ma_NPP", Ma_NPP),
                    new SqlParameter("@TongTien", TongTien),
                    new SqlParameter("@NgayXuatHD", NgayXuatHD)
                    );
            }
            public bool CapNhatHD_NhapHang(ref string err, string Ma_HDNH, string Ma_NV, string Ma_NPP, float TongTien, DateTime NgayXuatHD)
            {
                return db.MyExecuteNonQuery("SpCapNhatHD_NhapHang", CommandType.StoredProcedure, ref err,
                    new SqlParameter("@Ma_HDNH", Ma_HDNH),
                    new SqlParameter("@Ma_NV", Ma_NV),
                    new SqlParameter("@Ma_NPP", Ma_NPP),
                    new SqlParameter("@TongTien", TongTien),
                    new SqlParameter("@NgayXuatHD", NgayXuatHD)
                    );
            }
            public bool XoaHD_NhapHang(ref string err, string Ma_HDNH)
            {
                return db.MyExecuteNonQuery("SpXoaHD_NhapHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_HDNH", Ma_HDNH));
            }
        }
}
