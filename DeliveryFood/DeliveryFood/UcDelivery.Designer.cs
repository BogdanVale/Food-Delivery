namespace DeliveryFood
{
    partial class UcDelivery
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDelivery));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBoxAccepted = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccepted)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(431, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(90, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Delivery";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(302, 201);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(339, 32);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Nu aveti nici o comanda";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(139, 476);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(148, 29);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Total Price:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(420, 362);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(194, 29);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time estimated";
            // 
            // pictureBoxAccepted
            // 
            this.pictureBoxAccepted.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccepted.Image")));
            this.pictureBoxAccepted.Location = new System.Drawing.Point(681, 181);
            this.pictureBoxAccepted.Name = "pictureBoxAccepted";
            this.pictureBoxAccepted.Size = new System.Drawing.Size(108, 79);
            this.pictureBoxAccepted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAccepted.TabIndex = 6;
            this.pictureBoxAccepted.TabStop = false;
            // 
            // UcDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxAccepted);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTitle);
            this.Name = "UcDelivery";
            this.Size = new System.Drawing.Size(1010, 549);
            this.Load += new System.EventHandler(this.UcDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccepted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pictureBoxAccepted;
    }
}
