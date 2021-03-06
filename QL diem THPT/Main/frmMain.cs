﻿using System;
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
    public partial class frmMain : Form
    {

        c_HocSinh ch = new c_HocSinh();
        c_MonHoc mh = new c_MonHoc();
        c_GiaoVien gv = new c_GiaoVien();
        c_Lop l = new c_Lop();
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvDShocsinh.DataSource = ch.hienthiHocSinh();
            dgvDSMonHoc.DataSource = mh.hienthiMonHoc();
            dgvDSGiaoVien.DataSource = gv.hienthiGiaoVien();
            dgvDSLop.DataSource = l.hienthiLop();
        }

        private void dgvDShocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDShocsinh.CurrentRow.Index;
            frmThemHS f = new frmThemHS();
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            frmThemHS f = new frmThemHS();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmSuaHS f = new frmSuaHS();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            frmXoaHS f = new frmXoaHS();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoatMain_Click_1(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void labHienThiTTHS_Click(object sender, EventArgs e)
        {
            frmTimKiemHS f = new frmTimKiemHS();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            frmThemGV f = new frmThemGV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            frmSuaGV f = new frmSuaGV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            frmXoaGV f = new frmXoaGV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            frmThemLop f = new frmThemLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSualop_Click(object sender, EventArgs e)
        {
            frmSuaLop f = new frmSuaLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            frmXoaLop f = new frmXoaLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            frmThemMH f = new frmThemMH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            frmSuaMH f = new frmSuaMH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            frmXoaMH f = new frmXoaMH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnThoatMain_Click_2(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            ptb1.Image = QL_diem_THPT.Properties.Resources.books_521812297;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ptb2.Image = QL_diem_THPT.Properties.Resources.truong;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmPhanCong f = new frmPhanCong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
