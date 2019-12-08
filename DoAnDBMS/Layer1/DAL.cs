using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Layer1
{
    //Data Access Layer
    public class DAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataAdapter adp = null;
        //DataSource sẽ đổi
        string Stringcnn;
        public DAL()
        {
            //Stringcnn = "Server =192.168.174.1;User ID=" + ID + "; Password=" + Pass + "; Initial Catalog=QuanLyCuaHangDoChoi;Integrated Security=True;";
            Stringcnn = "Server="+Logins.Wifi+";Database=QuanLyCuaHangDoChoi;User Id=" + Logins.ID+";Password = " + Logins.Pass + ";";
           // Stringcnn = "Server=192.168.174.1;Database=QuanLyCuaHangDoChoi;User Id=test;Password = test;";
            cnn = new SqlConnection(Stringcnn);
            cmd = cnn.CreateCommand();
        }
        public DataSet ExcuteQuerryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {

            //Nếu Connection đang mở=>Đóng
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            //Mở Connection
            cnn.Open();
            cmd.CommandType = ct;
            cmd.CommandText = strSQL;
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            cmd.Parameters.Clear();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            foreach (SqlParameter p in param)
                cmd.Parameters.Add(p);
            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
                
            }
            finally
            {
                cnn.Close();
            }
            return f;
        }
    }
    
}
