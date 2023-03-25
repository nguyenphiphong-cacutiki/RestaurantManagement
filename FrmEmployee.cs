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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProjectGroup03_63KTPM2_Version01
{
    public partial class FrmEmployee : Form
    {
        public static SqlConnection con = null;
        public static DataTable dtDishList = null;
        public static DataTable dtTableList = null;
        public static DataTable dtNewBill = null;
        public SqlDataAdapter adapDishList = null;
        public SqlDataAdapter adapTableList = null;
        public static SqlDataAdapter adapNewBill = null;
        public static SqlCommand command = null;
        public static Button tableCurrentPrintBill = null;
        Button currentbt = null;
        public static string index = "";
        string adDishList = "";
        public static string ind = "";
        public static string getSupport = "null";
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void NV_TrangChu_Load(object sender, EventArgs e)
        {
            //Ket noi SQL
            string cont = "Data Source = MTD-PHONGNP2\\SQLEXPRESS;" +
                          "Initial catalog = BTLWINFORM;" +
                          "Integrated Security = true";
            con = new SqlConnection(cont);
            con.Open();

            // Thêm dữ liệu cho các datatable từ database
            dtDishList = new DataTable();
            dtTableList = new DataTable();
            dtNewBill = new DataTable();                       
            string adTableList = "Select distinct indexTable as mIndex from "+ManagerTables.NewBill;
            string adNewBill = "Select * from "+ManagerTables.NewBill;
            adDishList = "Select pathImage, name, price, amount, idMon, status, indexTable from "+ManagerTables.NewBill+" N inner join "+ManagerTables.Dish+" D on N.Idmon = D.Id";
            adapDishList = new SqlDataAdapter(adDishList, con);            
            adapTableList = new SqlDataAdapter(adTableList, con);
            adapNewBill = new SqlDataAdapter(adNewBill, con);
            adapTableList.Fill(dtTableList);
            adapNewBill.Fill(dtNewBill);
            adapDishList.Fill(dtDishList);
            command = new SqlCommand();
            command.Connection = con;
            
            // Load danh sach các bàn đã đặt món
            for (int i = dtTableList.Rows.Count-1; i >= 0; i--)
            {
                Button bt = new Button();
                bt.Text = dtTableList.Rows[i][0].ToString();
                bt.Dock = DockStyle.Top;
                bt.BackColor = Color.WhiteSmoke;
                bt.Click += new System.EventHandler(this.loadDishTable);
                pnFrmEmployee_TableList.Controls.Add(bt);
            }
            LoadL1();

            // Khi có yêu cầu hỗ trợ, button đổi màu
            string sqlSupport = "select * from Support";
            SqlDataAdapter _adap = new SqlDataAdapter(sqlSupport, con);
            DataTable dtSupport = new DataTable();
            _adap.Fill(dtSupport);
            if(dtSupport.Rows.Count > 0)
            {
                getSupport = dtSupport.Rows[0][0].ToString().Trim();
                if (getSupport != "null") btFrmEmployee_getSupport.BackColor = Color.Red;
                else btFrmEmployee_getSupport.BackColor = Color.LightGray;
            }
            btFrmEmployee_getSupport.Click += new System.EventHandler(this._getSupport);
        }
        public void _getSupport(object sender, EventArgs args)
        {
            if(getSupport != "null")
            {
                MessageBox.Show(getSupport);
                btFrmEmployee_getSupport.BackColor = Color.LightGray;
                command.CommandText = "update Support set mSupport = 'null'";
                command.ExecuteNonQuery();
            }
        }

        // Load các món của bàn đầu tiên trong danh sách bàn khi chạy form
        public static void LoadL1()
        {
            
            if (dtTableList.Rows.Count != 0)
            {
                ind = dtTableList.Rows[0][0].ToString();
                DataTable dtL1 = new DataTable();
                string adL1 = "Select pathImage, name, price, amount, idMon, status, indexTable from "+ManagerTables.NewBill+" N inner join "+ManagerTables.Dish+" D on N.Idmon = D.Id " +
                                    "where indexTable = '" + ind + "'";
                SqlDataAdapter adaL1 = new SqlDataAdapter(adL1, con);
                adaL1.Fill(dtL1);
                for (int k = 0; k < dtL1.Rows.Count; k++)
                {
                    ItemDish_Employee item = new ItemDish_Employee(dtDishList.Rows[k][0].ToString().Trim(),
                                                                   dtDishList.Rows[k][1].ToString().Trim(),
                                                                   dtDishList.Rows[k][2].ToString().Trim(),
                                                                   dtDishList.Rows[k][3].ToString().Trim(),
                                                                   dtDishList.Rows[k][4].ToString().Trim(),
                                                                   dtDishList.Rows[k][5].ToString().Trim());
                    pnFrmEmployee_DishList.Controls.Add(item);
                    item.Dock = DockStyle.Top;
                }
                index = dtTableList.Rows[0][0].ToString();
            }
        }

        // Load các món khi ấn vào số hiệu bàn
        private void loadDishTable(object sender, EventArgs args)
        {
            pnFrmEmployee_DishList.Controls.Clear();
            tableCurrentPrintBill = sender as Button;
            tableCurrentPrintBill.BackColor = Color.LightBlue;
            if (currentbt != null) currentbt.BackColor = Color.WhiteSmoke;
            currentbt = tableCurrentPrintBill;
            index = tableCurrentPrintBill.Text;

            // Load lại dữ liệu sau mỗi lần click
            adapDishList.SelectCommand.CommandText = adDishList;
            dtDishList.Clear();
            adapDishList.Fill(dtDishList);
            for (int i = 0; i < dtDishList.Rows.Count; i++)
            {
                if (dtDishList.Rows[i][6].ToString() == index)
                {
                    ItemDish_Employee item = new ItemDish_Employee(dtDishList.Rows[i][0].ToString().Trim(),
                                                               dtDishList.Rows[i][1].ToString().Trim(),
                                                               dtDishList.Rows[i][2].ToString().Trim(),
                                                               dtDishList.Rows[i][3].ToString().Trim(),
                                                               dtDishList.Rows[i][4].ToString().Trim(),                   
                                                               dtDishList.Rows[i][5].ToString().Trim());                    
                    pnFrmEmployee_DishList.Controls.Add(item);
                    item.Dock = DockStyle.Top;
                }
            }         
        }


        // Thiết lập bàn
        private void mnFrmEmployee_Setup_Click(object sender, EventArgs e)
        {
            FrmSetUpTable frm = new FrmSetUpTable();
            frm.ShowDialog();
            this.Show();
        }

        // Reset bàn
        void btFrmEmployee_TableReset_Click_1(object sender, EventArgs e)
        {
            // Xóa hết dữ liệu của bàn có text = index từ NewBill
            string cmdD = "Delete from "+ManagerTables.NewBill+" where indexTable = '" + index + "'";
            command.CommandText = cmdD;
            command.ExecuteNonQuery();
            pnFrmEmployee_DishList.Controls.Clear();
            pnFrmEmployee_TableList.Controls.Remove(tableCurrentPrintBill);
            dtNewBill.Clear();
            adapNewBill.Fill(dtNewBill);
            LoadL1();
        }

        // Đăng xuất -> trở về giao diện đăng nhập
        private void mnFrmEmployee_SignOut_Click(object sender, EventArgs e)
        {
            FrmLogin.whatFormNeedShow = "FrmLogin";
            Close();
        }

        // In hóa đơn
        private void btFrmEmployee_PrintBill_Click(object sender, EventArgs e)
        {           
            FrmDialogBill_Employee frm = new FrmDialogBill_Employee();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

       
    }
}
