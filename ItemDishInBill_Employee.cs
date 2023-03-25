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
    public partial class ItemDishInBill_Employee : UserControl
    {
      //  SqlConnection con = null;
        public ItemDishInBill_Employee(string name, string count, string price)
        {
            InitializeComponent();
            lbFrmDialogBill_DishName.Text = name;
            lbFrmDialogBill_Count.Text = count;
            lbFrmDialogBill_Price.Text = price;
          //  string cont = "Data Source = LAPTOP-00U880JL\\MSSQLSERVER02;" +
          //                "Initial catalog = BTLWINFORM;" +
          //                "Integrated security = true";
          //  con = new SqlConnection(cont);
          //  con.Open();
          //  string

        }
    }
}
