using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QL_diem_THPT.ConnectSQL
{
    class CSDL_QLHS_GV
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2RT7I3F;Initial Catalog=QL_HSGV_THPT;Integrated Security=True");
    }
}
