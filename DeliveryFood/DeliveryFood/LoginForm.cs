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
namespace DeliveryFood
{
    public partial class LoginForm : Form
    {
        static string user2;
        public LoginForm()
        {
            InitializeComponent();
        }
        public static int id;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id FROM Log_identity WHERE username='" + textBoxUsername.Text + "' AND password='" + textBoxPassword.Text + "'", db.getConnection);
            
            string user = textBoxUsername.Text;
            user2 = user;
           
            adapter.Fill(table);
            id = table.Rows[0].Field<int>("Id");
            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rform = new RegisterForm();

            rform.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string getUser()
        {
            return user2;
        }
    }
}
