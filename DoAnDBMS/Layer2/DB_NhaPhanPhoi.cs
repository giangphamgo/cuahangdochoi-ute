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
    public class DB_NhaPhanPhoi
    {
        DAL db = null;
        public DB_NhaPhanPhoi()
        {
            db = new DAL();
        }
        public DataSet GetDaTa()
        {
            return db.ExcuteQuerryDataSet("select * from NhaPhanPhoi", CommandType.Text, null);
        }
        public bool ThemNhaPhanPhoi(ref string err, string Ma_NPP, string Ten_NPP, string DiaChi, string Email)
        {
            return db.MyExecuteNonQuery("SpThemNhaPhanPhoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_NPP", Ma_NPP),
                new SqlParameter("@Ten_NPP", Ten_NPP),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email)
                );
        }
        public bool CapNhatNhaPhanPhoi(ref string err, string Ma_NPP, string Ten_NPP, string DiaChi, string Email)
        {
            return db.MyExecuteNonQuery("SpCapNhatNhaPhanPhoi", CommandType.StoredProcedure, ref err,
                new SqlParameter("@Ma_NPP", Ma_NPP),
                new SqlParameter("@Ten_NPP", Ten_NPP),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email)
                );
        }
        public bool XoaNhaPhanPhoi(ref string err, string Ma_NPP)
        {
            return db.MyExecuteNonQuery("SpXoaNhaPhanPhoi", CommandType.StoredProcedure, ref err, new SqlParameter("@Ma_NPP", Ma_NPP));
        }
    }
}
