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
    class cn_PhanCong : ConnectSQL.CSDL_QLHS_GV
    {
        public DataTable hienthiPhanCong()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT HOGV+' '+TENGV as 'Họ Tên GV', TENLOP as 'Tên Lớp' FROM GIAOVIEN G, LOP L, PHAN_CONG P WHERE G.MAGV=P.MAGV AND P.MALOP=L.MALOP", conn);
            DataTable dt = new DataTable();

            da.Fill(dt);// đổ dữ liệu từ sql vào
            conn.Close();
            return dt;
        }
    }
}
