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
    public partial class FrmDialogEditDish : Form
    {
        public FrmDialogEditDish()
        {
            InitializeComponent();
        }

        private void chi_tiet_mon_Load(object sender, EventArgs e)
        {
            Form callingForm = this.Tag as Form;
            if (callingForm != null)
            {
                // Do something with the calling form, e.g. hide a button
                callingForm.Controls["myButton"].Visible = false;
            }
        }

        private void ctm_bt_chonanh_Click(object sender, EventArgs e)
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
                ptrDialogEditDish_pic.ImageLocation = imagePath;
            }
        }

        private void ctm_pic_Click(object sender, EventArgs e)
        {

        }

        private void lbDialogEditDish_howUse_TextChanged(object sender, EventArgs e)
        {
            lbDialogEditDish_howUse__.Text = tbDialogEditDish_howUse.Text;
        }
    }
}
