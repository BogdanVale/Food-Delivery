namespace DeliveryFood
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMove = new System.Windows.Forms.Panel();
            this.buttonContact = new System.Windows.Forms.Button();
            this.buttonDiscounts = new System.Windows.Forms.Button();
            this.buttonMyOrder = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonComplaints = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DimGray;
            this.panelLeft.Controls.Add(this.buttonMenu);
            this.panelLeft.Controls.Add(this.buttonContact);
            this.panelLeft.Controls.Add(this.buttonDelivery);
            this.panelLeft.Controls.Add(this.buttonComplaints);
            this.panelLeft.Controls.Add(this.buttonMyOrder);
            this.panelLeft.Controls.Add(this.panelMove);
            this.panelLeft.Controls.Add(this.buttonDiscounts);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(212, 618);
            this.panelLeft.TabIndex = 1;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.SlateBlue;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(15, 92);
            this.panelMove.TabIndex = 19;
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonContact.FlatAppearance.BorderSize = 0;
            this.buttonContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContact.ForeColor = System.Drawing.Color.DimGray;
            this.buttonContact.Image = ((System.Drawing.Image)(resources.GetObject("buttonContact.Image")));
            this.buttonContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContact.Location = new System.Drawing.Point(12, 294);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(200, 92);
            this.buttonContact.TabIndex = 12;
            this.buttonContact.Text = "Contact";
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // buttonDiscounts
            // 
            this.buttonDiscounts.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonDiscounts.FlatAppearance.BorderSize = 0;
            this.buttonDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscounts.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDiscounts.Image = ((System.Drawing.Image)(resources.GetObject("buttonDiscounts.Image")));
            this.buttonDiscounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDiscounts.Location = new System.Drawing.Point(12, 392);
            this.buttonDiscounts.Name = "buttonDiscounts";
            this.buttonDiscounts.Size = new System.Drawing.Size(200, 92);
            this.buttonDiscounts.TabIndex = 10;
            this.buttonDiscounts.Text = "Discounts";
            this.buttonDiscounts.UseVisualStyleBackColor = false;
            this.buttonDiscounts.Click += new System.EventHandler(this.buttonDiscounts_Click);
            // 
            // buttonMyOrder
            // 
            this.buttonMyOrder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonMyOrder.FlatAppearance.BorderSize = 0;
            this.buttonMyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyOrder.ForeColor = System.Drawing.Color.DimGray;
            this.buttonMyOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonMyOrder.Image")));
            this.buttonMyOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyOrder.Location = new System.Drawing.Point(15, 98);
            this.buttonMyOrder.Name = "buttonMyOrder";
            this.buttonMyOrder.Size = new System.Drawing.Size(200, 92);
            this.buttonMyOrder.TabIndex = 11;
            this.buttonMyOrder.Text = "My order";
            this.buttonMyOrder.UseVisualStyleBackColor = false;
            this.buttonMyOrder.Click += new System.EventHandler(this.buttonMyOrder_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.Color.DimGray;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(15, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(197, 92);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonDelivery.FlatAppearance.BorderSize = 0;
            this.buttonDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelivery.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDelivery.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelivery.Image")));
            this.buttonDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelivery.Location = new System.Drawing.Point(12, 196);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Size = new System.Drawing.Size(200, 92);
            this.buttonDelivery.TabIndex = 9;
            this.buttonDelivery.Text = "Delivery";
            this.buttonDelivery.UseVisualStyleBackColor = false;
            this.buttonDelivery.Click += new System.EventHandler(this.buttonDelivery_Click);
            // 
            // buttonComplaints
            // 
            this.buttonComplaints.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonComplaints.FlatAppearance.BorderSize = 0;
            this.buttonComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComplaints.ForeColor = System.Drawing.Color.DimGray;
            this.buttonComplaints.Image = ((System.Drawing.Image)(resources.GetObject("buttonComplaints.Image")));
            this.buttonComplaints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComplaints.Location = new System.Drawing.Point(12, 490);
            this.buttonComplaints.Name = "buttonComplaints";
            this.buttonComplaints.Size = new System.Drawing.Size(206, 94);
            this.buttonComplaints.TabIndex = 13;
            this.buttonComplaints.Text = "Complaints";
            this.buttonComplaints.UseVisualStyleBackColor = false;
            this.buttonComplaints.Click += new System.EventHandler(this.buttonComplaints_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(212, 71);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(981, 547);
            this.panelCenter.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(33, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Supreme Pizza";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(469, 18);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(210, 32);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Welcome User";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.button_exit);
            this.panelTop.Controls.Add(this.labelUser);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(212, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(981, 71);
            this.panelTop.TabIndex = 2;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.DimGray;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.DimGray;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(914, -4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(67, 69);
            this.button_exit.TabIndex = 7;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 618);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonDiscounts;
        private System.Windows.Forms.Button buttonComplaints;
        private System.Windows.Forms.Button buttonContact;
        private System.Windows.Forms.Button buttonMyOrder;
        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button_exit;
    }
}

