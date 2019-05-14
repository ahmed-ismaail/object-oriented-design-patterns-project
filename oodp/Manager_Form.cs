using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodp
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {

        }

        private void View_Products_for_manager_Click(object sender, EventArgs e)
        {
            View_Product_To_Admin clothes = new View_Product_To_Admin();
            clothes.Show();
        }

        private void Add_Delivery_boy_Click(object sender, EventArgs e)
        {
            Add_Delivery_Boy add_boy = new Add_Delivery_Boy();
            add_boy.Show();
        }

        private void Remove_delivery_boy_Click(object sender, EventArgs e)
        {
            Remove_Delivery_Boy rem_boy = new Remove_Delivery_Boy();
            rem_boy.Show();
        }
        

        private void View_All_bills_Click(object sender, EventArgs e)
        {
            View_All_Bills all = new View_All_Bills();
            all.Show();
        }

        private void View_bill_for_one_customer_Click(object sender, EventArgs e)
        {
            View_Bill_For_Customer cus = new View_Bill_For_Customer();
            cus.Show();
        }

        private void View_bill_for_date_Click(object sender, EventArgs e)
        {
            View_Bills_by_Date dat = new View_Bills_by_Date();
            dat.Show();
        }
    }
}
