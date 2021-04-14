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
    public partial class Formcapnhatsach : Form
    {
        public Formcapnhatsach()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            //DataTable dt = t.docdulieu("select * from sach");
            DataTable dt = t.docdulieu("select sa.masach, sa.tensach, sa.namxb, xb.tennxb, tl.tentheloai, tg.tentacgia from sach sa, nhaxb xb, theloai tl, tacgia tg where sa.manxb = xb.manxb and sa.matheloai = tl.matheloai and sa.matacgia = tg.matacgia");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách ";
            luoi.Columns[0].Width = 80;
            luoi.Columns[3].Width = 180;


            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Năm xuất bản";
            luoi.Columns[3].HeaderText = "Nhà xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            luoi.Columns[5].HeaderText = "Tác giả";
            //luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;
            loadcombo();
        }
        private void loadcombo() {
            DataTable dt = t.docdulieu("select * from nhaxb");
            DataTable dt1 = t.docdulieu("select * from theloai");
            DataTable dt2 = t.docdulieu("select * from tacgia");

           
                comnhaxb.DataSource = dt;
                comnhaxb.DisplayMember = "tennxb";
                comnhaxb.ValueMember = "manxb";
                //comnhaxb.ValueMember = "tennxb";

                //comnhaxb.ValueMember = "manxb";
                comtheloai.DataSource = dt1;
                comtheloai.DisplayMember = "tentheloai";
                comtheloai.ValueMember = "matheloai";
                //comtheloai.ValueMember = "tentheloai";

                commatacgia.DataSource = dt2;
                commatacgia.DisplayMember = "tentacgia";
                commatacgia.ValueMember = "matacgia";
                //commatacgia.ValueMember = "tentacgia";
        }

        private void Formcapnhatsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTHUVIENDataSet4.SACH' table. You can move, or remove it, as needed.
            //this.sACHTableAdapter.Fill(this.qLTHUVIENDataSet4.SACH);
            loaddata();

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmasach.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttensach.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txtnamxb.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comnhaxb.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            comtheloai.Text = luoi.CurrentRow.Cells[4].Value.ToString();
            commatacgia.Text = luoi.CurrentRow.Cells[5].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txttensach.Text = "";
            txtnamxb.Text = "";
         
            luu.Enabled = true;
            xoa.Enabled = false;
            sua.Text = "Hủy";
            them.Enabled = false;
            luoi.Enabled = false;
            loadcombo();

        }

        private void luu_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(txtnamxb.Text, out int Result);

            if (txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtmasach.Focus();

            }
            else if (txttensach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txttensach.Focus();


            }
            else if (txtnamxb.Text == "")
            {
                MessageBox.Show("Chưa nhập năm xuất bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnamxb.Focus();


            }
            else if (check == false)
            {
                MessageBox.Show("Năm đã nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnamxb.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO SACH VALUES(N'" + txtmasach.Text + "', N'" + txttensach.Text + "', '" + int.Parse(txtnamxb.Text) + "', N'" + comnhaxb.SelectedValue.ToString() + "', N'" + comtheloai.SelectedValue.ToString() + "', N'" + commatacgia.SelectedValue.ToString() + "')") == true)
            {

                MessageBox.Show("Thêm thành công","Chúc mừng",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loaddata();


            }
            else MessageBox.Show("Lỗi rồi! Kiểm tra mã sách","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txtnamxb_Enter(object sender, EventArgs e)
        {
            /*bool check = int.TryParse(txtnamxb.Text, out int Result);
            if (check == false)
                MessageBox.Show("Năm đã nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
        }

        private void sua_Click(object sender, EventArgs e)
        {
            bool check = int.TryParse(txtnamxb.Text, out int Result);

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
                txtmasach.Enabled = false;


                if (txttensach.Text == "")
                {
                    txttensach.Focus();

                }
                else if (txtnamxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtnamxb.Focus();

                    // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                }
                else if (check == false)
                {
                    MessageBox.Show("Năm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnamxb.Focus();
                }
                else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + int.Parse(txtnamxb.Text) + "', manxb=N'" + comnhaxb.SelectedValue.ToString() + "', matheloai=N'" + comtheloai.SelectedValue.ToString() + "', matacgia=N'" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                //else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.Text + "', matacgia='" + commatacgia.Text + "'where masach=N'" + txtmasach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công", "Chúc mừng", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loaddata();
                    txtmasach.Enabled = true;

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            txtmasach.Enabled = true;
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txtmasach.Text + "", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from sach where masach='" + txtmasach.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from sach where masach like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from sach where tensach like N'%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                luoi.DataSource = dt5;
            }
            else luoi.DataSource = dt6;
        }

        private void Formcapnhatsach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Formchinh f = new Formchinh();
            f.Show();
        }
    }
}
