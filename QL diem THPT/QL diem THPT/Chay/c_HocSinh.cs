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
    public class c_HocSinh
    {
        cn_HocSinh cn = new cn_HocSinh();

        public DataTable hienthiHocSinh()
        {
            return cn.hienthiHocSinh();
        }

        public bool themHocSinh(HocSinh h)
        {
            return cn.themHocSinh(h);
        }

        public bool suaHocSinh(HocSinh h)
        {
            return cn.suaHocSinh(h);
        }

        public bool xoaHocSinh(HocSinh h)
        {
            return cn.xoaHocSinh(h);
        }
    }
}
