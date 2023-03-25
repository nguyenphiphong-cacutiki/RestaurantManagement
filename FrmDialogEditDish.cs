using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectGroup03_63KTPM2_Version01
{
    public partial class FrmDialogEditDish : Form
    {
        // variable connnect sql
        SqlConnection con = null;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dtData;
        //
        private string imagePath = "";
        private string id;
        public FrmDialogEditDish()
        {
            InitializeComponent();
            string sqlConnect = "Data Source=MTD-PHONGNP2\\SQLEXPRESS;" +
                                "Initial catalog=BTLWINFORM;" +
                                "Integrated Security=true";
            con = new SqlConnection(sqlConnect);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            dtData = new DataTable();
        }
        public FrmDialogEditDish(string id)
        {
            InitializeComponent();
            string sqlConnect = "Data Source=MTD-PHONGNP2\\SQLEXPRESS;" +
                                "Initial catalog=BTLWINFORM;" +
                                "Integrated Security=true";
            con = new SqlConnection(sqlConnect);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            dtData = new DataTable();
            this.id = id;
        }

        private void chi_tiet_mon_Load(object sender, EventArgs e)
        {
            // load combobox
            adapter = new SqlDataAdapter("select mName from " + ManagerTables.CategoryDish, con);
            dtData.Clear();
            adapter.Fill(dtData);
            for (int i = 0; i < dtData.Rows.Count; i++)
            {
                cbCategory.Items.Add(dtData.Rows[i][0].ToString().Trim());
            }
            // load info dish
            string sqlDish = "select * from " + ManagerTables.Dish + " where id = '" + id + "'";
            SqlDataAdapter adapterDish = new SqlDataAdapter(sqlDish, con);
            DataTable dtDish = new DataTable();
            adapterDish.Fill(dtDish);
            if(dtDish.Rows.Count > 0)
            {
                tbDialogAddDish_name.Text = dtDish.Rows[0][1].ToString().Trim();
                tbDialogAddDish_price.Text = dtDish.Rows[0][2].ToString().Trim();
                tbDialogAddDish_howUse.Text = dtDish.Rows[0][3].ToString().Trim();
                ptrDialogAddDish_pic.Image = Image.FromFile(dtDish.Rows[0][4].ToString().Trim());
                cbCategory.Text = dtDish.Rows[0][5].ToString().Trim();
                tbID.Text = dtDish.Rows[0][0].ToString().Trim();
                imagePath = dtDish.Rows[0][4].ToString().Trim();
            }
            
        }

        private void btDialogAddDish_selectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Windows Bitmap|*.jpg|*.png|JPEG File";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ptrDialogAddDish_pic.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
            }
        }

        private void btDialogAddDish_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbDialogAddDish_name.Text.Trim();
                string idNew = tbID.Text.Trim();
                string category = cbCategory.Text.Trim();
                int price = Convert.ToInt32(tbDialogAddDish_price.Text.Trim());
                string howUse = tbDialogAddDish_howUse.Text.Trim();

                // check for id is exists
                SqlDataAdapter adapterId = new SqlDataAdapter("select id from " + ManagerTables.Dish + " where id = '" + idNew + "'", con);
                DataTable dtId = new DataTable();
                adapterId.Fill(dtId);
                if (dtId.Rows.Count > 0 && id != idNew)
                {
                    MessageBox.Show("id đã được dùng cho món khác!");
                }
                else
                if (name.Length > 0 && id.Length > 0 && category.Length > 0 && imagePath.Length > 0)
                {
                    cmd.CommandText = "update "+ManagerTables.Dish+" set id = '"+id+"', name = N'"+name+"', howUse = N'"+howUse+"', pathImage = '"+imagePath+"', category = N'"+category+"', price = '"+price+"' where id = '"+id+"'";
                    cmd.ExecuteNonQuery();
                    FrmManager.loadDataDish();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập giá hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
