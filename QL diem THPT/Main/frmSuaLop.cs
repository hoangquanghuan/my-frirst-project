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
    public partial class frmSuaLop : Form
    {
        c_Lop cl = new c_Lop();
        public frmSuaLop()
        {
            InitializeComponent();
        }

        private void btnThoatThem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "")
            {
                if (txtTenLop.Text != "" && txtMaLT.Text != ""
                && txtMaGVCN.Text != "" && cbbMaChuyen.Text != "" && cbbMaKhoi.Text != "" )
                {
                    Lop l = new Lop(txtMaLop.Text, txtTenLop.Text, txtMaLT.Text,
                        txtMaGVCN.Text, cbbMaChuyen.Text, cbbMaKhoi.Text);
                    if (cl.suaLop(l))
                    {
                        MessageBox.Show("sửa thành công");
                        frmMain f = new frmMain();
                        this.Hide();
                        f.ShowDialog();
                        f.Close();
                    }
                    else
                    {
                        MessageBox.Show("sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("xin vui lòng nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("xin vui lòng nhập mã lớp để sủa thông tin");
            }
        }

        private void frmSuaLop_Load(object sender, EventArgs e)
        {

        }
    }
}
