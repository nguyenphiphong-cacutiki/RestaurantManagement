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
    public partial class FrmSignUp : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataTable dtData;
        public FrmSignUp()
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

        private void dangki_Load(object sender, EventArgs e)
        {

        }

        private void btFrmSignUp_signUp_Click(object sender, EventArgs e)
        {
            string user = tbFrmSignUp_user.Text.Trim();
            string password = tbFrmSignUp_pass.Text.Trim();
            string confirmPassword = tbFrmSignUp_confirmPass.Text.Trim();

            if(user.Length > 0 && password.Length > 0 && password == confirmPassword)
            {
                cmd.CommandText = "select * from ManagerAccount where mUser = '" + user + "'";
                adapter.SelectCommand = cmd;
                dtData.Clear();
                adapter.Fill(dtData);
                if (dtData.Rows.Count > 0)
                {
                    lbFrmSignUp_inform.Text = "Tên người dùng đã tồn tại";
                    lbFrmSignUp_inform.Visible = true;
                }
                else
                {
                    lbFrmSignUp_inform.Visible = false;
                    cmd.CommandText = "insert into ManagerAccount values('" + user + "', '" + password + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // create table default for database 
                    ManagerTables.userManager = user;
                    ManagerTables.createTable();

                    // return frm sign in
                    FrmLogin.whatFormNeedShow = "FrmLogin";
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void passChange(object sender, EventArgs args)
        {
            if(tbFrmSignUp_pass.Text.Trim() != tbFrmSignUp_confirmPass.Text.Trim())
            {
                lbFrmSignUp_inform.Visible = true;
                lbFrmSignUp_inform.Text = "Mật khẩu chưa trùng khớp!";
            }
            else
            {
                lbFrmSignUp_inform.Visible = false;
            }
        }
    }
}
