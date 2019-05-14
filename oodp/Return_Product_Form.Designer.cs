namespace oodp
{
    partial class Return_Product_Form
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Select_Bill_ID_for_return_bill = new System.Windows.Forms.ComboBox();
            this.dataGridView_for_return_Products = new System.Windows.Forms.DataGridView();
            this.label_return = new System.Windows.Forms.Label();
            this.textBox_product_name = new System.Windows.Forms.TextBox();
            this.dataGridView_Product_name = new System.Windows.Forms.DataGridView();
            this.Ok_button_Product_name = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_return_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product_name)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bill ID :";
            // 
            // Select_Bill_ID_for_return_bill
            // 
            this.Select_Bill_ID_for_return_bill.FormattingEnabled = true;
            this.Select_Bill_ID_for_return_bill.Location = new System.Drawing.Point(247, 24);
            this.Select_Bill_ID_for_return_bill.Name = "Select_Bill_ID_for_return_bill";
            this.Select_Bill_ID_for_return_bill.Size = new System.Drawing.Size(121, 21);
            this.Select_Bill_ID_for_return_bill.TabIndex = 32;
            this.Select_Bill_ID_for_return_bill.SelectedIndexChanged += new System.EventHandler(this.Select_Bill_ID_for_return_bill_SelectedIndexChanged);
            // 
            // dataGridView_for_return_Products
            // 
            this.dataGridView_for_return_Products.AllowUserToAddRows = false;
            this.dataGridView_for_return_Products.AllowUserToDeleteRows = false;
            this.dataGridView_for_return_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_for_return_Products.Location = new System.Drawing.Point(9, 103);
            this.dataGridView_for_return_Products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_for_return_Products.Name = "dataGridView_for_return_Products";
            this.dataGridView_for_return_Products.ReadOnly = true;
            this.dataGridView_for_return_Products.RowTemplate.Height = 24;
            this.dataGridView_for_return_Products.Size = new System.Drawing.Size(483, 243);
            this.dataGridView_for_return_Products.TabIndex = 33;
            // 
            // label_return
            // 
            this.label_return.AutoSize = true;
            this.label_return.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.Location = new System.Drawing.Point(6, 58);
            this.label_return.Name = "label_return";
            this.label_return.Size = new System.Drawing.Size(305, 19);
            this.label_return.TabIndex = 35;
            this.label_return.Text = "Please write the product u want to return:";
            // 
            // textBox_product_name
            // 
            this.textBox_product_name.Location = new System.Drawing.Point(314, 62);
            this.textBox_product_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_product_name.Name = "textBox_product_name";
            this.textBox_product_name.Size = new System.Drawing.Size(86, 20);
            this.textBox_product_name.TabIndex = 36;
            this.textBox_product_name.TextChanged += new System.EventHandler(this.textBox_product_name_TextChanged);
            // 
            // dataGridView_Product_name
            // 
            this.dataGridView_Product_name.AllowUserToAddRows = false;
            this.dataGridView_Product_name.AllowUserToDeleteRows = false;
            this.dataGridView_Product_name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product_name.Location = new System.Drawing.Point(508, 103);
            this.dataGridView_Product_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Product_name.Name = "dataGridView_Product_name";
            this.dataGridView_Product_name.ReadOnly = true;
            this.dataGridView_Product_name.RowTemplate.Height = 24;
            this.dataGridView_Product_name.Size = new System.Drawing.Size(130, 243);
            this.dataGridView_Product_name.TabIndex = 37;
            // 
            // Ok_button_Product_name
            // 
            this.Ok_button_Product_name.Location = new System.Drawing.Point(427, 62);
            this.Ok_button_Product_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ok_button_Product_name.Name = "Ok_button_Product_name";
            this.Ok_button_Product_name.Size = new System.Drawing.Size(38, 19);
            this.Ok_button_Product_name.TabIndex = 38;
            this.Ok_button_Product_name.Text = "OK";
            this.Ok_button_Product_name.UseVisualStyleBackColor = true;
            this.Ok_button_Product_name.Click += new System.EventHandler(this.Ok_button_Product_name_Click);
            // 
            // Return_Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 356);
            this.Controls.Add(this.Ok_button_Product_name);
            this.Controls.Add(this.dataGridView_Product_name);
            this.Controls.Add(this.textBox_product_name);
            this.Controls.Add(this.label_return);
            this.Controls.Add(this.dataGridView_for_return_Products);
            this.Controls.Add(this.Select_Bill_ID_for_return_bill);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Return_Product_Form";
            this.Text = "Return_Product_Form";
            this.Load += new System.EventHandler(this.Return_Product_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_for_return_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product_name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Select_Bill_ID_for_return_bill;
        public System.Windows.Forms.DataGridView dataGridView_for_return_Products;
        public System.Windows.Forms.Label label_return;
        public System.Windows.Forms.TextBox textBox_product_name;
        public System.Windows.Forms.DataGridView dataGridView_Product_name;
        public System.Windows.Forms.Button Ok_button_Product_name;
    }
}