using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class OduncAlma : Form
    {
        public OduncAlma()
        {
            InitializeComponent();
        }

        private void OduncAlma_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd= new SqlCommand("SELECT bName FROM NewBook",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                for(int i=0;i<dr.FieldCount;i++)
                {
                    comboBoxBooks.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            conn.Close();
        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnroll.Text != "")
            {
                String eid=txtEnroll.Text;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "SELECT * FROM NewStudent WHERE enroll= '" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds= new DataSet();
                da.Fill(ds);

                cmd.CommandText = "SELECT count(std_enroll) FROM IRBooks WHERE std_enroll= '" + eid + "'and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCont.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMail.Text = ds.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtCont.Clear();
                    txtMail.Clear();
                    MessageBox.Show("Geçersiz Kayıt Numarası!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if(comboBoxBooks.SelectedIndex != -1 && count<=2)
                {
                    String enroll=txtEnroll.Text;
                    String sname=txtName.Text;
                    String sdep=txtDep.Text;
                    String ssem=txtSem.Text;
                    Int64 contact=Int64.Parse(txtCont.Text);
                    String email=txtMail.Text;
                    String bookname = comboBoxBooks.Text;
                    String bookIssueDate = dateTimePicker1.Text;

                    String eid = txtEnroll.Text;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "INSERT INTO IRBooks(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values ('" + enroll + "','" + sname + "','" + sdep + "','" + ssem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookIssueDate + "')";
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Kitap ödünç alındı.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seçili kitap ya da fazla kitap alma hatası", "No Book Seleceted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kayıt numaranızı giriniz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtEnroll.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtCont.Clear();
                txtMail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istiyor musunuz?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
