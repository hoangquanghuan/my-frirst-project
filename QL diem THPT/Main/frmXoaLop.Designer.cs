﻿namespace QL_diem_THPT.Main
{
    partial class frmXoaLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtXoaMaLop = new System.Windows.Forms.TextBox();
            this.labMaHS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoaLop);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 317);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(433, 252);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 46);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLop.Location = new System.Drawing.Point(192, 252);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(163, 46);
            this.btnXoaLop.TabIndex = 9;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtXoaMaLop);
            this.panel2.Controls.Add(this.labMaHS);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 199);
            this.panel2.TabIndex = 8;
            // 
            // txtXoaMaLop
            // 
            this.txtXoaMaLop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtXoaMaLop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXoaMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXoaMaLop.Location = new System.Drawing.Point(319, 98);
            this.txtXoaMaLop.Multiline = true;
            this.txtXoaMaLop.Name = "txtXoaMaLop";
            this.txtXoaMaLop.Size = new System.Drawing.Size(375, 39);
            this.txtXoaMaLop.TabIndex = 23;
            // 
            // labMaHS
            // 
            this.labMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaHS.Location = new System.Drawing.Point(135, 98);
            this.labMaHS.Name = "labMaHS";
            this.labMaHS.Size = new System.Drawing.Size(130, 39);
            this.labMaHS.TabIndex = 22;
            this.labMaHS.Text = "Mã lớp";
            this.labMaHS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người dùng cần nhập mã lớp để xóa thông tin của lớp đó đó";
            // 
            // frmXoaLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 339);
            this.Controls.Add(this.panel1);
            this.Name = "frmXoaLop";
            this.Text = "Xóa Lớp";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtXoaMaLop;
        private System.Windows.Forms.Label labMaHS;
        private System.Windows.Forms.Label label1;
    }
}