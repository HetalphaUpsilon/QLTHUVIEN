namespace WindowsFormsApplication1
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.dannhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.LblThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(165, 102);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(151, 20);
            this.taikhoan.TabIndex = 3;
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(165, 150);
            this.matkhau.Name = "matkhau";
            this.matkhau.PasswordChar = '*';
            this.matkhau.Size = new System.Drawing.Size(151, 20);
            this.matkhau.TabIndex = 4;
            // 
            // dannhap
            // 
            this.dannhap.Location = new System.Drawing.Point(165, 216);
            this.dannhap.Name = "dannhap";
            this.dannhap.Size = new System.Drawing.Size(75, 23);
            this.dannhap.TabIndex = 5;
            this.dannhap.Text = "Đăng nhập";
            this.dannhap.UseVisualStyleBackColor = true;
            this.dannhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(308, 216);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // LblThongBao
            // 
            this.LblThongBao.AutoSize = true;
            this.LblThongBao.ForeColor = System.Drawing.Color.Red;
            this.LblThongBao.Location = new System.Drawing.Point(162, 187);
            this.LblThongBao.Name = "LblThongBao";
            this.LblThongBao.Size = new System.Drawing.Size(0, 13);
            this.LblThongBao.TabIndex = 7;
            // 
            // dangnhap
            // 
            this.AcceptButton = this.dannhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this.LblThongBao);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dannhap);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Button dannhap;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label LblThongBao;
    }
}

