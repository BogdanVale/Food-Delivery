using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace DeliveryFood
{
    public partial class UcMyOrder : UserControl
    {
        public BindingList<Order> listOrder = new BindingList<Order>();
        public static double price;
        public static double discount;
        public UcMyOrder()
        {
           
           
            InitializeComponent();

           
        }
        public  void getTotalPrice(int t,int y)
        {
            int sum = t;
            double sum1 = y;
            double sum2;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Price"].Value);
                sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells["Discount"].Value);
            }
            labelDiscount.Text = "Total Discount: " + sum1.ToString()+"$";

            labelPrice.Text ="Total Price: "+ sum.ToString()+"$";
            sum2 = sum - sum1;
            
            labelFinalPrice.Text = "Final Price: "+sum2.ToString()+"$";
            price = sum2;
            discount= sum1;
        }
        public static bool comand=false;

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            My_DB db1 = new My_DB();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Orders(Client,Price,Discount) VALUES(@val1, @val2,@val3)", db1.getConnection);
            cmd1.Parameters.Add("@val1", LoginForm.id);
            cmd1.Parameters.Add("@val2", price);
            cmd1.Parameters.Add("@val3", discount);
            try
            {
                db1.OpenConnection();
                cmd1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAX (Id_Order) as lastid FROM Orders", db1.getConnection);

          

            adapter.Fill(table);
            var idorder = table.Rows[0].Field<int>("lastid");



            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                My_DB db = new My_DB();
                SqlCommand cmd = new SqlCommand("INSERT INTO PizzaOrders(Id_pizza,Id_order,Quantity) VALUES(@val1, @val2,@val3)", db.getConnection);
                var name = dataGridView1.Rows[i].Cells["Name"].Value;
                switch(name)
                    {
                    case "Capriciosa" : cmd.Parameters.Add("@val1", 1);
                        break;
                    case "Prosciutto": cmd.Parameters.Add("@val1", 2);
                        break;
                    case "Prosciutto e Funghi":
                        cmd.Parameters.Add("@val1", 3);
                        break;
                    case "Margherita":
                        cmd.Parameters.Add("@val1", 4);
                        break;
                    case "Diavola":
                        cmd.Parameters.Add("@val1", 5);
                        break;
                    case "Rucola":
                        cmd.Parameters.Add("@val1", 6);
                        break;

                }
                
                cmd.Parameters.Add("@val2", idorder);
                cmd.Parameters.Add("@val3", dataGridView1.Rows[i].Cells["Quantity"].Value);
                try
                {
                    db.OpenConnection();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
            FormConfirmComand rform = new FormConfirmComand();
            rform.Show();
            comand = true;
        }
        public bool getcomand()
        {
            return comand;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {    
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if(dataGridView1.Rows[rowIndex].Cells[1].Value!=null)
            dataGridView1.Rows.RemoveAt(rowIndex);

            getTotalPrice(0,0);
        }
        public class Order
        {

            public string  Quantity { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string Discount { get; set; }

        }
        public void setOrder(BindingList<Order> myorder)
        {
            dataGridView1.DataSource = myorder;
        }
    }
}
