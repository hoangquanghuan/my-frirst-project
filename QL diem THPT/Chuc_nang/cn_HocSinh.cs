using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QL_diem_THPT.SQLObject;
using System.Windows.Forms;

namespace QL_diem_THPT.Chuc_nang
{
    class cn_HocSinh:ConnectSQL.CSDL_QLHS_GV
    {

        public DataTable hienthiHocSinh()
        {
            conn.Open();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT H.MAHS, TENLOP, HOHS, TENHS, NS, GT, DC, SDT, HOTEN_BO, NN_BO, HOTEN_ME, NN_ME FROM HOCSINH H,LOP L, CHITIET_LOP C WHERE H.MAHS = C.MAHS AND C.MALOP = L.MALOP", conn);

            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM HOCSINH", conn);
            DataTable dt = new DataTable();
            
            da.Fill(dt);// đổ dữ liệu từ sql vào
            conn.Close();
            return dt;
        }


        string SQL;
        public bool themHocSinh(HocSinh h)
        {
            try
            {
                conn.Open();
               
                SQL = "insert into HOCSINH values('" + h.Mahs + "', N'" + h.Hohs + "', N'" + h.Tenhs + "', '" + h.Ns +
                    "', N'" + h.Gt+ "', N'" + h.Dc + "', '" + h.Sdt + "', N'" + h.htBo + "', N'" + h.nnBo + "', N'" + h.htMe + 
                    "', N'" + h.nnMe+ "')";

                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;
           }
           catch
            {
                
            }
           finally
           {
               conn.Close();
           }
            return false;
        }

        public bool suaHocSinh(HocSinh h)
        {
            try
            {
                conn.Open();
                SQL = "update HOCSINH set HOHS = N'" + h.Hohs + "', TENHS = N'" + h.Tenhs + "', NS = '" + h.Ns + "', GT = N'" + h.Gt + "', DC = N'" + h.Dc + "', SDT = '" +
                    h.Sdt + "', HOTEN_BO = N'" + h.htBo + "', NN_BO = N'" + h.nnBo + "', HOTEN_ME = N'" + h.htMe + "', NN_ME = N'" + h.nnMe + "' where MAHS = '" + h.Mahs + "'";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaHocSinh(HocSinh h)
        {
            try
            {
                conn.Open();
                SQL = "delete from HOCSINH where MAHS = '" + h.Mahs + "'";
                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
