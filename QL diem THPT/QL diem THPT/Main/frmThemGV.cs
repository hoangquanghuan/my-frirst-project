﻿using System;
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
    public partial class frmThemGV : Form
    {
        c_GiaoVien cgv = new c_GiaoVien();
        public frmThemGV()
        {
            InitializeComponent();
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text != "" && txtHoGV.Text != "" && txtTenGV.Text != ""
                && txtDC.Text != "" && txtSDT.Text != "")
            {
                if(txtMaMH.Text != "")
                {
                    GiaoVien g = new GiaoVien(txtMaGV.Text, txtHoGV.Text, txtTenGV.Text, dtpNS.Value,
                        cbbGT.Text, txtDC.Text, txtSDT.Text,txtMaMH.Text);
                    if (cgv.themGiaoVien(g))
                    {
                        MessageBox.Show("thêm thành công");
                        frmMain f = new frmMain();
                        this.Hide();
                        f.ShowDialog();
                        f.Close();
                    }
                    else
                    {
                        MessageBox.Show("thêm không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("xin vui lòng nhập môn học mà giáo viên đó sẽ giảng dạy");
                }
            }
            else
            {
                MessageBox.Show("xin vui lòng nhập đủ thông tin của giáo viên");
            }
        }

        private void btnThoatThem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
