using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_diem_THPT.SQLObject
{
    class Lop
    {
        private string MALOP;
        private string TENLOP;
        private string MA_LT;
        private string MA_GVCN;
        private string MA_CHUYEN;
        private string MAKHOI;

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

        public string Tenlop
        {
            get
            {
                return TENLOP;
            }
            set
            {
                TENLOP = value;
            }
        }

        public string Malt
        {
            get
            {
                return MA_LT;
            }
            set
            {
                MA_LT = value;
            }
        }

        public string Magvcn
        {
            get
            {
                return MA_GVCN;
            }
            set
            {
                MA_GVCN = value;
            }
        }

        public string MAchuyen
        {
            get
            {
                return MA_CHUYEN;
            }
            set
            {
                MA_CHUYEN = value;
            }
        }

        public string Makhoi
        {
            get
            {
                return MAKHOI;
            }
            set
            {
                MAKHOI = value;
            }
        }

        public Lop() { }

        public Lop(string MaLop, string TenLop, string Ma_LT, string Ma_GVCN, string Ma_Chuyen, string MaKhoi)
        {
            this.MALOP = Malop;
            this.TENLOP = TenLop;
            this.MA_LT = Ma_LT;
            this.MA_GVCN = Ma_GVCN;
            this.MA_CHUYEN = Ma_Chuyen;
            this.MAKHOI = MaKhoi;
        }

    }
}
