﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_diem_THPT.Main
{
    public partial class frmHienThiTTHS : Form
    {
        public frmHienThiTTHS()
        {
            InitializeComponent();
        }

        private void btnThoatHTTT_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        
    }
}
