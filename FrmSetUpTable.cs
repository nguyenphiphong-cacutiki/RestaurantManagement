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
    public partial class FrmSetUpTable : Form
    {
        public FrmSetUpTable()
        {
            InitializeComponent();
        }

        private void btFrmSetUpTable_accept_Click(object sender, EventArgs e)
        {
            FrmCustomer.tableIndex = tbFrmSetUpTable_index.Text;
        }

        private void FrmSetUpTable_Load(object sender, EventArgs e)
        {

        }
    }
}
