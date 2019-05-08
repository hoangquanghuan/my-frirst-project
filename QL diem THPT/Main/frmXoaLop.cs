using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_diem_THPT.SQLObject;
using QL_diem_THPT.Chay;

namespace QL_diem_THPT.Main
{
    public partial class frmXoaLop : Form
    {
        c_Lop cl = new c_Lop();
        public frmXoaLop()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (txtXoaMaLop.Text != "")
            {
                Lop l = new Lop(txtXoaMaLop.Text, null, null, null, null, null);
                if (cl.xoaLop(l))
                {
                    MessageBox.Show("xóa thành công");
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    f.Close();
                }
                else
                {
                    MessageBox.Show("xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("xin vui lòng nhập đầy đủ mã học sinh cần xóa");
            }
        }
    }
}
