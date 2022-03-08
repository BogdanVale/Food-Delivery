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
using System.Net.Mail;

namespace DeliveryFood
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string gender;
            if (radioButtonMale.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("INSERT INTO Log_identity(Username,Password,email,Adress,Gender) VALUES(@val1, @val2,@val3,@val4,@val5)", db.getConnection);
            cmd.Parameters.Add("@val1", textBoxUsername.Text);
            cmd.Parameters.Add("@val2", textBoxPassword.Text);
            cmd.Parameters.Add("@val3", textBoxEmail.Text);
            cmd.Parameters.Add("@val4", textBoxAdress.Text);
            cmd.Parameters.Add("@val5", gender);
            if (textBoxPassword.Text == textBoxRPassword.Text)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(textBoxEmail.Text);
                mail.From = new MailAddress("tester.t22555@gmail.com", "No replay", Encoding.UTF8);
                mail.Subject = "Supreme pizza Register";
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Body = "Your account is ready to use " +
                    "  User: " + textBoxUsername.Text +
                    "   Password: " + textBoxPassword.Text +
                    "";
                mail.BodyEncoding = Encoding.UTF8;

                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("tester.t22555@gmail.com", "Ceamailungaparola1234");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                try
                {
                    client.Send(mail);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }

                try
                {
                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Password not match", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
