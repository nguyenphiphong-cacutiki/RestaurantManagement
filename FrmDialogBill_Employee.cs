using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup03_63KTPM2_Version01
{
    public partial class FrmDialogBill_Employee : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adapDB = null;
        public static DataTable dtDishListInBill = null;
        public static DataTable dtOldBill = null; //Lưu dữ liệu sau khi xóa NewBill
        long sum = 0;
        public FrmDialogBill_Employee()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 
        private void FrmDialogBill_Employee_Load(object sender, EventArgs e)
        {
            // Ket noi SQL
            string cont = "Data Source = MTD-PHONGNP2\\SQLEXPRESS;" +
                          "Initial catalog = BTLWINFORM;" +
                          "Integrated security = true";
            con = new SqlConnection(cont);
            con.Open();

            dtDishListInBill = new DataTable();
            dtOldBill = new DataTable();

            // Lấy dữ liệu đưa vào hóa đơn
            string adaDB = "Select name, amount, grandtotal from "+ManagerTables.NewBill+" N, "+ManagerTables.Dish+" D where N.IdMon = D.Id and " +
                           "indexTable = '" + FrmEmployee.index + "'";
            adapDB = new SqlDataAdapter(adaDB, con);
            adapDB.Fill(dtDishListInBill);
            lbFrmDialogBill_TableId.Text += FrmEmployee.index;

            for (int i = 0; i < dtDishListInBill.Rows.Count; i++)
            {
                ItemDishInBill_Employee item = new ItemDishInBill_Employee(dtDishListInBill.Rows[i][0].ToString().Trim(),
                                                                        dtDishListInBill.Rows[i][1].ToString().Trim(),
                                                                        dtDishListInBill.Rows[i][2].ToString().Trim());
                sum += Convert.ToInt32(dtDishListInBill.Rows[i][2]);
                pnFrmDialogBill_DishList.Controls.Add(item);
                item.Dock = DockStyle.Top;
            }
            lbFrmDialogBill_Grandtotal.Text += sum.ToString().Trim();
        }

        private void lbFrmDialogBill_TableId_Click(object sender, EventArgs e)
        {

        }

        // Hủy in hóa đơn -> thoát form hóa đơn
        private void btFrmDialogBill_CanCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chọn in 
        private void btFrmDialogBill_Print_Click(object sender, EventArgs e)
        {
            // Đưa hết dữ liệu từ NewBill vào oldBill để lưu trữ thông tin
            string cmt = "Insert into "+ManagerTables.OldBill+" select * from "+ManagerTables.NewBill+ " where indexTable = '" + FrmEmployee.index + "'";
            FrmEmployee.command.CommandText = cmt;
            FrmEmployee.command.ExecuteNonQuery();
            SqlDataAdapter adapOB = new SqlDataAdapter("Select * from OldBill", con);
            adapOB.Fill(dtOldBill);

            // Xóa hết dữ liệu từ NewBill của bàn chọn in hóa đơn
            cmt = "Delete from "+ManagerTables.NewBill+" where indexTable = '" + FrmEmployee.index + "'";
            FrmEmployee.command.CommandText = cmt;
            FrmEmployee.command.ExecuteNonQuery();
            //FrmEmployee.tableCurrentPrintBill.Text = "Đã thanh toán";
            try
            {
                if(FrmEmployee.tableCurrentPrintBill != null)
                {
                    FrmEmployee.tableCurrentPrintBill.BackColor = Color.Red;
                    FrmEmployee.tableCurrentPrintBill.Enabled = false;
                }
                
            }
            catch (Exception) { }
            
         //   FrmEmployee.pnFrmEmployee_DishList.Controls.Clear();
         //   FrmEmployee.pnFrmEmployee_TableList.Controls.Remove(FrmEmployee.bt);
            this.Close();
        }
    }
}
