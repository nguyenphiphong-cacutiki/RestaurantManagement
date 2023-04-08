using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup03_63KTPM2_Version01
{
    public partial class ItemBill : UserControl
    {
        public string id;
        public string idMon;
        public string name;
        public string price;
        public string howUse;
        public string pathImage;
        public string category;
        public string status;

        public int amount = 0;
        public ItemBill()
        {
            InitializeComponent();
            
        }
        public ItemBill(string id, string name, string price, string howUse, string pathImage,
            string category)
        {
            InitializeComponent();
            // assign value for controls of item
            pbItemBill_pic.Image = Image.FromFile(pathImage);
            lbItemBill_name.Text = name;
            lbItemBill_price.Text = price;
            lbItemBill_status.Text = "";
            lbItemBill_amount.Text = "1";
            btItemBill_plus.Enabled = true;
            btItemBill_minus.Enabled = true;
            

            //
            this.id = id;
            this.name = name;
            this.price = price;
            this.howUse = howUse;
            this.pathImage = pathImage;
            this.category = category;
            amount = 1;
        }
        public ItemBill(string id, string name, string price, string status, int amount, string pathImage)
        {
            InitializeComponent();

            this.amount = amount;
            this.price = price;
            this.name = name;
            this.pathImage = pathImage;
            this.status = status;
            // assign value for controls of item
            pbItemBill_pic.Image = Image.FromFile(pathImage);
            lbItemBill_name.Text = name;
            lbItemBill_price.Text = price;
            lbItemBill_status.Text = status;
            lbItemBill_amount.Text = amount + "";

        }

            private void btItemBill_plus_Click(object sender, EventArgs e)
        {
            amount++;
            lbItemBill_amount.Text = amount + "";
            FrmCustomer.setGrandTotalBill();
        }

        private void btItemBill_minus_Click(object sender, EventArgs e)
        {
            if(amount > 1)
            {
                amount--;
                lbItemBill_amount.Text = amount + "";
                FrmCustomer.setGrandTotalBill();

            }
            else
            {
                FrmCustomer.PnFrmCustomer_Bill.Controls.Remove(this);
                FrmCustomer.setGrandTotalBill();
            }
        }

        private void btItemBill_delete_Click(object sender, EventArgs e)
        {
            FrmCustomer.PnFrmCustomer_Bill.Controls.Remove(this);
        }
    }
}
