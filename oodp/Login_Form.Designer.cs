namespace oodp
{
    partial class Login_Form
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
            this.email_txt_box = new System.Windows.Forms.TextBox();
            this.password_txt_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Signin = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Manager_rdo_Button = new System.Windows.Forms.RadioButton();
            this.Customer_rdo_Button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // email_txt_box
            // 
            this.email_txt_box.Location = new System.Drawing.Point(97, 60);
            this.email_txt_box.Name = "email_txt_box";
            this.email_txt_box.Size = new System.Drawing.Size(178, 20);
            this.email_txt_box.TabIndex = 0;
            // 
            // password_txt_box
            // 
            this.password_txt_box.Location = new System.Drawing.Point(97, 123);
            this.password_txt_box.Name = "password_txt_box";
            this.password_txt_box.Size = new System.Drawing.Size(178, 20);
            this.password_txt_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(27, 231);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(75, 23);
            this.Signin.TabIndex = 4;
            this.Signin.Text = "Sign in";
            this.Signin.UseVisualStyleBackColor = true;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(200, 231);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Manager_rdo_Button
            // 
            this.Manager_rdo_Button.AutoSize = true;
            this.Manager_rdo_Button.Checked = true;
            this.Manager_rdo_Button.Location = new System.Drawing.Point(24, 172);
            this.Manager_rdo_Button.Name = "Manager_rdo_Button";
            this.Manager_rdo_Button.Size = new System.Drawing.Size(67, 17);
            this.Manager_rdo_Button.TabIndex = 6;
            this.Manager_rdo_Button.TabStop = true;
            this.Manager_rdo_Button.Text = "Manager";
            this.Manager_rdo_Button.UseVisualStyleBackColor = true;
            // 
            // Customer_rdo_Button
            // 
            this.Customer_rdo_Button.AutoSize = true;
            this.Customer_rdo_Button.Location = new System.Drawing.Point(24, 195);
            this.Customer_rdo_Button.Name = "Customer_rdo_Button";
            this.Customer_rdo_Button.Size = new System.Drawing.Size(71, 17);
            this.Customer_rdo_Button.TabIndex = 7;
            this.Customer_rdo_Button.Text = "Customer";
            this.Customer_rdo_Button.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 291);
            this.Controls.Add(this.Customer_rdo_Button);
            this.Controls.Add(this.Manager_rdo_Button);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Signin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_txt_box);
            this.Controls.Add(this.email_txt_box);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox email_txt_box;
        public System.Windows.Forms.TextBox password_txt_box;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Signin;
        public System.Windows.Forms.Button Register;
        private System.Windows.Forms.RadioButton Manager_rdo_Button;
        private System.Windows.Forms.RadioButton Customer_rdo_Button;
    }
}