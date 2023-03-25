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
    public partial class FrmManagerCategory : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private DataTable dtCategory;

        private int idRow = -1;
        private string oldCategory = "";
        public FrmManagerCategory()
        {
            InitializeComponent();
            string sqlConnec = "Data source=MTD-PHONGNP2\\SQLEXPRESS;" +
                               "Initial Catalog=BTLWINFORM;" +
                               "Integrated Security=true";
            con = new SqlConnection(sqlConnec);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            adapter = new SqlDataAdapter();
            dtCategory = new DataTable();

        }

        private void FrmManagerCategory_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from " + ManagerTables.CategoryDish;
            adapter.SelectCommand = cmd;
            dtCategory.Clear();
            adapter.Fill(dtCategory);
            dtCategory.Columns[0].ColumnName = "Tên thể loại";
            dtgvFrmManagerCaterory.DataSource = dtCategory;
        }

        private void btFrmManagerCaterory_add_Click(object sender, EventArgs e)
        {
            string category = tbFrmManagerCaterory_input.Text.Trim();
            cmd.CommandText = "select * from " + ManagerTables.CategoryDish+" where mName = '"+category+"'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable data = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(data);
            if (data.Rows.Count == 0 && category.Length>0)
            {
                cmd.CommandText = "insert into " + ManagerTables.CategoryDish + " values(N'"+tbFrmManagerCaterory_input.Text.Trim()+"')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select * from " + ManagerTables.CategoryDish;
                adapter.SelectCommand = cmd;
                dtCategory.Clear();
                dtCategory.Columns[0].ColumnName = "mName";
                adapter.Fill(dtCategory);
                dtCategory.Columns[0].ColumnName = "Tên thể loại";
            }
            else
            {
                MessageBox.Show("Thể loại này đã tồn tại hoặc tên món không hợp lệ");
            }
        }

        private void btFrmManagerCaterory_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string category = tbFrmManagerCaterory_input.Text.Trim();
                cmd.CommandText = "update " + ManagerTables.CategoryDish + " set mName = N'" + tbFrmManagerCaterory_input.Text.Trim() + "' where mName = '"+ oldCategory + "'";
                cmd.ExecuteNonQuery();
                dtCategory.Rows[idRow][0] = category;
            }
            catch (Exception) { }
        }

        private void dtgvFrmManagerCaterory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idRow = e.RowIndex;
            try
            {
                tbFrmManagerCaterory_input.Text = dtCategory.Rows[idRow][0].ToString();
                oldCategory = dtCategory.Rows[idRow][0].ToString();
            }
            catch (Exception)
            {

            }

        }

        private void btFrmManagerCaterory_delete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete from " + ManagerTables.CategoryDish + " where mName = '" + oldCategory + "'";
                cmd.ExecuteNonQuery();
                dtCategory.Rows.RemoveAt(idRow);
            }
            catch (Exception) { }
        }
    }
}
