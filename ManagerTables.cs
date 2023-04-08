using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectGroup03_63KTPM2_Version01
{
    public class ManagerTables
    {
        public static string TableListDefault = "TableList";
        public static string NewBillDefault = "NewBill";
        public static string OldBillDefault = "OldBill";
        public static string DishDefault = "Dish";
        public static string EmployeeAccountDefault = "EmployeeAccount";
        public static string EmployeeInfoDefault = "EmployeeInfo";
        public static string CategoryDishDefault = "CategoryDish";

        public static string userManager;

        public static string TableList = userManager + TableListDefault;
        public static string NewBill = userManager + NewBillDefault;
        public static string OldBill = userManager + OldBillDefault;
        public static string Dish = userManager + DishDefault;
        //public static string EmployeeAccount = userManager + EmployeeAccountDefault;
        //public static string EmployeeInfo = userManager + EmployeeInfoDefault;
        public static string CategoryDish = userManager + CategoryDishDefault;

        public static SqlConnection con = null;
        public static SqlDataAdapter adapter;
        public static SqlCommand cmd;
        public ManagerTables()
        {
            
        }
        public static void setUpConnect()
        {
            string sqlConnect = "Data source=MTD-PHONGNP2\\SQLEXPRESS;"
                                + "Initial Catalog=BTLWINFORM;"
                                + "Integrated Security=true";
            con = new SqlConnection(sqlConnect);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        public static void setUpTableName()
        {
            string _userManager = "a" + userManager;
            TableList = _userManager + TableListDefault;
            NewBill = _userManager + NewBillDefault;
            OldBill = _userManager + OldBillDefault;
            Dish = _userManager + DishDefault;
            //EmployeeAccount = userManager + EmployeeAccountDefault;
            //EmployeeInfo = userManager + EmployeeInfoDefault;
            CategoryDish = _userManager + CategoryDishDefault;
        }
        public static void createTable()
        {
            setUpConnect();
            setUpTableName();

            string sqlTableList = "create table " + TableList + " (mIndex char(10))";
            string sqlNewBill = "create table " + NewBill + " (id char(50), idMon char(50), amount int, grandTotal int, status nvarchar(50), date char(100), indexTable char(50))";
            string sqlOldBill = "create table " + OldBill + " (id char(50), idMon char(50), amount int, grandTotal int, status nvarchar(50), date char(100), indexTable char(50))";
            string sqlDish = "create table " + Dish + " (id char(50), name nvarchar(50), price int, howUse nvarchar(4000), pathImage char(350), category nvarchar(50))";
            //string sqlEmployeeAccount = "create table " + EmployeeAccount + " (id char(50), mUser char(50), password char(50), managerUser char(50))";
            //string sqlEmployeeInfo = "create table " + EmployeeInfo + " (id char(50), mName char(50), sex char(50), birth date, province char(50), idPeople char(50), phone char(50))";
            string sqlCategoryDish = "create table " + CategoryDish + " (mName nvarchar(50))";

            cmd.CommandText = sqlTableList; cmd.ExecuteNonQuery();
            cmd.CommandText = sqlNewBill; cmd.ExecuteNonQuery();
            cmd.CommandText = sqlOldBill; cmd.ExecuteNonQuery();
            cmd.CommandText = sqlDish; cmd.ExecuteNonQuery();
            //cmd.CommandText = sqlEmployeeAccount; cmd.ExecuteNonQuery();
            //cmd.CommandText = sqlEmployeeInfo; cmd.ExecuteNonQuery();
            cmd.CommandText = sqlCategoryDish; cmd.ExecuteNonQuery();
        }


        // hàm tạo tất cả các bảng, được gọi khi quản lý đăng ký một tài khoản mới
        // mỗi người tự kết nối database trong form
        // thêm các class quản lý thông tin

    }
}
