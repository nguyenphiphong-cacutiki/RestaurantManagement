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
    public partial class FrmManager : Form
    {
        private SqlConnection con = null;
        public static SqlDataAdapter adapter;
        private SqlDataAdapter adapEmployee;
        private SqlDataAdapter adapQ;
        private SqlDataAdapter adapThongKe;
        private SqlDataAdapter adapWay;
        public static SqlCommand cmd;
        public static DataTable dtDish;
        private DataTable dtEmployee;
        private DataTable dtProvince;
        private DataTable dtThongKe;
        private DataTable dtWay;
        string gtcheck = "";
        int currentRow;
        string imagePath = "";


        // Ket noi SQL
        public FrmManager()
        {
            InitializeComponent();
            string sqlConnec = "Data source=MTD-PHONGNP2\\SQLEXPRESS;" +
                               "Initial Catalog=BTLWINFORM;" +
                               "Integrated Security=true";
            con = new SqlConnection(sqlConnec);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            adapter = new SqlDataAdapter();
            dtDish = new DataTable();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            btStatistical_excel.Visible = false;
            btStatistical_printreport.Visible = false;
            //
            loadDataDish();
            dtEmployee = new DataTable();
            dtProvince = new DataTable();
            dtThongKe = new DataTable();
            dtWay = new DataTable();

            // Tab control quản lý nhân viên
            string adaEmployee = "Select mname, sex, birth, province, E2.idPeople, phone, mUser, password, pathImage from EmployeeAccount E1, EmployeeInfo E2 where " +
                                 "E1.idPeople = E2.idPeople and managerUser = '"+ManagerTables.userManager+"'";
            string adaQ = "Select distinct province from EmployeeInfo";
            adapEmployee = new SqlDataAdapter(adaEmployee, con);          
            adapQ = new SqlDataAdapter(adaQ, con);
            adapQ.Fill(dtProvince);
            dtProvince.Columns[0].ColumnName = "Quê quán";
            adapEmployee.Fill(dtEmployee);              
            dtEmployee.Columns[0].ColumnName = "Họ tên";
            dtEmployee.Columns[1].ColumnName = "Giới tính";
            dtEmployee.Columns[2].ColumnName = "Ngày sinh";
            dtEmployee.Columns[3].ColumnName = "Quê quán";
            dtEmployee.Columns[4].ColumnName = "CCCD";
            dtEmployee.Columns[5].ColumnName = "SDT";
            dtEmployee.Columns[6].ColumnName = "Email";
            dtEmployee.Columns[7].ColumnName = "PassWord";
            dtEmployee.Columns[8].ColumnName = "Image";
            dtgvFrmAgent.DataSource = dtEmployee;
            cbFrmAgent_nativeland.DataSource = dtProvince;
            cbFrmAgent_nativeland.DisplayMember = "Quê quán";   


            // Tab control thống kê            
            string adaWay = "Select * from "+ManagerTables.CategoryDish;
            adapWay = new SqlDataAdapter(adaWay, con);
            adapWay.Fill(dtWay);
            dtWay.Rows.Add("Tat ca");
            cbFrmStatistical_filterinformation.DataSource = dtWay;
            cbFrmStatistical_filterinformation.DisplayMember = "mName";
            string adaThongKe = "Select Name, amount, grandtotal from "+ManagerTables.OldBill+" O, "+ManagerTables.Dish+" where O.id = ''";
            adapThongKe = new SqlDataAdapter(adaThongKe, con);
            adapThongKe.Fill(dtThongKe);
            dtThongKe.Columns[0].ColumnName = "Sản phẩm";
            dtThongKe.Columns[1].ColumnName = "Số lượng bán";
            dtThongKe.Columns[2].ColumnName = "Doanh thu";
        }

        //Fill data bảng quản lý nhân viên
        void fillDataEmployee()
        {
            dtEmployee.Columns[0].ColumnName = "mName";
            dtEmployee.Columns[1].ColumnName = "Sex";
            dtEmployee.Columns[2].ColumnName = "birth";
            dtEmployee.Columns[3].ColumnName = "province";
            dtEmployee.Columns[4].ColumnName = "idPeople";
            dtEmployee.Columns[5].ColumnName = "phone";
            dtEmployee.Columns[6].ColumnName = "mUser";
            dtEmployee.Columns[7].ColumnName = "password";
            dtEmployee.Columns[8].ColumnName = "pathImage";          
            dtEmployee.Clear();
            adapEmployee.Fill(dtEmployee);
            dtEmployee.Columns[0].ColumnName = "Họ tên";
            dtEmployee.Columns[1].ColumnName = "Giới tính";
            dtEmployee.Columns[2].ColumnName = "Ngày sinh";
            dtEmployee.Columns[3].ColumnName = "Quê quán";
            dtEmployee.Columns[4].ColumnName = "CCCD";
            dtEmployee.Columns[5].ColumnName = "SDT";
            dtEmployee.Columns[6].ColumnName = "Email";
            dtEmployee.Columns[7].ColumnName = "Pass word";
            dtEmployee.Columns[8].ColumnName = "Image";
        }


        // Fill data bảng thống kê
        void fillDataThongKe()
        {
            dtThongKe.Columns[0].ColumnName = "Name";
            dtThongKe.Columns[1].ColumnName = "Amount";
            dtThongKe.Columns[2].ColumnName = "GrandTotal";
            dtThongKe.Clear();
            adapThongKe.Fill(dtThongKe);
            dtThongKe.Columns[0].ColumnName = "Sản phẩm";
            dtThongKe.Columns[1].ColumnName = "Số lượng bán";
            dtThongKe.Columns[2].ColumnName = "Doanh thu";
        }

        // Xóa sau khi nhập xong DL
        void reset()
        {
            tbFrmAgent_name.Text = "";
            tbFrmAgent_cccd.Text = "";
            tbFrmAgent_phone.Text = "";
            tbFrmAgent_email.Text = "";
            tbFrmAgent_pass.Text = "";
            imagePath = "";
            rbFrmAgent_boy.Checked = false;
            rbFrmAgent_girl.Checked = false;
        }

        private void mnFrmManager_moredishes_Click(object sender, EventArgs e)
        {
            FrmDialogAddDish frmDialogAddDish = new FrmDialogAddDish();
            frmDialogAddDish.ShowDialog();
            if (frmDialogAddDish.DialogResult == DialogResult.Cancel)
            {
                loadDataDish();
            }
        }

        //TabCtrol Quản lý món
        public static void loadDataDish()
        {
            //set cell table layout pannel
            tlpFrmManager_AllDishes.Controls.Clear();
            int x = 0, y = 0;

            cmd.CommandText = "select * from " + ManagerTables.Dish;
            adapter.SelectCommand = cmd;
            dtDish.Clear();
            adapter.Fill(dtDish);

            for (int i = 0; i < dtDish.Rows.Count; i++)
            {
                // tạo item dish, gắn giá trị,
                // add vào tlp
                ItemDish_Manager item = new ItemDish_Manager(dtDish.Rows[i][0].ToString().Trim(),
                    dtDish.Rows[i][1].ToString().Trim(),
                    dtDish.Rows[i][2].ToString().Trim(),
                    dtDish.Rows[i][3].ToString().Trim(),
                    dtDish.Rows[i][4].ToString().Trim(),
                    dtDish.Rows[i][5].ToString().Trim(),
                    "MANAGER");
                item.Dock = DockStyle.Fill;
                tlpFrmManager_AllDishes.Controls.Add(item, x, y);
                // change x, y
                x++; x = x % 2;
                if (x == 0) y++;
            }
            //MessageBox.Show(dtDish.Rows.Count.ToString());
        }

        // Quản lý thể loại món
        private void mnFrmManager_managerCategoryDish_Click(object sender, EventArgs e)
        {
            FrmManagerCategory managerCategory = new FrmManagerCategory();
            managerCategory.ShowDialog();
        }

        // Đăng xuất
        private void mnFrmManager_signout_Click(object sender, EventArgs e)
        {
            FrmLogin.whatFormNeedShow = "FrmLogin";
            Close();
        }

        // Kiểm tra giới tính
        void checkSex()
        {
            if (rbFrmAgent_boy.Checked == true)
                gtcheck = "Nam";
            else if (rbFrmAgent_girl.Checked == true)
                gtcheck = "Nu";
        }

        // Chọn ảnh nhân viên
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
                imagePath = openFileDialog1.FileName;

                // Đặt nội dung của PictureBox bằng đường dẫn tập tin ảnh
                pbFrmAgent_picture.Image = Image.FromFile(imagePath);
            }

            //Thêm pathImage của nhân viên vào CSDL
            string cmt = "Update EmployeeInfo set pathImage = '" + imagePath + "' where idPeople = '" + tbFrmAgent_cccd.Text + "'";
            cmd.CommandText = cmt;
            cmd.ExecuteNonQuery();
            fillDataEmployee();
        }
         
       // Thêm nhân viên
        private void nv_bt_them_Click(object sender, EventArgs e)
        {
            checkSex();
            // Kiểm tra thông tin rỗng
            try
            {
                if (tbFrmAgent_email.Text == "" || tbFrmAgent_name.Text == "" || tbFrmAgent_cccd.Text == "" || tbFrmAgent_phone.Text == "" || cbFrmAgent_nativeland.Text == "" || imagePath == "" || gtcheck == "")
                {
                    throw new Exception ("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    string sql = "select idPeople from EmployeeAccount where idPeople = '" + tbFrmAgent_cccd.Text.Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0) throw new Exception("Căn cước công dân đã tồn tại");
                    string comm = "Insert into EmployeeAccount values ('" + tbFrmAgent_email.Text + "','" +
                                                             tbFrmAgent_pass.Text + "','" +ManagerTables.userManager+ "','" +
                                                             tbFrmAgent_cccd.Text + "')";
                    //checkSex();
                    cmd.CommandText = comm;
                    cmd.ExecuteNonQuery();

                    comm = "Insert into EmployeeInfo values (N'" + tbFrmAgent_name.Text + "',N'" +
                                                                     gtcheck + "','" +
                                                                     dtpFrmAgent_date.Value.ToString("yyyy/MM/dd") + "','" +
                                                                     cbFrmAgent_nativeland.Text + "','" +
                                                                     tbFrmAgent_cccd.Text + "','" +
                                                                     tbFrmAgent_phone.Text + "','" +
                                                                     imagePath + "')";
                    cmd.CommandText = comm;
                    cmd.ExecuteNonQuery();
                    fillDataEmployee();
                    //    dtgvFrmAgent.DataSource = dtEmployee;
                    reset();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            
        }

        
        
        private void tcFrmManager_Click(object sender, EventArgs e)
        {

        }

        // Sửa thông tin nhân viên
        private void btFrmAgent_editinformation_Click(object sender, EventArgs e)
        {
            checkSex();
            string cmt = "Update EmployeeAccount set mUser = '" + tbFrmAgent_email.Text + "'," +
                         "password = '" + tbFrmAgent_pass.Text + "'," +
                         "managerUser = '"+ManagerTables.userManager+"'," +
                         "idPeoPle = '" + tbFrmAgent_cccd.Text + "' " +
                         "where idPeople = '" + tbFrmAgent_cccd.Text + "'";
            cmd.CommandText = cmt;
            cmd.ExecuteNonQuery();

            cmt = "Update EmployeeInfo set mName = '" + tbFrmAgent_name.Text + "'," +
                  "sex = N'" + gtcheck + "'," +
                  "birth = '" + dtpFrmAgent_date.Value.ToString("yyyy/MM/dd") + "'," +
                  "province = N'" + cbFrmAgent_nativeland.Text + "'," +
                  "idPeoPle = '" + tbFrmAgent_cccd.Text + "'," +
                  "phone = '" + tbFrmAgent_phone.Text + "'," +
                  "pathImage = '" + imagePath + "' " +
                  "where idPeople = '" + tbFrmAgent_cccd.Text + "'";
            cmd.CommandText = cmt;
            cmd.ExecuteNonQuery();
            fillDataEmployee();
            reset();
        }

        // Cell click
        private void dtgvFrmAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            currentRow = e.RowIndex;
            if (currentRow >= 0 && currentRow < dtgvFrmAgent.Rows.Count - 1)
            {
                imagePath = dtgvFrmAgent.Rows[currentRow].Cells[8].Value.ToString().Trim();
                tbFrmAgent_name.Text = dtgvFrmAgent.Rows[currentRow].Cells[0].Value.ToString().Trim();
                if (dtgvFrmAgent.Rows[currentRow].Cells[1].Value.ToString().Trim() == "Nam") rbFrmAgent_boy.Checked = true;
                else rbFrmAgent_girl.Checked = true;
                dtpFrmAgent_date.Text = dtgvFrmAgent.Rows[currentRow].Cells[2].Value.ToString().Trim();
                cbFrmAgent_nativeland.Text = dtgvFrmAgent.Rows[currentRow].Cells[3].Value.ToString().Trim();
                tbFrmAgent_cccd.Text = dtgvFrmAgent.Rows[currentRow].Cells[4].Value.ToString().Trim();
                tbFrmAgent_phone.Text = dtgvFrmAgent.Rows[currentRow].Cells[5].Value.ToString().Trim();
                tbFrmAgent_email.Text = dtgvFrmAgent.Rows[currentRow].Cells[6].Value.ToString().Trim();
                tbFrmAgent_pass.Text = dtgvFrmAgent.Rows[currentRow].Cells[7].Value.ToString().Trim();
                pbFrmAgent_picture.Image = Image.FromFile(dtgvFrmAgent.Rows[currentRow].Cells[8].Value.ToString().Trim());
            }
            
        }

        // Xóa thông tin
        private void btFrmAgent_deleteinfomation_Click(object sender, EventArgs e)
        {
            try
            {
                if(currentRow >= 0 && currentRow < dtgvFrmAgent.Rows.Count - 1)
                {
                    string idPeople = dtgvFrmAgent.Rows[currentRow].Cells[4].Value.ToString();

                    dtgvFrmAgent.Rows.RemoveAt(this.dtgvFrmAgent.Rows[currentRow].Index);

                    string cmt = "Delete from EmployeeInfo where idPeople = '" + idPeople + "'";
                    cmd.CommandText = cmt;
                    cmd.ExecuteNonQuery();
                    cmt = "Delete from EmployeeAccount where idPeople = '" + idPeople + "'";
                    cmd.CommandText = cmt;
                    cmd.ExecuteNonQuery();
                }
                
            }
            catch (Exception) { }
        }

        private void cbFrmStatistical_filterinformation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Tab control thống kê
        // Tìm kiếm 
        private void btStatistical_search_Click(object sender, EventArgs e)
        {
            string adaThongKe;
            //   string adaThongKe = "Select Name, amount, grandtotal from OldBill, Dish where (month(date) = " + Convert.ToInt32(dtpStatistical_winningbegins.Value.ToString("MM")) + ")" +
            //                     " and (year(date) = " + Convert.ToInt32(dtpStatistical_winningbegins.Value.ToString("yyyy")) + ")" +
            //                   " and OldBill.IdMon = Dish.Id and Category = '" + cbFrmStatistical_filterinformation.Text + "'";
            if (cbFrmStatistical_filterinformation.Text != "Tat ca")
            {
                 adaThongKe = "Select Name, amount, grandtotal from "+ManagerTables.OldBill+" O, "+ManagerTables.Dish+" D where O.date >='" + dtpStatistical_winningbegins.Value.ToString("yyyy/MM/dd") +
                              "' and O.date <= '" + dtpStatistical_winningends.Value.ToString("yyyy/MM/dd") + "' and O.IdMon = D.Id and Category = '" + cbFrmStatistical_filterinformation.Text + "'";

            }
            else adaThongKe = "Select Name, amount, grandtotal from "+ManagerTables.OldBill+" O, "+ManagerTables.Dish+" D where O.date >='" + dtpStatistical_winningbegins.Value.ToString("yyyy/MM/dd") +
                              "' and O.date <= '" + dtpStatistical_winningends.Value.ToString("yyyy/MM/dd") + "' and O.IdMon = D.Id";

            adapThongKe.SelectCommand.CommandText = adaThongKe;
            fillDataThongKe();
            dtgvStatistical.DataSource = dtThongKe;
        }
    }
}
