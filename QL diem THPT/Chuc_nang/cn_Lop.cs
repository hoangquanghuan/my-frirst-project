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
            SqlDataAdapter da = new SqlDataAdapter("SELECT MALOP as 'Mã Lớp', TENLOP as 'Tên Lớp Học', HOHS+' '+TENHS as 'Họ Tên Lớp Trưởng', HOGV+' '+TENGV as 'Họ Tên GVCN', TENKHOI as 'Khối', TEN_CHUYEN as 'Chuyên' FROM LOP L, HOCSINH H, CHUYEN C, KHOI K, GIAOVIEN G WHERE L.MA_LOP_TR = H.MAHS AND L.MA_GVCN = G.MAGV AND L.MAKHOI = K.MAKHOI AND L.MA_CHUYEN = C.MA_CHUYEN", conn);
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
