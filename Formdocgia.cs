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
    public partial class Formdocgia : Form
    {
        public Formdocgia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void Formdocgia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet.DOCGIA' table. You can move, or remove it, as needed.
            //this.dOCGIATableAdapter.Fill(this.qLTHUVIENDataSet.DOCGIA);
            loaddata();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }
        private void loaddata()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            DataTable dt = t.docdulieu("select * from docgia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Họ và tên";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Điện thoại";
            


            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmadocgia.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtdienthoai.Text = luoi.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txttendocgia.Text = "";
            txtdienthoai.Text = "";
            ngaysinh.Value = DateTime.Now;
           
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "Hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            bool check = int.TryParse(txtdienthoai.Text, out int Result);
            int dai = txtdienthoai.Text.Length;
            if (txtmadocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtmadocgia.Focus();

            }
            else if (txttendocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên độc giả", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendocgia.Focus();


            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdienthoai.Focus();


            }
            else if (check == false || dai < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdienthoai.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO docgia VALUES (N'" + txtmadocgia.Text + "',N'" + txttendocgia.Text + "','" + ngayhh + "',N'" + comgioitinh.Text + "','" + txtdienthoai.Text +"')") == true)
            {

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();


            }
            else
            {
                MessageBox.Show("Trùng mã độc giả","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);



                txtmadocgia.Focus();

            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            bool check = int.TryParse(txtdienthoai.Text, out int Result);
            int dai = txtdienthoai.Text.Length;
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

                if (txttendocgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên độc giả","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txttendocgia.Focus();

                }
                else if (txtdienthoai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdienthoai.Focus();


                }
                else if (check == false || dai < 10)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdienthoai.Focus();
                }
                else if (t.thucthidulieu("update  docgia set hoten=N'" + txttendocgia.Text + "', ngaysinh='" + ngayhh + "', gioitinh=N'" + comgioitinh.Text + "', dienthoai='" + txtdienthoai.Text + "'where madocgia='" + txtmadocgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);


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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã " + txtmadocgia.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from docgia where madocgia='" + txtmadocgia.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Lỗi! Không thể xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


                
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
    }
}
