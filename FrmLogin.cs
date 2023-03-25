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
    public partial class FrmLogin : Form
    {
        public static string whatFormNeedShow = "";
        private SqlConnection con = null;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataTable dtData;
        public FrmLogin()
        {
            InitializeComponent();
            string sqlConnect = "Data source=MTD-PHONGNP2\\SQLEXPRESS;"
                                + "Initial catalog=BTLWINFORM;"
                                + "Integrated Security=true";
            con = new SqlConnection(sqlConnect);
            con.Open();
            adapter = new SqlDataAdapter("select * from ManagerAccount", con);
            cmd = new SqlCommand();
            cmd.Connection = con;
            dtData = new DataTable();
            adapter.Fill(dtData);
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.MdiParent.ToString());
            //this.MdiParent = null;
            //f.Close();
        }

        private void btFrmLogin_signIn_Click(object sender, EventArgs e)
        {
            string user = tbFrmLogin_user.Text.Trim();
            string pass = tbFrmLogin_pass.Text.Trim();
            cmd.CommandText = "select * from ManagerAccount where mUser = '" + user + "'";
            adapter.SelectCommand = cmd;
            dtData.Clear();
            adapter.Fill(dtData);
            if (dtData.Rows.Count > 0)
            {
                // manager login
                if (dtData.Rows[0][1].ToString().Trim() == pass)
                {
                    // login success
                    ManagerTables.userManager = dtData.Rows[0][0].ToString().Trim();
                    ManagerTables.setUpTableName();
                    whatFormNeedShow = "FrmManager";
                    ManagerShowForm();
                }
                else
                {
                    if(pass == "KHACH_HANG")
                    {
                        ManagerTables.userManager = dtData.Rows[0][0].ToString().Trim();
                        ManagerTables.setUpTableName();
                        whatFormNeedShow = "FrmCustomer";
                        ManagerShowForm();
                    }else
                        MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // not manager or user incorrect
                // check emplyee login
                cmd.CommandText = "select * from EmployeeAccount where mUser = '" + user + "'";
                adapter.SelectCommand = cmd;
                dtData.Clear();
                adapter.Fill(dtData);
                if (dtData.Rows.Count > 0)
                {
                    // employee login
                    //MessageBox.Show(user.Length + "-" + pass.Length+"-"+ dtData.Rows[0][2].ToString().Trim());
                    if (dtData.Rows[0][2].ToString().Trim() == pass)
                    {
                        // login success
                        ManagerTables.userManager = dtData.Rows[0][3].ToString().Trim();
                        ManagerTables.setUpTableName();
                        whatFormNeedShow = "FrmEmployee";
                        ManagerShowForm();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Tên người dùng không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ManagerShowForm()
        {
            while(whatFormNeedShow != "null")
            {
                if(whatFormNeedShow == "FrmSignUp")
                {
                    FrmSignUp frmSignUp = new FrmSignUp();
                    this.Visible = false;
                    frmSignUp.ShowDialog();
                    if (whatFormNeedShow == "FrmSignUp")
                    {
                        Close();
                        break;
                    }
                }
                if (whatFormNeedShow == "FrmManager")
                {
                    FrmManager frmManager = new FrmManager();
                    this.Visible = false;
                    frmManager.ShowDialog();
                    if (whatFormNeedShow == "FrmManager")
                    {
                        Close();
                        break;
                    }
                }
                if (whatFormNeedShow == "FrmEmployee")
                {
                    FrmEmployee frmEmployee = new FrmEmployee();
                    this.Visible = false;
                    frmEmployee.ShowDialog();
                    if (whatFormNeedShow == "FrmEmployee")
                    {
                        Close();
                        break;
                    }
                }


                if (whatFormNeedShow == "FrmLogin")
                {
                    this.Visible = true;
                    break;
                }
                if (whatFormNeedShow == "FrmCustomer")
                {
                    FrmCustomer FrmCustomer = new FrmCustomer();
                    this.Visible = false;
                    FrmCustomer.ShowDialog();
                    if (whatFormNeedShow == "FrmCustomer")
                    {
                        Close();
                        break;
                    }
                }


            }
        }

        private void btFrmLogin_signUp_Click(object sender, EventArgs e)
        {
            whatFormNeedShow = "FrmSignUp";
            ManagerShowForm();
        }

        private void btFrmLogin_custom_Click(object sender, EventArgs e)
        {
            whatFormNeedShow = "FrmCustomer";
            ManagerShowForm();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            ManagerTables.userManager = "b";
            ManagerTables.setUpTableName();
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.ShowDialog();
        }
    }
}
