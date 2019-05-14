namespace oodp
{
    partial class Add_Delivery_Boy
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
            this.Save_for_add_del_boy_button = new System.Windows.Forms.Button();
            this.Phone_No_delivery_boy_box = new System.Windows.Forms.TextBox();
            this.ID_Delivery_Boy_box = new System.Windows.Forms.TextBox();
            this.Full_Name_Delivery_Boy_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_for_add_del_boy_button
            // 
            this.Save_for_add_del_boy_button.Location = new System.Drawing.Point(295, 227);
            this.Save_for_add_del_boy_button.Name = "Save_for_add_del_boy_button";
            this.Save_for_add_del_boy_button.Size = new System.Drawing.Size(92, 40);
            this.Save_for_add_del_boy_button.TabIndex = 0;
            this.Save_for_add_del_boy_button.Text = "Save";
            this.Save_for_add_del_boy_button.UseVisualStyleBackColor = true;
            this.Save_for_add_del_boy_button.Click += new System.EventHandler(this.Save_for_add_del_boy_button_Click);
            // 
            // Phone_No_delivery_boy_box
            // 
            this.Phone_No_delivery_boy_box.Location = new System.Drawing.Point(225, 146);
            this.Phone_No_delivery_boy_box.Name = "Phone_No_delivery_boy_box";
            this.Phone_No_delivery_boy_box.Size = new System.Drawing.Size(100, 22);
            this.Phone_No_delivery_boy_box.TabIndex = 24;
            // 
            // ID_Delivery_Boy_box
            // 
            this.ID_Delivery_Boy_box.Location = new System.Drawing.Point(225, 96);
            this.ID_Delivery_Boy_box.Name = "ID_Delivery_Boy_box";
            this.ID_Delivery_Boy_box.Size = new System.Drawing.Size(100, 22);
            this.ID_Delivery_Boy_box.TabIndex = 22;
            // 
            // Full_Name_Delivery_Boy_box
            // 
            this.Full_Name_Delivery_Boy_box.Location = new System.Drawing.Point(225, 44);
            this.Full_Name_Delivery_Boy_box.Name = "Full_Name_Delivery_Boy_box";
            this.Full_Name_Delivery_Boy_box.Size = new System.Drawing.Size(100, 22);
            this.Full_Name_Delivery_Boy_box.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone_No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Full Name:";
            // 
            // Add_Delivery_Boy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 283);
            this.Controls.Add(this.Phone_No_delivery_boy_box);
            this.Controls.Add(this.ID_Delivery_Boy_box);
            this.Controls.Add(this.Full_Name_Delivery_Boy_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_for_add_del_boy_button);
            this.Name = "Add_Delivery_Boy";
            this.Text = "Add_Delivery_Boy";
            this.Load += new System.EventHandler(this.Add_Delivery_Boy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Save_for_add_del_boy_button;
        public System.Windows.Forms.TextBox Phone_No_delivery_boy_box;
        public System.Windows.Forms.TextBox ID_Delivery_Boy_box;
        public System.Windows.Forms.TextBox Full_Name_Delivery_Boy_box;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}