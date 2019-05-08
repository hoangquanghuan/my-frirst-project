namespace QL_diem_THPT.Main
{
    partial class frmThemMH
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnThoatThem = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnThoatThem);
            this.panel1.Controls.Add(this.btnThemMH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 357);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtMaMH);
            this.panel2.Controls.Add(this.txtTenMH);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Location = new System.Drawing.Point(56, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 161);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Môn học:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(186, 25);
            this.txtMaMH.Multiline = true;
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(239, 32);
            this.txtMaMH.TabIndex = 52;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenMH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(186, 94);
            this.txtTenMH.Multiline = true;
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(239, 32);
            this.txtTenMH.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(40, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 23);
            this.label21.TabIndex = 50;
            this.label21.Text = "Mã môn học";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(40, 103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 23);
            this.label20.TabIndex = 49;
            this.label20.Text = "Tên môn học";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoatThem
            // 
            this.btnThoatThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatThem.Location = new System.Drawing.Point(363, 286);
            this.btnThoatThem.Name = "btnThoatThem";
            this.btnThoatThem.Size = new System.Drawing.Size(163, 46);
            this.btnThoatThem.TabIndex = 11;
            this.btnThoatThem.Text = "Thoát";
            this.btnThoatThem.UseVisualStyleBackColor = true;
            this.btnThoatThem.Click += new System.EventHandler(this.btnThoatThem_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.Location = new System.Drawing.Point(56, 286);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(163, 46);
            this.btnThemMH.TabIndex = 10;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // frmThemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 381);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemMH";
            this.Text = "Thêm Môn Học";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnThoatThem;
        private System.Windows.Forms.Button btnThemMH;
    }
}