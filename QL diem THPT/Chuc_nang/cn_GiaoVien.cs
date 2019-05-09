using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QL_diem_THPT.SQLObject;

namespace QL_diem_THPT.Chuc_nang
{
    class cn_GiaoVien : ConnectSQL.CSDL_QLHS_GV
    {
        
        public DataTable hienthiGiaoVien()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAGV as 'Mã Giáo Viên', HOGV+' '+TENGV as 'Họ Tên Giáo Viên', NS as 'Ngày Sinh', GT as 'Giáo Viên', DC as 'Địa Chỉ', SDT as 'Số Điện Thoại', TEN_MON as 'Môn Giảng Dạy' FROM GIAOVIEN, MONHOC WHERE GIAOVIEN.MAMONHOC=MONHOC.MAMONHOC", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);// đổ dữ liệu từ sql vào
            conn.Close();
            return dt;
        }
        string SQL;
        public bool themGiaoVien(GiaoVien g)
        {
            try
            {
                conn.Open();
                SQL = "insert into GIAOVIEN values ('" + g.maGV + "', N'" + g.hoGV + "', N'" + g.tenGV + "', '" + g.Ns + "', N'" + g.Gt + "', N'"
                    + g.Dc + "', '" + g.Sdt + "', '" + g.Mamh + "')";
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

        public bool suaGiaoVien(GiaoVien g)
        {
            try
            {
                conn.Open();
                SQL = "update GIAOVIEN set HOGV = N'" + g.hoGV + "', TENGV = N'" + g.tenGV + "', NS = '" + g.Ns + "', GT = N'" + g.Gt + "', DC = N'" + g.Dc + "', SDT = '" +
                    g.Sdt + "', MAMONHOC = N'" + g.Mamh + "' where MAGV = '" + g.maGV + "'";
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


        public bool xoaGiaoVien(GiaoVien g)
        {
            try
            {
                conn.Open();
                SQL = "delete from GIAOVIEN where MAGV = '" + g.maGV + "'";
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
