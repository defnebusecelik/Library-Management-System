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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Onaylıyor musunuz?","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtMail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEnrollment.Text != "" && txtDepartment.Text != "" && txtSemester.Text != "" && txtContact.Text != "" && txtMail.Text != "")
            {
                String name = txtName.Text;
                String enroll = txtEnrollment.Text;
                String dep = txtDepartment.Text;
                String sem = txtSemester.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String email = txtMail.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "INSERT INTO NewStudent (sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Bilgiler kaydedildi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz","Suggest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
