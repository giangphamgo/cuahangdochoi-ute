using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Layer1;
using System.Data;
namespace Layer2
{
   public class DB_LoaiMatHang
    {
        DAL db = null;
       
        public DB_LoaiMatHang()
        {
            db = new DAL();
        }
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from Loai_MatHang", CommandType.Text, null);
        }
        public bool ThemLoaiMatHang(ref string err, string Ma_loaiMH, string Ten_loaiMH)
        {
            return db.MyExecuteNonQuery("SpThemLoaiMatHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_loaiMH", Ma_loaiMH),
                new SqlParameter("@Ten_loaiMH", Ten_loaiMH)
                );
        }
        public bool CapNhatLoaiMatHang(ref string err, string Ma_loaiMH, string Ten_loaiMH)
        {
            return db.MyExecuteNonQuery("SpCapNhatLoaiMatHang", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_loaiMH", Ma_loaiMH),
                new SqlParameter("@Ten_loaiMH", Ten_loaiMH)
                );
        }
        public bool XoaLoaiMatHang(ref string err, string Ma_loaiMH)
        {
            return db.MyExecuteNonQuery("SpXoaLoaiMatHang", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_loaiMH", Ma_loaiMH));
        }
    }
}
