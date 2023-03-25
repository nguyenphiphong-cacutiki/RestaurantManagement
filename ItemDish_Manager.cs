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
    public partial class ItemDish_Manager : UserControl
    {
        private string id;
        private string name;
        private string price;
        private string howUse;
        private string pathImage;
        private string category;

        private SqlConnection con = null;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataTable dtDish;

        public static string currentIdBill = "";


        public ItemDish_Manager()
        {
            InitializeComponent();
            initilizeConnection();
        }
        public ItemDish_Manager(string id, string name, string price, string howUse, string pathImage,
            string category, string whoUse)
        {
            InitializeComponent();
            initilizeConnection();
            pbItemDishManager_pic.Image = Image.FromFile(pathImage);
            lbItemDishManager_name.Text = name;
            lbItemDishManager_price.Text = "Giá: " + price;
            lbCategory.Text = "Thể loại: " + category;
            //lbItemDishManager_howUse.Text = howUse;

            this.id = id;
            this.name = name;
            this.price = price;
            this.howUse = howUse;
            this.pathImage = pathImage;
            this.category =  category;

            // set button
            if(whoUse == "MANAGER")
            {
                btItemDishManager_add.Visible = false;
                btItemDishManager_edit.Click += new System.EventHandler(this.buttonEditClick);
            }else if(whoUse == "EMPLOYEE")
            {
                btItemDishManager_add.Click += new System.EventHandler(this.buttonAddDish);
                btItemDishManager_delete.Visible = false;
                btItemDishManager_edit.Visible = false;
            }
            // set click howUse
            lbItemDishManager_howUse.Click += new System.EventHandler(this.lbHowUseClick);

        }
        private void initilizeConnection()
        {
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
        private void buttonEditClick(object sender, EventArgs args)
        {

            //MessageBox.Show("edit");
            
        }

        private void buttonAddDish(object sender, EventArgs args)
        {
            addDishIntoBill();
        }
        private void addDishIntoBill()
        {
            if (!FrmCustomer.isOrder)
            {
                //for(int i = 0; i < FrmCustomer.PnFrmCustomer_Bill.Controls.Count; i++)
                //{
                //    ItemBill itemBill = (ItemBill)FrmCustomer.PnFrmCustomer_Bill.Controls[i];
                //    for(int j= 0; j < itemBill.Controls.Count; j++)
                //    {
                //        MessageBox.Show(itemBill.Controls[j].Text);
                        
                //    }
                //}


                if (currentIdBill == "") currentIdBill = DateTime.Now.ToString("ddMMyyyyssmmHH").Trim();
                ItemBill item = new ItemBill(id, name, price,
                     howUse, pathImage, category);
                item.Dock = DockStyle.Top;
                FrmCustomer.PnFrmCustomer_Bill.Controls.Add(item);
                //FrmCustomer.listItemBill.Add(new ObjectItemBill(currentIdBill,
                //    id, 1, Convert.ToInt32(price), "", date, FrmCustomer.tableIndex));

                FrmCustomer.setGrandTotalBill();
            }
            else
            {
                MessageBox.Show("Không thể thêm món vào đơn hàng đã đặt");
            }
        }

        private void btItemDishManager_delete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete from " + ManagerTables.Dish + " where id = '" + id + "'";
            cmd.ExecuteNonQuery();
            FrmManager.loadDataDish();
        }

        private void btItemDishManager_edit_Click(object sender, EventArgs e)
        {
            FrmDialogEditDish frm = new FrmDialogEditDish(id);
            frm.ShowDialog();
        }

        private void lbHowUseClick(object sender, EventArgs e)
        {
            MessageBox.Show(howUse);
        }
    }
}
