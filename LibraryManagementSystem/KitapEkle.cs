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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bilgiler kaydedilmeden silinecektir.","Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {

                String bName = txtBookName.Text;
                String bAuthor = txtAuthor.Text;
                String publication = txtPublication.Text;
                String pDate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                Int64 quan = Int64.Parse(txtQuantity.Text);

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database= master; Integrated Security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "INSERT INTO NewBook (bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bName + "','" + bAuthor + "','" + publication + "','" + pDate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kitap kaydedildi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Boş alan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
