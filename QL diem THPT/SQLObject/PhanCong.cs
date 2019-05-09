using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_diem_THPT.SQLObject
{
    class PhanCong
    {
        private string MAGV;
        private string MALOP;
        private int TG;

        public string Magv
        {
            get
            {
                return MAGV;
            }
            set
            {
                MAGV = value;
            }
        }

        public string Malop
        {
            get
            {
                return MALOP;
            }
            set
            {
                MALOP = value;
            }
        }

        public int Tg
        {
            get
            {
                return TG;
            }
            set
            {
                TG = value;
            }
        }

        public PhanCong() { }

        public PhanCong(string magv, string malop, int tg)
        {
            this.MAGV = magv;
            this.MALOP = malop;
            this.TG = tg;
        }

    }
}
