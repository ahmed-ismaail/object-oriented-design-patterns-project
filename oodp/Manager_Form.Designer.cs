namespace oodp
{
    partial class Manager_Form
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
            this.View_Products_for_manager = new System.Windows.Forms.Button();
            this.Remove_delivery_boy = new System.Windows.Forms.Button();
            this.Add_Delivery_boy = new System.Windows.Forms.Button();
            this.View_All_bills = new System.Windows.Forms.Button();
            this.View_bill_for_one_customer = new System.Windows.Forms.Button();
            this.View_bill_for_date = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // View_Products_for_manager
            // 
            this.View_Products_for_manager.Location = new System.Drawing.Point(123, 47);
            this.View_Products_for_manager.Name = "View_Products_for_manager";
            this.View_Products_for_manager.Size = new System.Drawing.Size(140, 57);
            this.View_Products_for_manager.TabIndex = 0;
            this.View_Products_for_manager.Text = "View_Products";
            this.View_Products_for_manager.UseVisualStyleBackColor = true;
            this.View_Products_for_manager.Click += new System.EventHandler(this.View_Products_for_manager_Click);
            // 
            // Remove_delivery_boy
            // 
            this.Remove_delivery_boy.Location = new System.Drawing.Point(123, 195);
            this.Remove_delivery_boy.Name = "Remove_delivery_boy";
            this.Remove_delivery_boy.Size = new System.Drawing.Size(140, 57);
            this.Remove_delivery_boy.TabIndex = 1;
            this.Remove_delivery_boy.Text = "Remove_Delivery_Boy";
            this.Remove_delivery_boy.UseVisualStyleBackColor = true;
            this.Remove_delivery_boy.Click += new System.EventHandler(this.Remove_delivery_boy_Click);
            // 
            // Add_Delivery_boy
            // 
            this.Add_Delivery_boy.Location = new System.Drawing.Point(123, 121);
            this.Add_Delivery_boy.Name = "Add_Delivery_boy";
            this.Add_Delivery_boy.Size = new System.Drawing.Size(140, 57);
            this.Add_Delivery_boy.TabIndex = 2;
            this.Add_Delivery_boy.Text = "Add_Delivery_Boy";
            this.Add_Delivery_boy.UseVisualStyleBackColor = true;
            this.Add_Delivery_boy.Click += new System.EventHandler(this.Add_Delivery_boy_Click);
            // 
            // View_All_bills
            // 
            this.View_All_bills.Location = new System.Drawing.Point(123, 273);
            this.View_All_bills.Name = "View_All_bills";
            this.View_All_bills.Size = new System.Drawing.Size(140, 57);
            this.View_All_bills.TabIndex = 3;
            this.View_All_bills.Text = "View_All_bills";
            this.View_All_bills.UseVisualStyleBackColor = true;
            this.View_All_bills.Click += new System.EventHandler(this.View_All_bills_Click);
            // 
            // View_bill_for_one_customer
            // 
            this.View_bill_for_one_customer.Location = new System.Drawing.Point(123, 346);
            this.View_bill_for_one_customer.Name = "View_bill_for_one_customer";
            this.View_bill_for_one_customer.Size = new System.Drawing.Size(140, 57);
            this.View_bill_for_one_customer.TabIndex = 4;
            this.View_bill_for_one_customer.Text = "View Bill For Customer";
            this.View_bill_for_one_customer.UseVisualStyleBackColor = true;
            this.View_bill_for_one_customer.Click += new System.EventHandler(this.View_bill_for_one_customer_Click);
            // 
            // View_bill_for_date
            // 
            this.View_bill_for_date.Location = new System.Drawing.Point(123, 429);
            this.View_bill_for_date.Name = "View_bill_for_date";
            this.View_bill_for_date.Size = new System.Drawing.Size(140, 57);
            this.View_bill_for_date.TabIndex = 5;
            this.View_bill_for_date.Text = "View Bill For specific Date";
            this.View_bill_for_date.UseVisualStyleBackColor = true;
            this.View_bill_for_date.Click += new System.EventHandler(this.View_bill_for_date_Click);
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 498);
            this.Controls.Add(this.View_bill_for_date);
            this.Controls.Add(this.View_bill_for_one_customer);
            this.Controls.Add(this.View_All_bills);
            this.Controls.Add(this.Add_Delivery_boy);
            this.Controls.Add(this.Remove_delivery_boy);
            this.Controls.Add(this.View_Products_for_manager);
            this.Name = "Manager_Form";
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button View_Products_for_manager;
        private System.Windows.Forms.Button Remove_delivery_boy;
        private System.Windows.Forms.Button Add_Delivery_boy;
        private System.Windows.Forms.Button View_All_bills;
        private System.Windows.Forms.Button View_bill_for_one_customer;
        private System.Windows.Forms.Button View_bill_for_date;
    }
}