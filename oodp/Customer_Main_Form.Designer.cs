namespace oodp
{
    partial class Customer_Main_Form
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
            this.Buy_Button = new System.Windows.Forms.Button();
            this.View_bills_cus_button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buy_Button
            // 
            this.Buy_Button.Location = new System.Drawing.Point(76, 21);
            this.Buy_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Buy_Button.Name = "Buy_Button";
            this.Buy_Button.Size = new System.Drawing.Size(93, 46);
            this.Buy_Button.TabIndex = 0;
            this.Buy_Button.Text = "Buy_Product";
            this.Buy_Button.UseVisualStyleBackColor = true;
            this.Buy_Button.Click += new System.EventHandler(this.Buy_Button_Click);
            // 
            // View_bills_cus_button
            // 
            this.View_bills_cus_button.Location = new System.Drawing.Point(76, 158);
            this.View_bills_cus_button.Margin = new System.Windows.Forms.Padding(2);
            this.View_bills_cus_button.Name = "View_bills_cus_button";
            this.View_bills_cus_button.Size = new System.Drawing.Size(93, 46);
            this.View_bills_cus_button.TabIndex = 2;
            this.View_bills_cus_button.Text = "View Bills";
            this.View_bills_cus_button.UseVisualStyleBackColor = true;
            this.View_bills_cus_button.Click += new System.EventHandler(this.View_bills_cus_button_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(76, 87);
            this.Return_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(93, 46);
            this.Return_Button.TabIndex = 1;
            this.Return_Button.Text = "Return_Product";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Customer_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 239);
            this.Controls.Add(this.View_bills_cus_button);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Buy_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Customer_Main_Form";
            this.Text = "Customer_Main_Form";
            this.Load += new System.EventHandler(this.Customer_Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Buy_Button;
        private System.Windows.Forms.Button View_bills_cus_button;
        private System.Windows.Forms.Button Return_Button;
    }
}