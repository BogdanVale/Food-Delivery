using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeliveryFood.UcMyOrder;

namespace DeliveryFood
{
    public partial class UcMenu : UserControl
    {
        public UcMyOrder myorder;
      
        public UcMenu(UcMyOrder ucMyOrder)
        {   myorder = ucMyOrder; 
            InitializeComponent();
            textBoxCapricioasa.Text = "0";
            textBoxProsciutto.Text = "0";
            textBoxMargheritta.Text = "0";
            textBoxDiavola.Text = "0";
            textBoxProsciuttoeF.Text = "0";
            textBoxRucola.Text = "0";
        }
        
        private void buttonAddCapricioasa_Click(object sender, EventArgs e)
        {
            
            if (textBoxCapricioasa.Text !="0")
            {
                Order order1 = new Order();
                order1.Name = "Capriciosa";
                order1.Quantity = textBoxCapricioasa.Text;
                order1.Price = (int.Parse(textBoxCapricioasa.Text)*5.0).ToString();
                order1.Discount = (double.Parse(order1.Price)*10.0/100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                AddOrderForm rform = new AddOrderForm();
                rform.Show();
                textBoxCapricioasa.Text = "0";
            }

           
        }

        private void buttonMCapricioasa_Click(object sender, EventArgs e)
        {
            if (textBoxCapricioasa.Text == "0")
            {
                textBoxCapricioasa.Text = "0";
            }
            else
            {
                int number = int.Parse(textBoxCapricioasa.Text);
                textBoxCapricioasa.Text = (number - 1).ToString();
            }

        }

        private void buttonMProsciutto_Click(object sender, EventArgs e)
        {
            if (textBoxProsciutto.Text == "0")
            {
                textBoxProsciutto.Text = "0";
            }
            else
            {
                int number = int.Parse(textBoxProsciutto.Text);
                textBoxProsciutto.Text = (number - 1).ToString();
            }
        }

        private void buttonMProsciuttoF_Click(object sender, EventArgs e)
        {
            if (textBoxProsciuttoeF.Text == "0")
            {
                textBoxProsciuttoeF.Text = "0";
            }
            else
            {
                int number = int.Parse(textBoxProsciuttoeF.Text);
                textBoxProsciuttoeF.Text = (number - 1).ToString();
            }
        }

        private void buttonMMargherita_Click(object sender, EventArgs e)
        {
            if (textBoxMargheritta.Text == "0")
            {
                textBoxMargheritta.Text = "0";
            }
            else
            {
                int number = int.Parse(textBoxMargheritta.Text);
                textBoxMargheritta.Text = (number - 1).ToString();
            }
        }

        private void buttonMDiavola_Click(object sender, EventArgs e)
        {
            if (textBoxDiavola.Text == "0")
            {
                textBoxDiavola.Text = "0";
            }
            else
            {
                int number = int.Parse(textBoxDiavola.Text);
                textBoxDiavola.Text = (number - 1).ToString();
            }
        }

        private void buttonMRucola_Click(object sender, EventArgs e)
        {
            if (textBoxRucola.Text == "0")
            {
                textBoxRucola.Text = "0";
            }
            else
            {
                int number = int.Parse(textBoxRucola.Text);
                textBoxRucola.Text = (number - 1).ToString();
            }
        }

        private void buttonPCapricioasa_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxCapricioasa.Text);
            textBoxCapricioasa.Text = (number + 1).ToString();
        }

        private void buttonPProsciutto_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxProsciutto.Text);
            textBoxProsciutto.Text = (number + 1).ToString();
        }

        private void buttonPProsciuttoF_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxProsciuttoeF.Text);
            textBoxProsciuttoeF.Text = (number + 1).ToString();
        }

        private void buttonPMargherita_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxMargheritta.Text);
            textBoxMargheritta.Text = (number + 1).ToString();
        }

        private void buttonPDiavola_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxDiavola.Text);
            textBoxDiavola.Text = (number + 1).ToString();
        }

        private void buttonPRucola_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxRucola.Text);
            textBoxRucola.Text = (number + 1).ToString();
        }

        private void buttonAddProsciutto_Click(object sender, EventArgs e)
        {
            if (textBoxProsciutto.Text != "0")
            {
                Order order1 = new Order();
                order1.Name = "Prosciutto";
                order1.Quantity = textBoxProsciutto.Text;
                order1.Price = (int.Parse(textBoxProsciutto.Text) * 5).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                textBoxProsciutto.Text= "0";    
                AddOrderForm rform = new AddOrderForm();

                rform.Show();
            }
           
        }

        private void buttonAddProsciuttoF_Click(object sender, EventArgs e)
        {
            if (textBoxProsciuttoeF.Text != "0")
            {
                Order order1 = new Order();
                order1.Name = "Prosciutto e Funghi";
                order1.Quantity = textBoxProsciuttoeF.Text;
                order1.Price = (int.Parse(textBoxProsciuttoeF.Text) * 7).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                textBoxProsciuttoeF.Text= "0";
                AddOrderForm rform = new AddOrderForm();

                rform.Show();
            }
            
        }

        private void buttonAddMargherita_Click(object sender, EventArgs e)
        {
            if (textBoxMargheritta.Text != "0")
            {
                Order order1 = new Order();
                order1.Name = "Margherita";
                order1.Quantity = textBoxMargheritta.Text;
                order1.Price = (int.Parse(textBoxMargheritta.Text) * 5).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                textBoxMargheritta.Text= "0";
                AddOrderForm rform = new AddOrderForm();

                rform.Show();
            }
           
        }

        private void buttonAddDiavola_Click(object sender, EventArgs e)
        {
            if (textBoxDiavola.Text != "0")
            {
                Order order1 = new Order();
                order1.Name = "Diavola";
                order1.Quantity = textBoxDiavola.Text;
                order1.Price = (int.Parse(textBoxDiavola.Text) * 6).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                textBoxDiavola.Text= "0";
                AddOrderForm rform = new AddOrderForm();

                rform.Show();
            }
           
        }

        private void buttonAddRucola_Click(object sender, EventArgs e)
        {
            if (textBoxRucola.Text != "0")
            {
                Order order1 = new Order();
                order1.Name = "Rucola";
                order1.Quantity = textBoxRucola.Text;
                order1.Price = (int.Parse(textBoxRucola.Text) * 6).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                textBoxRucola.Text="0";
                AddOrderForm rform = new AddOrderForm();

                rform.Show();
            }
            
        }
    }
}
