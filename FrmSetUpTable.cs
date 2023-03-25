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
    public partial class FrmSetUpTable : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adapS = null;
        DataTable dtTableList_Setup = null;
        bool check = true;
        public FrmSetUpTable()
        {
            InitializeComponent();
        }

        private void FrmSetUpTable_Load(object sender, EventArgs e)
        {
            string cont = "Data Source = MTD-PHONGNP2\\SQLEXPRESS;" +
                         "Initial catalog = BTLWINFORM;" +
                         "Integrated Security = true";
            con = new SqlConnection(cont);
            con.Open();
        }

        private void btFrmSetUpTable_accept_Click(object sender, EventArgs e)
        {
            check = true;
            if (tbFrmSetUpTable_index.Text == "") 
            {
                MessageBox.Show("Vui lòng nhập số hiệu bàn", "Thông báo", MessageBoxButtons.OK);
                check = false;
            }
            
            string adaS = "Select * from "+ManagerTables.TableList;
            adapS = new SqlDataAdapter(adaS, con);
            dtTableList_Setup = new DataTable();
            adapS.Fill(dtTableList_Setup);
            for (int i = 0; i < dtTableList_Setup.Rows.Count; i++)
            {
                if (tbFrmSetUpTable_index.Text.Trim() == dtTableList_Setup.Rows[i][0].ToString().Trim())
                {
                    MessageBox.Show("Số hiệu bàn đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    tbFrmSetUpTable_index.Text = "";
                    check = false;
                    break;
                }
            }
            if(check == true)
            {
                string cmd = "Insert into "+ManagerTables.TableList+" values ('" + tbFrmSetUpTable_index.Text.Trim() + "')";
                FrmEmployee.command.CommandText = cmd;
                FrmEmployee.command.ExecuteNonQuery();
                dtTableList_Setup.Clear();
                adapS.Fill(dtTableList_Setup);
                FrmCustomer.tableIndex = tbFrmSetUpTable_index.Text;
                MessageBox.Show("Thiết lập thành công", "Thông báo", MessageBoxButtons.OK);
                Close();
            }
        }

        
    }
}
