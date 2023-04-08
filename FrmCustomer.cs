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
    public partial class FrmCustomer : Form
    {
        public static string tableIndex;
        private SqlConnection con = null;
        private SqlDataAdapter adapterCategory;
        private SqlDataAdapter adapterDish;
        private SqlCommand cmd;
        private DataTable dtCategory;
        private DataTable dtDish;

        private string category = "";
        private Button currentButtonClick = null;
        public static List<ObjectItemBill> listItemBill;
        public static bool isOrder = false;

        Timer timeCancelBill;
        int timeCancel = 150;
        public FrmCustomer()
        {
            InitializeComponent();
            listItemBill = new List<ObjectItemBill>();
            string sqlConnec = "Data source=MTD-PHONGNP2\\SQLEXPRESS;" +
                               "Initial Catalog=BTLWINFORM;" +
                               "Integrated Security=true";
            con = new SqlConnection(sqlConnec);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            adapterCategory = new SqlDataAdapter();
            adapterDish = new SqlDataAdapter();
            dtCategory = new DataTable();
            dtDish = new DataTable();

            timeCancelBill = new Timer();
            timeCancelBill.Tick += new System.EventHandler(this.canCelBill);
        }

        
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            //LbFrmCustomer_Table.Click += new System.EventHandler(this.button1_Click);
            TbFrmCustomer_Search.TextChanged += new System.EventHandler(this.button1_Click);
            // set up đối phó
            //ManagerTables.userManager = "b";
            //ManagerTables.setUpTableName();
            // select category
            lbFrmCustomer_GrandTotalBill.Text = "0";
            cmd.CommandText = "select * from " + ManagerTables.CategoryDish;
            adapterCategory.SelectCommand = cmd;
            dtCategory.Clear();
            adapterCategory.Fill(dtCategory);
            //
            if(dtCategory.Rows.Count > 0)
            {
                // load category
                category = dtCategory.Rows[0][0].ToString().Trim();
                for (int i = dtCategory.Rows.Count - 1; i >= 0; i--)
                {
                    Button bt = new Button();
                    bt.Text = dtCategory.Rows[i][0].ToString().Trim();
                    bt.Dock = DockStyle.Top;
                    bt.BackColor = Color.Gray;
                    if (i == 0)
                    {
                        bt.BackColor = Color.Orange;
                        currentButtonClick = bt;
                    }
                    bt.Click += new EventHandler(this.buttonCategoryClick);
                    PnFrmCustomer_addTable.Controls.Add(bt);

                }

                // load dish default
                
                loadDataForDishList();
                // load combobox and bill
                loadTableListToCombobox();
                loadBillForATable();
            }


        }
        private void buttonCategoryClick(object sender, EventArgs args)
        {
            if (currentButtonClick != null) currentButtonClick.BackColor = Color.Gray;
            Button button = sender as Button;
            currentButtonClick = button;
            button.BackColor = Color.Orange;
            category = button.Text;
            loadDataForDishList();
        }
        private void loadDishForSearchFeature()
        {
            string s = TbFrmCustomer_Search.Text.Trim();
            if (s.Length > 0)
            {
                cmd.CommandText = "select * from " + ManagerTables.Dish + " where Name = '" + s + "'";
                cmd.ExecuteNonQuery();
                dtDish.Clear();
                adapterDish.Fill(dtDish);
                fillAdapterIntoDgvDish();
            }
            
        }
        private void loadDataForDishList()
        {
            cmd.CommandText = "select * from " + ManagerTables.Dish + " where category = '" + category + "'";
            adapterDish.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            dtDish.Clear();
            adapterDish.Fill(dtDish);
      
            fillAdapterIntoDgvDish();
        }
        private void fillAdapterIntoDgvDish()
        {
            tlpFrmCustomer_dishList.Controls.Clear();
            int x = 0, y = 0;
            for(int i = 0; i < dtDish.Rows.Count; i++)
            {

                ItemDish_Manager item = new ItemDish_Manager(dtDish.Rows[i][0].ToString(),
                    dtDish.Rows[i][1].ToString(),
                    dtDish.Rows[i][2].ToString(),
                    dtDish.Rows[i][3].ToString(),
                    dtDish.Rows[i][4].ToString(),
                    dtDish.Rows[i][5].ToString(),
                    "EMPLOYEE");
                item.Dock = DockStyle.Fill;
                tlpFrmCustomer_dishList.Controls.Add(item, x, y);
                x = (x + 1) % 2;
                if (x == 0) y++;
                    
            }
        }

        private void canCelBill(object sender, EventArgs e)
        {
            if(timeCancel == 0)
            {
                   if(PnFrmCustomer_Bill.Controls.Count > 0)
                {
                    for (int i = 0; i < PnFrmCustomer_Bill.Controls.Count; i++)
                    {
                        ItemBill item = (ItemBill)PnFrmCustomer_Bill.Controls[i];

                        // so luong la control 5


                        string amount = item.Controls[5].Text;
                        int granTotal = Convert.ToInt32(item.price) * Convert.ToInt32(amount);
                        string date = DateTime.Now.ToString("yyyy/MM/dd");
                        cmd.CommandText = "insert into " + ManagerTables.NewBill + " values('" + ItemDish_Manager.currentIdBill + "', " +
                            "'" + item.id + "', " +
                            "'" + amount + "', " +
                            "'" + granTotal + "', " +
                            "''," +
                            "'" + date + "'," +
                            "'" + tableIndex + "')";
                        cmd.ExecuteNonQuery();
                    }
                    isOrder = true;
                    loadBillForATable();

                    timeCancelBill.Stop();
                    timeCancel = 150;
                    BtFrmCustomer_DatHang.BackColor = Color.Red;
                    BtFrmCustomer_DatHang.Text = "ĐẶT HÀNG";
                    MessageBox.Show("Đặt hàng thành công!");
                }
                timeCancelBill.Stop();
                timeCancel = 150;
                BtFrmCustomer_DatHang.BackColor = Color.Red;
                BtFrmCustomer_DatHang.Text = "ĐẶT HÀNG";

            }
            else
            {
                timeCancel--;
                BtFrmCustomer_DatHang.Text = "Hủy đơn (" + timeCancel / 10 + " s)";
            }
        }
        private void BtFrmCustomer_DatHang_Click(object sender, EventArgs e)
        {
            if(BtFrmCustomer_DatHang.BackColor != Color.Green)
            {
                if (!isOrder)
                {
                    BtFrmCustomer_DatHang.BackColor = Color.Green;
                    timeCancelBill.Start();
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã đặt!");
                }
            }
            else
            {
                BtFrmCustomer_DatHang.BackColor = Color.Red;
                timeCancelBill.Stop();
                BtFrmCustomer_DatHang.Text = "ĐẶT HÀNG";
                timeCancel = 150;
            }
           
           
            /*if (!isOrder)
            {
                for (int i = 0; i < PnFrmCustomer_Bill.Controls.Count; i++)
                {
                    ItemBill item = (ItemBill)PnFrmCustomer_Bill.Controls[i];

                    // so luong la control 5


                    string amount = item.Controls[5].Text;
                    int granTotal = Convert.ToInt32(item.price) * Convert.ToInt32(amount);
                    string date = DateTime.Now.ToString("yyyy/MM/dd");
                    cmd.CommandText = "insert into " + ManagerTables.NewBill + " values('" + ItemDish_Manager.currentIdBill + "', " +
                        "'" + item.id + "', " +
                        "'" + amount + "', " +
                        "'" + granTotal + "', " +
                        "''," +
                        "'" + date + "'," +
                        "'" + tableIndex + "')";
                    cmd.ExecuteNonQuery();
                }
                isOrder = true;
                MessageBox.Show("Đặt hàng thành công!");
                loadBillForATable();
            }
            else
            {
                MessageBox.Show("Đơn hàng đã đặt!");

            }*/
        }
        public static void setGrandTotalBill()
        {
            int grandTotalBill = 0;
            for (int i = 0; i < PnFrmCustomer_Bill.Controls.Count; i++)
            {
                ItemBill item = (ItemBill)PnFrmCustomer_Bill.Controls[i];
                string amount = item.Controls[5].Text;
                grandTotalBill += Convert.ToInt32(item.price) * Convert.ToInt32(amount);
            }
            lbFrmCustomer_GrandTotalBill.Text = grandTotalBill + "";
            //MessageBox.Show("set grand total bill-" + PnFrmCustomer_Bill.Controls.Count);
        }

        private void LbFrmCustomer_Phanloai_Click(object sender, EventArgs e)
        {
            FrmLogin.whatFormNeedShow = "FrmLogin";
            Close();
        }
        private void loadTableListToCombobox()
        {
            DataTable dt = new DataTable();
            string sql = "select * from " + ManagerTables.TableList;
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cbTableList.Items.Add(dt.Rows[i][0]);
            }

            if (dt.Rows.Count > 0)
            {
                cbTableList.Text = dt.Rows[0][0].ToString();
                tableIndex = cbTableList.Text;
            } 
                
        }
        private void loadBillForATable()
        {
            PnFrmCustomer_Bill.Enabled = true;
            string table = cbTableList.Text;

            DataTable dt = new DataTable();
            string sql = "select N.id, name, price, status, amount, pathImage from " + ManagerTables.NewBill + " N inner join "+ManagerTables.Dish + " D on N.idMon = D.id where indexTable = '"+table+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            PnFrmCustomer_Bill.Controls.Clear();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ItemBill item = new ItemBill(dt.Rows[i][0].ToString().Trim(), dt.Rows[i][1].ToString().Trim(),
                    dt.Rows[i][2].ToString().Trim(), dt.Rows[i][3].ToString().Trim(), Convert.ToInt32(dt.Rows[i][4].ToString().Trim()), dt.Rows[i][5].ToString().Trim());
                item.Dock = DockStyle.Top;
                item.Enabled = false;

                PnFrmCustomer_Bill.Controls.Add(item);
            }
            if (PnFrmCustomer_Bill.Controls.Count > 0) isOrder = true;
            else isOrder = false;

        }

        private void cbTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableIndex = cbTableList.Text;
            LbFrmCustomer_Table.Text = "Bàn "+tableIndex;
            loadBillForATable();
            setGrandTotalBill();
        }

        private void BtFrmCustomer_Thanhtoan_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update Support set mSupport = N'Thanh toán'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã yêu cầu thanh toán!");
        }

        private void BtFrmCustomer_Hotro_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update Support set mSupport = N'Hỗ trợ'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã yêu cầu hỗ trợ!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("tìm kiếm");
            loadDishForSearchFeature();
        }
    }
}
