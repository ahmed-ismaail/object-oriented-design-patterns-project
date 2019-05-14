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
    public partial class Customer_Main_Form : Form
    {
        public Customer_Main_Form()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            Return_Product_Form ret = new Return_Product_Form();
            ret.Show();
        }

        private void Buy_Button_Click(object sender, EventArgs e)
        {
            Catalogue cat = new Catalogue();
            cat.Show();
        }

        private void Customer_Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void View_bills_cus_button_Click(object sender, EventArgs e)
        {
            View_Bill_For_Customer cuss = new View_Bill_For_Customer();
            cuss.Show();
        }
    }
}
