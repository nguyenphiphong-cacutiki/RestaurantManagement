using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static string EmployeeAccount = userManager + EmployeeAccountDefault;
        public static string EmployeeInfo = userManager + EmployeeInfoDefault;
        public static string CategoryDish = userManager + CategoryDishDefault;


        // hàm tạo tất cả các bảng, được gọi khi quản lý đăng nhập
        // mỗi người tự kết nối database trong form
        // thêm các class quản lý thông tin

    }
}
