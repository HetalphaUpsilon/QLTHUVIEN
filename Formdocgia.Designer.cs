namespace WindowsFormsApplication1
{
    partial class Formdocgia
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comgioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttendocgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmadocgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.mADOCGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHUVIENDataSet = new WindowsFormsApplication1.QLTHUVIENDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.LblSoluong = new System.Windows.Forms.Label();
            this.dOCGIATableAdapter = new WindowsFormsApplication1.QLTHUVIENDataSetTableAdapters.DOCGIATableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comgioitinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.txtdienthoai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttendocgia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmadocgia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin";
            // 
            // comgioitinh
            // 
            this.comgioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comgioitinh.FormattingEnabled = true;
            this.comgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comgioitinh.Location = new System.Drawing.Point(583, 115);
            this.comgioitinh.Name = "comgioitinh";
            this.comgioitinh.Size = new System.Drawing.Size(78, 27);
            this.comgioitinh.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(456, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giới tính:";
            // 
            // luu
            // 
            this.luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luu.Enabled = false;
            this.luu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luu.Location = new System.Drawing.Point(510, 195);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(112, 41);
            this.luu.TabIndex = 41;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoat.Location = new System.Drawing.Point(642, 195);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(112, 41);
            this.thoat.TabIndex = 40;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.xoa.Location = new System.Drawing.Point(305, 195);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(112, 41);
            this.xoa.TabIndex = 39;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(161, 196);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(112, 39);
            this.sua.TabIndex = 38;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.them.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(15, 195);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(110, 39);
            this.them.TabIndex = 37;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // ngaysinh
            // 
            this.ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinh.Location = new System.Drawing.Point(583, 72);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(174, 26);
            this.ngaysinh.TabIndex = 7;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdienthoai.Location = new System.Drawing.Point(180, 133);
            this.txtdienthoai.MaxLength = 10;
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(237, 26);
            this.txtdienthoai.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(53, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(456, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // txttendocgia
            // 
            this.txttendocgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttendocgia.Location = new System.Drawing.Point(180, 90);
            this.txttendocgia.Name = "txttendocgia";
            this.txttendocgia.Size = new System.Drawing.Size(237, 26);
            this.txttendocgia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên:";
            // 
            // txtmadocgia
            // 
            this.txtmadocgia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmadocgia.Location = new System.Drawing.Point(180, 46);
            this.txtmadocgia.Name = "txtmadocgia";
            this.txtmadocgia.Size = new System.Drawing.Size(237, 26);
            this.txtmadocgia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(53, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "CẬP NHẬT THÔNG TIN ĐỘC GIẢ";
            // 
            // luoi
            // 
            this.luoi.AutoGenerateColumns = false;
            this.luoi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mADOCGIADataGridViewTextBoxColumn,
            this.hOTENDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.dIENTHOAIDataGridViewTextBoxColumn});
            this.luoi.DataSource = this.dOCGIABindingSource;
            this.luoi.Location = new System.Drawing.Point(12, 358);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(786, 213);
            this.luoi.TabIndex = 25;
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // mADOCGIADataGridViewTextBoxColumn
            // 
            this.mADOCGIADataGridViewTextBoxColumn.DataPropertyName = "MADOCGIA";
            this.mADOCGIADataGridViewTextBoxColumn.HeaderText = "Mã Độc Giả";
            this.mADOCGIADataGridViewTextBoxColumn.Name = "mADOCGIADataGridViewTextBoxColumn";
            this.mADOCGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTENDataGridViewTextBoxColumn
            // 
            this.hOTENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hOTENDataGridViewTextBoxColumn.DataPropertyName = "HOTEN";
            this.hOTENDataGridViewTextBoxColumn.HeaderText = "Họ và Tên";
            this.hOTENDataGridViewTextBoxColumn.Name = "hOTENDataGridViewTextBoxColumn";
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.Width = 150;
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            this.gIOITINHDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIENTHOAIDataGridViewTextBoxColumn
            // 
            this.dIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.dIENTHOAIDataGridViewTextBoxColumn.Name = "dIENTHOAIDataGridViewTextBoxColumn";
            this.dIENTHOAIDataGridViewTextBoxColumn.Width = 170;
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.qLTHUVIENDataSet;
            // 
            // qLTHUVIENDataSet
            // 
            this.qLTHUVIENDataSet.DataSetName = "QLTHUVIENDataSet";
            this.qLTHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Thông tin độc giả";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(460, 330);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 19);
            this.l.TabIndex = 27;
            // 
            // LblSoluong
            // 
            this.LblSoluong.AutoSize = true;
            this.LblSoluong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSoluong.Location = new System.Drawing.Point(330, 330);
            this.LblSoluong.Name = "LblSoluong";
            this.LblSoluong.Size = new System.Drawing.Size(125, 19);
            this.LblSoluong.TabIndex = 27;
            this.LblSoluong.Text = "Số lượng độc giả:";
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // Formdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(810, 583);
            this.Controls.Add(this.l);
            this.Controls.Add(this.LblSoluong);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Formdocgia";
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.Formdocgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comgioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttendocgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmadocgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label LblSoluong;
        private QLTHUVIENDataSet qLTHUVIENDataSet;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private QLTHUVIENDataSetTableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADOCGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
    }
}