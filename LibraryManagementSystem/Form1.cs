using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Kullanýcý Adý")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Þifre")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source= (localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM logintable WHERE username='" + txtUserName.Text + "'and pass='" + txtPassword.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa=new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Hatalý giriþ!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}