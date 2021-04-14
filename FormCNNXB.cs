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
    public partial class Formnhaxb : Form
    {
        public Formnhaxb()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from nhaxb");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã nhà XB";
            luoi.Columns[1].HeaderText = "Tên nhà XB";
            luoi.Columns[2].HeaderText = "Địa chỉ";
            luoi.Columns[3].HeaderText = "Điện thoại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void Formnhaxb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet1.NHAXB' table. You can move, or remove it, as needed.
            //this.nHAXBTableAdapter.Fill(this.qLTHUVIENDataSet1.NHAXB);
            loaddata();

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmanhaxb.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttennhaxb.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = luoi.CurrentRow.Cells[3].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmanhaxb.Text = "";
            txttennhaxb.Text = "";
            txtdiachi.Text = "";
            txtDienthoai.Text = "";
            luu.Enabled = true;
            xoa.Enabled = false;
            sua.Text = "Hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(txtDienthoai.Text, out int Result);
            int dai = txtDienthoai.Text.Length;
            if (txtmanhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã nhà xuất bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanhaxb.Focus();

            }
            else if (txttennhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên nhà xuất bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhaxb.Focus();


            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();


            }
            else if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienthoai.Focus();


            }
            else if (check == false || dai < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienthoai.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO nhaxb VALUES (N'" + txtmanhaxb.Text + "',N'" + txttennhaxb.Text + "',N'" + txtdiachi.Text + "',N'" + txtDienthoai.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();


            }
            else
            {
                MessageBox.Show("Trùng Mã nhà xuất bản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(txtDienthoai.Text, out int Result);
            int dai = txtDienthoai.Text.Length;
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


                if (txttennhaxb.Text == "")
                {
                    MessageBox.Show("Nhà xuất bản chưa có thông tin","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txttennhaxb.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdiachi.Focus();


                }
                else if (check == false || dai < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDienthoai.Focus();
                }
                else if (t.thucthidulieu("update  nhaxb set tennxb=N'" + txttennhaxb.Text + "', diachi=N'" + txtdiachi.Text + "', dienthoai='" + txtDienthoai.Text + "'where manxb=N'" + txtmanhaxb.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa NXB có mã " + txtmanhaxb.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from nhaxb where manxb='" + txtmanhaxb.Text + "'")==true)
                        MessageBox.Show("Xóa thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void Formnhaxb_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Formchinh f = new Formchinh();
            f.Show();
        }
    }
}
