namespace oodp
{
    partial class Remove_Delivery_Boy
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
            this.cmb_Delivery_boy_delete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.No_Orders_del_delivery_boy_box = new System.Windows.Forms.TextBox();
            this.Phone_del_Delivery_Boy_box = new System.Windows.Forms.TextBox();
            this.Full_Name_del_Delivery_Boy_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_for_add_del_boy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_Delivery_boy_delete
            // 
            this.cmb_Delivery_boy_delete.FormattingEnabled = true;
            this.cmb_Delivery_boy_delete.Location = new System.Drawing.Point(237, 33);
            this.cmb_Delivery_boy_delete.Name = "cmb_Delivery_boy_delete";
            this.cmb_Delivery_boy_delete.Size = new System.Drawing.Size(100, 24);
            this.cmb_Delivery_boy_delete.TabIndex = 47;
            this.cmb_Delivery_boy_delete.SelectedIndexChanged += new System.EventHandler(this.cmb_Delivery_boy_delete_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Delivery_Boy_ID :";
            // 
            // No_Orders_del_delivery_boy_box
            // 
            this.No_Orders_del_delivery_boy_box.Enabled = false;
            this.No_Orders_del_delivery_boy_box.Location = new System.Drawing.Point(237, 185);
            this.No_Orders_del_delivery_boy_box.Name = "No_Orders_del_delivery_boy_box";
            this.No_Orders_del_delivery_boy_box.Size = new System.Drawing.Size(100, 22);
            this.No_Orders_del_delivery_boy_box.TabIndex = 55;
            // 
            // Phone_del_Delivery_Boy_box
            // 
            this.Phone_del_Delivery_Boy_box.Enabled = false;
            this.Phone_del_Delivery_Boy_box.Location = new System.Drawing.Point(237, 135);
            this.Phone_del_Delivery_Boy_box.Name = "Phone_del_Delivery_Boy_box";
            this.Phone_del_Delivery_Boy_box.Size = new System.Drawing.Size(100, 22);
            this.Phone_del_Delivery_Boy_box.TabIndex = 54;
            // 
            // Full_Name_del_Delivery_Boy_box
            // 
            this.Full_Name_del_Delivery_Boy_box.Enabled = false;
            this.Full_Name_del_Delivery_Boy_box.Location = new System.Drawing.Point(237, 83);
            this.Full_Name_del_Delivery_Boy_box.Name = "Full_Name_del_Delivery_Boy_box";
            this.Full_Name_del_Delivery_Boy_box.Size = new System.Drawing.Size(100, 22);
            this.Full_Name_del_Delivery_Boy_box.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Phone_No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "No_Orders :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Full Name:";
            // 
            // Delete_for_add_del_boy_button
            // 
            this.Delete_for_add_del_boy_button.Location = new System.Drawing.Point(279, 266);
            this.Delete_for_add_del_boy_button.Name = "Delete_for_add_del_boy_button";
            this.Delete_for_add_del_boy_button.Size = new System.Drawing.Size(92, 40);
            this.Delete_for_add_del_boy_button.TabIndex = 49;
            this.Delete_for_add_del_boy_button.Text = "Delete";
            this.Delete_for_add_del_boy_button.UseVisualStyleBackColor = true;
            this.Delete_for_add_del_boy_button.Click += new System.EventHandler(this.Delete_for_add_del_boy_button_Click);
            // 
            // Remove_Delivery_Boy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 350);
            this.Controls.Add(this.No_Orders_del_delivery_boy_box);
            this.Controls.Add(this.Phone_del_Delivery_Boy_box);
            this.Controls.Add(this.Full_Name_del_Delivery_Boy_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_for_add_del_boy_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Delivery_boy_delete);
            this.Name = "Remove_Delivery_Boy";
            this.Text = "Remove_Delivery_Boy";
            this.Load += new System.EventHandler(this.Remove_Delivery_Boy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Delivery_boy_delete;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox No_Orders_del_delivery_boy_box;
        public System.Windows.Forms.TextBox Phone_del_Delivery_Boy_box;
        public System.Windows.Forms.TextBox Full_Name_del_Delivery_Boy_box;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Delete_for_add_del_boy_button;
    }
}