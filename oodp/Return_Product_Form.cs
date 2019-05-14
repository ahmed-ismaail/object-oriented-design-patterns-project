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
    public partial class Return_Product_Form : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Return_Product_Form()
        {
            InitializeComponent();
        }

        private void Select_Bill_ID_for_return_bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Bill where Bill_ID =:idd";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("idd", int.Parse(Select_Bill_ID_for_return_bill.SelectedItem.ToString()));

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("Bill_ID", typeof(float));
            table.Columns.Add("Total_price", typeof(float));
            table.Columns.Add("Bill_date", typeof(string));
            table.Columns.Add("Customer_id", typeof(int));
            table.Columns.Add("Delivery_boy_ID", typeof(int));
            table.Columns.Add("Delivery_Charges", typeof(float));

            table.Load(dr);
            dataGridView_for_return_Products.DataSource = table;
            /////////////////////////////////////////////////////////////////
            textBox_product_name.Show();
            label_return.Show();
            Ok_button_Product_name.Show();
            DataTable tablee = new DataTable();
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "select PRODUCTS_NAME from LIST_OF_BILL_PRODUCTS where Bill_ID =:id";
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add("id", int.Parse(Select_Bill_ID_for_return_bill.SelectedItem.ToString()));

            OracleDataReader dre = cm.ExecuteReader();
            tablee.Columns.Add("PRODUCTS_NAME", typeof(string));

            tablee.Load(dre);
            dataGridView_Product_name.DataSource = tablee;

        }

        private void Return_Product_Form_Load(object sender, EventArgs e)
        {
            label_return.Hide();
            textBox_product_name.Hide();
            Ok_button_Product_name.Hide();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Bill_id from Bill";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Bill_ID_for_return_bill.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void cmb_product_return_SelectedIndexChanged(object sender, EventArgs e)
        {
          


        }

        private void Ok_button_Product_name_Click(object sender, EventArgs e)
        {
            product pro = new product();
            pro.return_product(this);
            pro.calc_new_Price(this);
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from LIST_OF_BILL_PRODUCTS where PRODUCTS_NAME=:namee";

            c.Parameters.Add("namee", textBox_product_name.Text);
            c.ExecuteNonQuery();
            textBox_product_name.Text = "";
            MessageBox.Show("product returned");

        }

        private void textBox_product_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
