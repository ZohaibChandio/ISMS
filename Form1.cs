using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ISMSF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string str = "Data Source=DESKTOP-OCHGI6M\\SQLEXPRESS; Initial Catalog=final; Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            //String con = "Data Source=.\\SQLEXPRESS; Initial Catalog=final; Integrated Security=True";
            string q = "Select * From dbofinal Where username=' " + username.Text + "' and password= ' " + password.Text + "'";
            //MessageBox.Show(q);
            SqlCommand command = new SqlCommand(q, con);
            //command.ExecuteNonQuery();
            SqlDataReader sr = command.ExecuteReader();
            if(!sr.Read())
            {
                MessageBox.Show("Welcome...");
                    this.Hide();
                    Form2 f = new Form2();
                    f.Show();
            }
            else
            {
                MessageBox.Show("Invalid...");
            }
            con.Close();
        }



        private void btnadmin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
