using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class OgrencileriGoruntule : Form
    {
        public OgrencileriGoruntule()
        {
            InitializeComponent();
        }

        private void OgrencileriGoruntule_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB ; Database=master; Integrated Security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnroll.Text != "")
            {
                label1.Visible=true;
                Image image= Image.FromFile("C:\\Users\\daphn\\OneDrive\\Masaüstü\\proje\\search1.gif");
                pictureBox1.Image = image;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB ; Database=master; Integrated Security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM NewStudent WHERE enroll LIKE '"+txtSearchEnroll.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible = true;
                Image image = Image.FromFile("C:\\Users\\daphn\\OneDrive\\Masaüstü\\proje\\search.gif");
                pictureBox1.Image = image;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB ; Database=master; Integrated Security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB ; Database=master; Integrated Security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM NewStudent WHERE stuid="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCont.Text = ds.Tables[0].Rows[0][5].ToString();
            txtMail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String sName = txtSName.Text;
            String enroll=txtEnrollment.Text;
            String dep=txtDep.Text;
            String sem=txtSem.Text;
            Int64 contact=Int64.Parse(txtCont.Text);
            String semail=txtMail.Text;

            if (MessageBox.Show("Bilgiler güncellenecektir.Onaylıyor musunuz?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB ; Database=master; Integrated Security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE NewStudent SET sname= '" + sName + "',enroll='" + enroll + "',dep= '" + dep + "',sem='" + sem + "',contact=" + contact + ",email='" + semail + "' WHERE stuid= " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                OgrencileriGoruntule_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OgrencileriGoruntule_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bilgiler silinecektir.Onaylıyor musunuz?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB ; Database=master; Integrated Security= True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "DELETE FROM NewStudent WHERE stuid= " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                OgrencileriGoruntule_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kaydedilmeyen bilgiler silinecektir.","Onaylıyor musunuz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
