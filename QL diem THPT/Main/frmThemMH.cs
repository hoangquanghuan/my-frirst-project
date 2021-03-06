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
    public partial class frmThemMH : Form
    {
        c_MonHoc cmh = new c_MonHoc();
        public frmThemMH()
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


        
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if(txtMaMH.Text != "" && txtTenMH.Text != "")
            {
                MonHoc mh = new MonHoc(txtMaMH.Text, txtTenMH.Text);
                if (cmh.themMonHoc(mh))
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
    }
}
