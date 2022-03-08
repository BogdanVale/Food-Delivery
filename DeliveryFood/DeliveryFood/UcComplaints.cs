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
    public partial class UcComplaints : UserControl
    {
        public UcComplaints()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string text = textBoxComplaints.Text.Replace(Environment.NewLine, " ");
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            My_DB db = new My_DB();
            SqlCommand cmd = new SqlCommand("INSERT INTO Complaints(Client,Complaint,Date) VALUES(@val1, @val2,@val3)", db.getConnection);
            cmd.Parameters.Add("@val1",LoginForm.id);
            cmd.Parameters.Add("@val2",text);
            cmd.Parameters.Add("@val3",sqlFormattedDate);

            try
            {
                db.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            MessageBox.Show(text);
        }
    }
}
