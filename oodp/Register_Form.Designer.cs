namespace oodp
{
    partial class Register_Form
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
            this.name_txt_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_txt_box = new System.Windows.Forms.TextBox();
            this.address_txt_box = new System.Windows.Forms.TextBox();
            this.email_txt_box = new System.Windows.Forms.TextBox();
            this.phone_txt_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password_txt_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Manager_rdo_Button = new System.Windows.Forms.RadioButton();
            this.Customer_rdo_Button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // name_txt_box
            // 
            this.name_txt_box.Location = new System.Drawing.Point(125, 68);
            this.name_txt_box.Name = "name_txt_box";
            this.name_txt_box.Size = new System.Drawing.Size(191, 20);
            this.name_txt_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // Id_txt_box
            // 
            this.Id_txt_box.Location = new System.Drawing.Point(125, 115);
            this.Id_txt_box.Name = "Id_txt_box";
            this.Id_txt_box.Size = new System.Drawing.Size(191, 20);
            this.Id_txt_box.TabIndex = 2;
            // 
            // address_txt_box
            // 
            this.address_txt_box.Location = new System.Drawing.Point(125, 156);
            this.address_txt_box.Name = "address_txt_box";
            this.address_txt_box.Size = new System.Drawing.Size(191, 20);
            this.address_txt_box.TabIndex = 3;
            // 
            // email_txt_box
            // 
            this.email_txt_box.Location = new System.Drawing.Point(125, 202);
            this.email_txt_box.Name = "email_txt_box";
            this.email_txt_box.Size = new System.Drawing.Size(191, 20);
            this.email_txt_box.TabIndex = 4;
            // 
            // phone_txt_box
            // 
            this.phone_txt_box.Location = new System.Drawing.Point(125, 252);
            this.phone_txt_box.Name = "phone_txt_box";
            this.phone_txt_box.Size = new System.Drawing.Size(191, 20);
            this.phone_txt_box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(45, 163);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(46, 13);
            this.address_label.TabIndex = 7;
            this.address_label.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(45, 259);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(37, 13);
            this.phone_label.TabIndex = 9;
            this.phone_label.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // password_txt_box
            // 
            this.password_txt_box.Location = new System.Drawing.Point(125, 296);
            this.password_txt_box.Name = "password_txt_box";
            this.password_txt_box.Size = new System.Drawing.Size(191, 20);
            this.password_txt_box.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Manager_rdo_Button
            // 
            this.Manager_rdo_Button.AutoSize = true;
            this.Manager_rdo_Button.Location = new System.Drawing.Point(48, 354);
            this.Manager_rdo_Button.Name = "Manager_rdo_Button";
            this.Manager_rdo_Button.Size = new System.Drawing.Size(67, 17);
            this.Manager_rdo_Button.TabIndex = 13;
            this.Manager_rdo_Button.Text = "Manager";
            this.Manager_rdo_Button.UseVisualStyleBackColor = true;
            this.Manager_rdo_Button.CheckedChanged += new System.EventHandler(this.Manager_rdo_Button_CheckedChanged);
            // 
            // Customer_rdo_Button
            // 
            this.Customer_rdo_Button.AutoSize = true;
            this.Customer_rdo_Button.Checked = true;
            this.Customer_rdo_Button.Location = new System.Drawing.Point(48, 377);
            this.Customer_rdo_Button.Name = "Customer_rdo_Button";
            this.Customer_rdo_Button.Size = new System.Drawing.Size(71, 17);
            this.Customer_rdo_Button.TabIndex = 14;
            this.Customer_rdo_Button.TabStop = true;
            this.Customer_rdo_Button.Text = "Customer";
            this.Customer_rdo_Button.UseVisualStyleBackColor = true;
            this.Customer_rdo_Button.CheckedChanged += new System.EventHandler(this.Customer_rdo_Button_CheckedChanged);
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 403);
            this.Controls.Add(this.Customer_rdo_Button);
            this.Controls.Add(this.Manager_rdo_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password_txt_box);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone_txt_box);
            this.Controls.Add(this.email_txt_box);
            this.Controls.Add(this.address_txt_box);
            this.Controls.Add(this.Id_txt_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txt_box);
            this.Name = "Register_Form";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox name_txt_box;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Id_txt_box;
        public System.Windows.Forms.TextBox address_txt_box;
        public System.Windows.Forms.TextBox email_txt_box;
        public System.Windows.Forms.TextBox phone_txt_box;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label address_label;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label phone_label;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox password_txt_box;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Manager_rdo_Button;
        private System.Windows.Forms.RadioButton Customer_rdo_Button;
    }
}

