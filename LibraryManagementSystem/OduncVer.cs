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

namespace LibraryManagementSystem
{
    public partial class OduncVer : Form
    {
        public OduncVer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM IRBooks WHERE std_enroll= '" + txtEnterEntroll.Text + "'and book_return_date IS NULL";
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds=new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Geçersiz Kayıt Numarası ya da Ödünç Yok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OduncVer_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnterEntroll.Clear();
        }

        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bname;
            txtBookIssueData.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "UPDATE IRBooks SET book_return_date='" + dateTimePicker1.Text + "' WHERE std_enroll='" + txtEnterEntroll.Text + "' and id=" + rowid+"";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Geri dönüş kaydedildi.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            OduncVer_Load(this, null);
        }

        private void txtEnterEntroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEntroll.Text != "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEntroll.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
