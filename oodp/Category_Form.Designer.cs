namespace oodp
{
    partial class Category_Form
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
            this.Clothes_button = new System.Windows.Forms.Button();
            this.food_button = new System.Windows.Forms.Button();
            this.Electronics_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clothes_button
            // 
            this.Clothes_button.Location = new System.Drawing.Point(88, 53);
            this.Clothes_button.Name = "Clothes_button";
            this.Clothes_button.Size = new System.Drawing.Size(111, 23);
            this.Clothes_button.TabIndex = 0;
            this.Clothes_button.Text = "Clothes";
            this.Clothes_button.UseVisualStyleBackColor = true;
            this.Clothes_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // food_button
            // 
            this.food_button.Location = new System.Drawing.Point(88, 113);
            this.food_button.Name = "food_button";
            this.food_button.Size = new System.Drawing.Size(111, 23);
            this.food_button.TabIndex = 1;
            this.food_button.Text = "Food";
            this.food_button.UseVisualStyleBackColor = true;
            // 
            // Electronics_button
            // 
            this.Electronics_button.Location = new System.Drawing.Point(88, 176);
            this.Electronics_button.Name = "Electronics_button";
            this.Electronics_button.Size = new System.Drawing.Size(111, 23);
            this.Electronics_button.TabIndex = 2;
            this.Electronics_button.Text = "Electronics";
            this.Electronics_button.UseVisualStyleBackColor = true;
            // 
            // Category_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Electronics_button);
            this.Controls.Add(this.food_button);
            this.Controls.Add(this.Clothes_button);
            this.Name = "Category_Form";
            this.Text = "Category_Form";
            this.Load += new System.EventHandler(this.Category_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Clothes_button;
        public System.Windows.Forms.Button food_button;
        public System.Windows.Forms.Button Electronics_button;
    }
}