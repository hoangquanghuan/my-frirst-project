using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_diem_THPT.SQLObject;
using QL_diem_THPT.Chuc_nang;
using System.Data;

namespace QL_diem_THPT.Chay
{
    class c_Lop
    {
        cn_Lop cn = new cn_Lop();
        public DataTable hienthiLop()
        {
            return cn.hienthiLop();
        }

        public bool themLop(Lop l)
        {
            return cn.themLop(l);
        }

        public bool suaLop(Lop l)
        {
            return cn.suaLop(l);
        }

        public bool xoaLop(Lop l)
        {
            return cn.xoaLop(l);
        }
    }
}
