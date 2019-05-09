using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_diem_THPT.Chay;
using QL_diem_THPT.SQLObject;

namespace QL_diem_THPT.Main
{
    public partial class frmPhanCong : Form
    {
        c_PhanCong pc = new c_PhanCong();
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            dgvDSPhanCong.DataSource = pc.hienthiPhanCong();
        }
    }
}
