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
    public partial class frmThemHS : Form
    {

        c_HocSinh chs = new c_HocSinh();
        public frmThemHS()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoatThem_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text != "" && txtHoHS.Text != "" && txtTenHS.Text != ""
                && txtHTBo.Text != "" && txtHTMe.Text != "" && txtDC.Text != "" && txtSDT.Text != "")
            {
                HocSinh hs = new HocSinh(txtMaHS.Text, txtHoHS.Text, txtTenHS.Text, dtpNS.Value,
                    cbbGT.Text, txtDC.Text, txtSDT.Text, txtHTBo.Text, txtNNBo.Text, txtHTMe.Text, txtNNMe.Text);
                if (chs.themHocSinh(hs))
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
                MessageBox.Show("xin vui lòng nhập đủ thông tin");
            }

            
        }

        private void frmThemHS_Load(object sender, EventArgs e)
        {

        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
