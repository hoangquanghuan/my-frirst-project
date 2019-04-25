using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_diem_THPT.SQLObject
{
    class MonHoc
    {
        private string MaMH;
        private string TenMH;

        public string maMH
        {
            get
            {
                return MaMH;
            }
            set
            {
                MaMH = value;
            }
        }

        public string tenMH
        {
            get
            {
                return TenMH;
            }
            set
            {
                TenMH = value;
            }
        }

        public MonHoc() { }

        public MonHoc(string mamh, string tenmh)
        {
            this.MaMH = mamh;
            this.TenMH = tenmh;
        }
    }
}
