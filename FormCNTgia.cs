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
    public partial class Formtacgia : Form
    {
        public Formtacgia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tacgia");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã tác giả";
            luoi.Columns[1].HeaderText = "Tên tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells); 
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet2.TACGIA' table. You can move, or remove it, as needed.
            //this.tACGIATableAdapter.Fill(this.qLTHUVIENDataSet2.TACGIA);
            loaddata();

        }
        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmatacgia.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttentacgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();

        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmatacgia.Text = "";
            txttentacgia.Text = "";
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
               

                if (txtmatacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã tác giả","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtmatacgia.Focus();

                }
                else if (txttentacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttentacgia.Focus();


                }
                else if (t.thucthidulieu("update  tacgia set tentacgia=N'" + txttentacgia.Text + "'where matacgia=N'" + txtmatacgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (xoa.Text == "Hủy")
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa tác giả có mã " + txtmatacgia.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                       if ( t.thucthidulieu("delete from tacgia where matacgia='" + txtmatacgia.Text + "'")==true)
                        MessageBox.Show("Xóa thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       else MessageBox.Show("Không thể xóa", "Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (txtmatacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã tác giả", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatacgia.Focus();

            }
            else if (txttentacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tác giả", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentacgia.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO tacgia VALUES (N'" + txtmatacgia.Text + "', N'" + txttentacgia.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loaddata();


            }
            else MessageBox.Show("Lỗi rồi!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Formtacgia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Formchinh f = new Formchinh();
            f.Show();
        }
    }
}
