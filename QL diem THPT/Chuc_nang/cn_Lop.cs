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
    class cn_Lop: ConnectSQL.CSDL_QLHS_GV
    {
        public DataTable hienthiLop()
        {
            conn.Open();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT H.MAHS, TENLOP, HOHS, TENHS, NS, GT, DC, SDT, HOTEN_BO, NN_BO, HOTEN_ME, NN_ME FROM HOCSINH H,LOP L, CHITIET_LOP C WHERE H.MAHS = C.MAHS AND C.MALOP = L.MALOP", conn);

            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM LOP", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);// đổ dữ liệu từ sql vào
            conn.Close();
            return dt;
        }

        string SQL;
        public bool themLop(Lop l)
        {
            try
            {
                conn.Open();

                SQL = "insert into LOP values('" + l.Malop + "', N'" + l.Tenlop + "', '" + l.Malt + "', '" + l.Magvcn +
                    "', '" + l.MAchuyen + "', '" + l.Makhoi + "')";

                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool suaLop(Lop l)
        {
            try
            {
                conn.Open();

                SQL = "update LOP set MALOP ='" + l.Malop + "', TENLOP = N'" + l.Tenlop + "', MA_LT = '" + l.Malt + "', MA_GVCN ='" + l.Magvcn +
                    "', MA_CHUYEN = '" + l.MAchuyen + "', MAKHOI ='" + l.Makhoi + "')";

                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool xoaLop(Lop l)
        {
            try
            {
                conn.Open();

                SQL = "delete from LOP where MALOP = '" + l.Malop + "'";

                SqlCommand cmd = new SqlCommand(SQL, conn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq > 0)
                    return true;

            }
            catch { }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
