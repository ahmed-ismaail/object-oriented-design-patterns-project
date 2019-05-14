using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace oodp
{
    public partial class Catalogue : Form
    {
        public static int x = -1;

        public Catalogue()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string constr = "data source = orcl; user id = hr; password=hr;";
            string productt = "select * from product ";

            OracleDataAdapter adapter = new OracleDataAdapter(productt, constr);
            DataSet dataSett = new DataSet();
            adapter.Fill(dataSett);

            if (x < dataSett.Tables[0].Rows.Count - 1)
                x++;

            product pro = new product(x);


            label1.Text = pro.getCategory();
            label2.Text = pro.getName();
            label3.Text = pro.getQuantity().ToString();
            label4.Text = pro.get_price().ToString();
        }

        private void Clothes_Form_Load(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            string constr = "data source = orcl; user id = hr; password=hr;";
            string productt = "select * from product ";

            OracleDataAdapter adapter = new OracleDataAdapter(productt, constr);
            DataSet dataSett = new DataSet();
            adapter.Fill(dataSett);

            if (x > 0)
                x--;

            product pro = new product(x);


            label1.Text = pro.getCategory();
            label2.Text = pro.getName();
            label3.Text = pro.getQuantity().ToString();
            label4.Text = pro.get_price().ToString();
        }

        customer custmer = new customer();
        private void Buy_Click(object sender, EventArgs e)
        {
            custmer.buy();
        }
        public string customerEmail;
        public void setCustomerEmail(string s)
        {
            this.customerEmail = s;
        }
        public string getCustomerEmail()
        {
            return customerEmail;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bill bil = new bill();
            bil.fill(this, custmer);
            Submit_make_order_Customer sub = new Submit_make_order_Customer();
            sub.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Return_Product_Form ret = new Return_Product_Form();
            ret.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_any_bill_for_cus cuss = new View_any_bill_for_cus();
            
            cuss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Bill_For_Customer cuscus = new View_Bill_For_Customer();
            cuscus.Show();
        }
    }
}
