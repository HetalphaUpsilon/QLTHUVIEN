using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class theloaisach : Form
    {
        public theloaisach()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from theloai");
           
            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã thể loại";
            luoi.Columns[1].HeaderText = "Tên thể loại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells); 
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void nhaxuatban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet3.THELOAI' table. You can move, or remove it, as needed.
            //this.tHELOAITableAdapter.Fill(this.qLTHUVIENDataSet3.THELOAI);
            loaddata();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmatheloai.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttentheloai.Text = luoi.CurrentRow.Cells[1].Value.ToString();

        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmatheloai.Text = "";
            txttentheloai.Text = "";
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "Hủy";
            them.Enabled = false;
            luoi.Enabled = false;

        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (sua.Text == "Hủy")
            {
                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
               loaddata();
               luoi.Enabled = true;


            }
            else
            {
                ///them.Enabled = false;
               /// sua.Text = "Cập nhật";
                ///xoa.Text = "hủy";

                if (txtmatheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmatheloai.Focus();

                }
                else if (txttentheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên thể loại","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttentheloai.Focus();


                }
                else if (t.thucthidulieu("update  theloai set tentheloai=N'" + txttentheloai.Text + "'where matheloai=N'" + txtmatheloai.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công","Chúc mừng",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            }

        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (txtmatheloai.Text=="")
            {
                MessageBox.Show("Chưa nhập mã thể loại","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatheloai.Focus();

            }else if (txttentheloai.Text=="")
            {
                MessageBox.Show("Chưa nhập tên thể loại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentheloai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO theloai VALUES ('" + txtmatheloai.Text + "', N'" + txttentheloai.Text+ "')") == true)
            {

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();


            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        


        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (xoa.Text == "Hủy") {

                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
                loaddata();
                luoi.Enabled = true;




            }
            else {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa thể loại có mã " + txtmatheloai.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes) {
                    try
                    {

                        t.thucthidulieu("delete from theloai where matheloai='" + txtmatheloai.Text+"'");
                        MessageBox.Show("Xóa thành Công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                else  loaddata(); 
            
            
            
            
            
            }
            
            
            
            }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void theloaisach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Formchinh f = new Formchinh();
            f.Show();          
        }
    }
}

