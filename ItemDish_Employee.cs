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
    public partial class ItemDish_Employee : UserControl
    {
        string idMon = "";
        SqlConnection con = null;
        public static string status = "";
        public ItemDish_Employee(string pathImage, string name, string price, string count, string idMon, string _status)
        {
            InitializeComponent();
            PbItemDish_Employee.Image = Image.FromFile(pathImage);
            lbItemDishEmployee_DishName.Text = name;
            lbItemDishEmployee_Price.Text = price;
            lbItemDishEmployee_Amount.Text += count;
            this.idMon = idMon;
            status = _status;
            if (status == "")
            {
                rdItemDishEmployee_Working.Checked = false;
                rdItemDishEmployee_Done.Checked = false;
            }
            else
            {
                if (status == "Dang lam") rdItemDishEmployee_Working.Checked = true;
                else if (status == "Da lam") rdItemDishEmployee_Done.Checked = true;
            }
            string cn = "Data Source =MTD-PHONGNP2\\SQLEXPRESS;" +
                        "Initial Catalog = BTLWINFORM;" +
                        "Integrated Security = true";
            con = new SqlConnection(cn);
            con.Open();
        }

        private void btItemDishEmployee_CanCel_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            
            string cmdD = "Delete from "+ManagerTables.NewBill+" where indexTable = '" + FrmEmployee.index + "' and idMon = '" + idMon + "'";
            FrmEmployee.command.CommandText = cmdD;
            FrmEmployee.command.ExecuteNonQuery();
            FrmEmployee.adapNewBill.DeleteCommand = FrmEmployee.command;
            FrmEmployee.pnFrmEmployee_DishList.Controls.Remove(this);
            //   FrmEmployee.dtNewBill.Clear();
            //  FrmEmployee.adapNewBill.Fill(FrmEmployee.dtNewBill);

        }

        

        // Update vào SQL
        private void Update(object sender, EventArgs e)
        {
            if (rdItemDishEmployee_Working.Checked == true) status = "Dang lam";
            else status = "Da lam";
            string cmd = "Update "+ManagerTables.NewBill+" set status = '" + status + "' where idMon = '" + idMon + "' and indexTable = '" + FrmEmployee.index + "'";
            FrmEmployee.command.CommandText = cmd;
            FrmEmployee.command.ExecuteNonQuery();     
        }

        private void rdo_click(object sender, EventArgs e)
        {
            if (rdItemDishEmployee_Working.Checked)
            {
                string cmd = "Update "+ManagerTables.NewBill+" set status = 'Dang lam' where idMon = '" + idMon + "' and indexTable = '" +
                         FrmEmployee.index + "'";
                //   rdItemDishEmployee_Working.Checked = true;
                FrmEmployee.command.CommandText = cmd;
                FrmEmployee.adapNewBill.UpdateCommand = FrmEmployee.command;
                FrmEmployee.dtNewBill.Clear();
                FrmEmployee.adapNewBill.Fill(FrmEmployee.dtNewBill);
            }
        }
    }
}
