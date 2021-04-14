namespace WindowsFormsApplication1
{
    partial class Formnhaxb
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
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.txttennhaxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmanhaxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.mANXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNXBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHAXBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHUVIENDataSet1 = new WindowsFormsApplication1.QLTHUVIENDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.nHAXBTableAdapter = new WindowsFormsApplication1.QLTHUVIENDataSet1TableAdapters.NHAXBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu.Location = new System.Drawing.Point(408, 415);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(86, 36);
            this.luu.TabIndex = 31;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(513, 415);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(86, 36);
            this.thoat.TabIndex = 30;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(271, 415);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(86, 36);
            this.xoa.TabIndex = 29;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(164, 415);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(86, 36);
            this.sua.TabIndex = 28;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(59, 415);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(86, 36);
            this.them.TabIndex = 27;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txttennhaxb
            // 
            this.txttennhaxb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhaxb.Location = new System.Drawing.Point(162, 128);
            this.txttennhaxb.Name = "txttennhaxb";
            this.txttennhaxb.Size = new System.Drawing.Size(145, 26);
            this.txttennhaxb.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên nhà XB";
            // 
            // txtmanhaxb
            // 
            this.txtmanhaxb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhaxb.Location = new System.Drawing.Point(162, 77);
            this.txtmanhaxb.Name = "txtmanhaxb";
            this.txtmanhaxb.Size = new System.Drawing.Size(145, 26);
            this.txtmanhaxb.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã nhà XB";
            // 
            // luoi
            // 
            this.luoi.AutoGenerateColumns = false;
            this.luoi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANXBDataGridViewTextBoxColumn,
            this.tENNXBDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.dIENTHOAIDataGridViewTextBoxColumn});
            this.luoi.DataSource = this.nHAXBBindingSource;
            this.luoi.Location = new System.Drawing.Point(62, 178);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(537, 217);
            this.luoi.TabIndex = 22;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // mANXBDataGridViewTextBoxColumn
            // 
            this.mANXBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mANXBDataGridViewTextBoxColumn.DataPropertyName = "MANXB";
            this.mANXBDataGridViewTextBoxColumn.HeaderText = "Mã NXB";
            this.mANXBDataGridViewTextBoxColumn.Name = "mANXBDataGridViewTextBoxColumn";
            // 
            // tENNXBDataGridViewTextBoxColumn
            // 
            this.tENNXBDataGridViewTextBoxColumn.DataPropertyName = "TENNXB";
            this.tENNXBDataGridViewTextBoxColumn.HeaderText = "Tên NXB";
            this.tENNXBDataGridViewTextBoxColumn.Name = "tENNXBDataGridViewTextBoxColumn";
            this.tENNXBDataGridViewTextBoxColumn.Width = 150;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 150;
            // 
            // dIENTHOAIDataGridViewTextBoxColumn
            // 
            this.dIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.dIENTHOAIDataGridViewTextBoxColumn.Name = "dIENTHOAIDataGridViewTextBoxColumn";
            // 
            // nHAXBBindingSource
            // 
            this.nHAXBBindingSource.DataMember = "NHAXB";
            this.nHAXBBindingSource.DataSource = this.qLTHUVIENDataSet1;
            // 
            // qLTHUVIENDataSet1
            // 
            this.qLTHUVIENDataSet1.DataSetName = "QLTHUVIENDataSet1";
            this.qLTHUVIENDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "CẬP NHẬT NHÀ XUẤT BẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Địa chỉ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(420, 132);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(179, 26);
            this.txtdiachi.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Điện thoại";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienthoai.Location = new System.Drawing.Point(420, 77);
            this.txtDienthoai.MaxLength = 10;
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(179, 26);
            this.txtDienthoai.TabIndex = 26;
            // 
            // nHAXBTableAdapter
            // 
            this.nHAXBTableAdapter.ClearBeforeFill = true;
            // 
            // Formnhaxb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(658, 476);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttennhaxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmanhaxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.luoi);
            this.MaximizeBox = false;
            this.Name = "Formnhaxb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.Formnhaxb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txttennhaxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmanhaxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienthoai;
        private QLTHUVIENDataSet1 qLTHUVIENDataSet1;
        private System.Windows.Forms.BindingSource nHAXBBindingSource;
        private QLTHUVIENDataSet1TableAdapters.NHAXBTableAdapter nHAXBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNXBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
    }
}