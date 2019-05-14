namespace oodp
{
    partial class View_All_Bills
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
            this.Viewfor_all_bills = new System.Windows.Forms.Button();
            this.DGV_Bills = new System.Windows.Forms.DataGridView();
            this.Datagridviewnos = new System.Windows.Forms.DataGridView();
            this.dataGridViewakhr = new System.Windows.Forms.DataGridView();
            this.dataGridView_akhr_ymen_View_all_bills = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridviewnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewakhr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_akhr_ymen_View_all_bills)).BeginInit();
            this.SuspendLayout();
            // 
            // Viewfor_all_bills
            // 
            this.Viewfor_all_bills.Location = new System.Drawing.Point(558, 30);
            this.Viewfor_all_bills.Margin = new System.Windows.Forms.Padding(2);
            this.Viewfor_all_bills.Name = "Viewfor_all_bills";
            this.Viewfor_all_bills.Size = new System.Drawing.Size(56, 19);
            this.Viewfor_all_bills.TabIndex = 3;
            this.Viewfor_all_bills.Text = "View";
            this.Viewfor_all_bills.UseVisualStyleBackColor = true;
            this.Viewfor_all_bills.Click += new System.EventHandler(this.Viewfor_all_bills_Click);
            // 
            // DGV_Bills
            // 
            this.DGV_Bills.AllowUserToAddRows = false;
            this.DGV_Bills.AllowUserToDeleteRows = false;
            this.DGV_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bills.Location = new System.Drawing.Point(2, 85);
            this.DGV_Bills.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Bills.Name = "DGV_Bills";
            this.DGV_Bills.ReadOnly = true;
            this.DGV_Bills.RowTemplate.Height = 24;
            this.DGV_Bills.Size = new System.Drawing.Size(559, 271);
            this.DGV_Bills.TabIndex = 2;
            // 
            // Datagridviewnos
            // 
            this.Datagridviewnos.AllowUserToAddRows = false;
            this.Datagridviewnos.AllowUserToDeleteRows = false;
            this.Datagridviewnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridviewnos.Location = new System.Drawing.Point(558, 85);
            this.Datagridviewnos.Margin = new System.Windows.Forms.Padding(2);
            this.Datagridviewnos.Name = "Datagridviewnos";
            this.Datagridviewnos.ReadOnly = true;
            this.Datagridviewnos.RowTemplate.Height = 24;
            this.Datagridviewnos.Size = new System.Drawing.Size(443, 271);
            this.Datagridviewnos.TabIndex = 4;
            // 
            // dataGridViewakhr
            // 
            this.dataGridViewakhr.AllowUserToAddRows = false;
            this.dataGridViewakhr.AllowUserToDeleteRows = false;
            this.dataGridViewakhr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewakhr.Location = new System.Drawing.Point(1000, 85);
            this.dataGridViewakhr.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewakhr.Name = "dataGridViewakhr";
            this.dataGridViewakhr.ReadOnly = true;
            this.dataGridViewakhr.RowTemplate.Height = 24;
            this.dataGridViewakhr.Size = new System.Drawing.Size(254, 271);
            this.dataGridViewakhr.TabIndex = 5;
            // 
            // dataGridView_akhr_ymen_View_all_bills
            // 
            this.dataGridView_akhr_ymen_View_all_bills.AllowUserToAddRows = false;
            this.dataGridView_akhr_ymen_View_all_bills.AllowUserToDeleteRows = false;
            this.dataGridView_akhr_ymen_View_all_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_akhr_ymen_View_all_bills.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView_akhr_ymen_View_all_bills.Location = new System.Drawing.Point(1258, 85);
            this.dataGridView_akhr_ymen_View_all_bills.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_akhr_ymen_View_all_bills.Name = "dataGridView_akhr_ymen_View_all_bills";
            this.dataGridView_akhr_ymen_View_all_bills.ReadOnly = true;
            this.dataGridView_akhr_ymen_View_all_bills.RowTemplate.Height = 24;
            this.dataGridView_akhr_ymen_View_all_bills.Size = new System.Drawing.Size(86, 271);
            this.dataGridView_akhr_ymen_View_all_bills.TabIndex = 11;
            // 
            // View_All_Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 431);
            this.Controls.Add(this.dataGridView_akhr_ymen_View_all_bills);
            this.Controls.Add(this.dataGridViewakhr);
            this.Controls.Add(this.Datagridviewnos);
            this.Controls.Add(this.Viewfor_all_bills);
            this.Controls.Add(this.DGV_Bills);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View_All_Bills";
            this.Text = "View_All_Bills";
            this.Load += new System.EventHandler(this.View_All_Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridviewnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewakhr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_akhr_ymen_View_all_bills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Viewfor_all_bills;
        public System.Windows.Forms.DataGridView DGV_Bills;
        public System.Windows.Forms.DataGridView Datagridviewnos;
        public System.Windows.Forms.DataGridView dataGridViewakhr;
        public System.Windows.Forms.DataGridView dataGridView_akhr_ymen_View_all_bills;
    }
}