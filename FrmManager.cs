using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup03_63KTPM2_Version01
{
    public partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }

       

        private void label38_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void nv_chonanh_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Thiết lập các thuộc tính cho hộp thoại Open File Dialog
            openFileDialog1.Title = "Chọn ảnh";
            openFileDialog1.Filter = "Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tập tin ảnh
                string imagePath = openFileDialog1.FileName;

                // Đặt nội dung của PictureBox bằng đường dẫn tập tin ảnh
                //nv_pic.ImageLocation = imagePath;
                pbFrmAgent_picture.Image = Image.FromFile(imagePath);
            }
        }

        private void nv_bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường bắt buộc
                if (tbFrmAgent_email.Text == "" || tbFrmAgent_name.Text == "" || tbFrmAgent_cccd.Text == "" || tbFrmAgent_phone.Text == "" || cbFrmAgent_nativeland.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                // Lấy dữ liệu từ các control trên form đưa vào dtgDSSV
                string gtcheck = "";
                if (rbFrmAgent_boy.Checked == true)
                    gtcheck = "Nam";
                else if (rbFrmAgent_girl.Checked == true)
                    gtcheck = "Nữ";
                dtgvFrmAgent.Rows.Add(tbFrmAgent_name.Text, gtcheck, dtpFrmAgent_date.Value, cbFrmAgent_nativeland.Text, tbFrmAgent_cccd.Text, tbFrmAgent_phone.Text, tbFrmAgent_email.Text);

                // Xóa thông tin vừa thêm
                tbFrmAgent_name.Clear();
                cbFrmAgent_nativeland.Text = "";
                gtcheck = "";
                tbFrmAgent_phone.Text = "";
                tbFrmAgent_cccd.Text = "";
                tbFrmAgent_email.Text = "";
                rbFrmAgent_boy.Checked = false;
                rbFrmAgent_girl.Checked = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nv_tb_hoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
