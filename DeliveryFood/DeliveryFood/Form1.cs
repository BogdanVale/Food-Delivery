using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryFood
{
    public partial class MainForm : Form
    {       LoginForm lg=new LoginForm();

        static UcMyOrder ucMyOrder = new UcMyOrder();
        UcMenu ucMenu = new UcMenu(ucMyOrder);
        UcFirst ucFirst = new UcFirst(); 
        UcDiscounts ucDiscounts = new UcDiscounts(ucMyOrder);
        UcContact ucContact = new UcContact();
        UcComplaints ucComplaints = new UcComplaints();

        public MainForm()
        {
            
            InitializeComponent();
            addUC(ucFirst);
            labelUser.Text = "Welcome "+lg.getUser();
        }
        private void movesidepanel(Button btn)
        {
            panelMove.Top = btn.Top;
            panelMove.Height = btn.Height;
        }
        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            movesidepanel(buttonDelivery);
            UcDelivery ucDelivery = new UcDelivery();
            addUC(ucDelivery);
        }
       

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            movesidepanel(buttonMenu);
           
            addUC(ucMenu);

        }

        private void buttonMyOrder_Click(object sender, EventArgs e)
        {
            movesidepanel(buttonMyOrder);
            
            addUC(ucMyOrder);
           
        }

        private void buttonDiscounts_Click(object sender, EventArgs e)
        {
            movesidepanel(buttonDiscounts);
          
            addUC(ucDiscounts);
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            movesidepanel(buttonContact);
           
            addUC(ucContact);
        }

        private void buttonComplaints_Click(object sender, EventArgs e)
        {
            movesidepanel(buttonComplaints);
           
            addUC(ucComplaints);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }
        private void addUC(UserControl uc)
        {
            panelCenter.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(uc);

        }

        private void button_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
