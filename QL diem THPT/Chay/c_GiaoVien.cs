using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_diem_THPT.SQLObject;
using QL_diem_THPT.Chuc_nang;

namespace QL_diem_THPT.Chay
{
    class c_GiaoVien
    {
        cn_GiaoVien gv = new cn_GiaoVien();

        public DataTable hienthiGiaoVien()
        {
            return gv.hienthiGiaoVien();
        }

        public bool themGiaoVien(GiaoVien g)
        {
            return gv.themGiaoVien(g);
        }

        public bool suaGiaoVien(GiaoVien g)
        {
            return gv.suaGiaoVien(g);
        }


        public bool xoaGiaoVien(GiaoVien g)
        {
            return gv.xoaGiaoVien(g);
        }
    }
}
