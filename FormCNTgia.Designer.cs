namespace WindowsFormsApplication1
{
    partial class Formtacgia
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
            this.txttentacgia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatacgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.mATACGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENTACGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTHUVIENDataSet2 = new WindowsFormsApplication1.QLTHUVIENDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tACGIATableAdapter = new WindowsFormsApplication1.QLTHUVIENDataSet2TableAdapters.TACGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.DarkSalmon;
            this.luu.CausesValidation = false;
            this.luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luu.Enabled = false;
            this.luu.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.luu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.luu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luu.Location = new System.Drawing.Point(394, 289);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(66, 24);
            this.luu.TabIndex = 21;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.DarkSalmon;
            this.thoat.CausesValidation = false;
            this.thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thoat.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.thoat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.thoat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoat.Location = new System.Drawing.Point(394, 323);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(66, 24);
            this.thoat.TabIndex = 20;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.DarkSalmon;
            this.xoa.CausesValidation = false;
            this.xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xoa.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.xoa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(394, 232);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(66, 24);
            this.xoa.TabIndex = 19;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.DarkSalmon;
            this.sua.CausesValidation = false;
            this.sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sua.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.sua.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(394, 194);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(66, 24);
            this.sua.TabIndex = 18;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.DarkSalmon;
            this.them.CausesValidation = false;
            this.them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.them.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.them.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(394, 158);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(66, 24);
            this.them.TabIndex = 17;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // txttentacgia
            // 
            this.txttentacgia.Location = new System.Drawing.Point(130, 110);
            this.txttentacgia.Name = "txttentacgia";
            this.txttentacgia.Size = new System.Drawing.Size(244, 20);
            this.txttentacgia.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ và tên";
            // 
            // txtmatacgia
            // 
            this.txtmatacgia.Location = new System.Drawing.Point(130, 66);
            this.txtmatacgia.Name = "txtmatacgia";
            this.txtmatacgia.Size = new System.Drawing.Size(73, 20);
            this.txtmatacgia.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã tác giả";
            // 
            // luoi
            // 
            this.luoi.AutoGenerateColumns = false;
            this.luoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATACGIADataGridViewTextBoxColumn,
            this.tENTACGIADataGridViewTextBoxColumn});
            this.luoi.DataSource = this.tACGIABindingSource;
            this.luoi.Location = new System.Drawing.Point(17, 158);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(357, 189);
            this.luoi.TabIndex = 11;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // mATACGIADataGridViewTextBoxColumn
            // 
            this.mATACGIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mATACGIADataGridViewTextBoxColumn.DataPropertyName = "MATACGIA";
            this.mATACGIADataGridViewTextBoxColumn.HeaderText = "Mã Tác Giả";
            this.mATACGIADataGridViewTextBoxColumn.Name = "mATACGIADataGridViewTextBoxColumn";
            // 
            // tENTACGIADataGridViewTextBoxColumn
            // 
            this.tENTACGIADataGridViewTextBoxColumn.DataPropertyName = "TENTACGIA";
            this.tENTACGIADataGridViewTextBoxColumn.HeaderText = "Tên Tác Giả";
            this.tENTACGIADataGridViewTextBoxColumn.Name = "tENTACGIADataGridViewTextBoxColumn";
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.qLTHUVIENDataSet2;
            // 
            // qLTHUVIENDataSet2
            // 
            this.qLTHUVIENDataSet2.DataSetName = "QLTHUVIENDataSet2";
            this.qLTHUVIENDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(130, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "CẬP NHẬT TÁC GIẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources._1428theme_anh_sang_danh_cho_dien_thoai;
            this.label1.Location = new System.Drawing.Point(17, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "CẬP NHẬT THỂ LOẠI SÁCH";
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // Formtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(476, 370);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txttentacgia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmatacgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luoi);
            this.MaximizeBox = false;
            this.Name = "Formtacgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Tác Giả";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTHUVIENDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox txttentacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmatacgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Label label4;
        private QLTHUVIENDataSet2 qLTHUVIENDataSet2;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private QLTHUVIENDataSet2TableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATACGIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENTACGIADataGridViewTextBoxColumn;
    }
}