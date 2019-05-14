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
    public partial class Submit_make_order_Customer : Form
    {
        public Submit_make_order_Customer()
        {
            InitializeComponent();
        }

        private void Submit_make_order_Customer_Load(object sender, EventArgs e)
        {
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            cmd.CommandText = "select * from Bill where Bill_ID =119";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("Bill_ID", typeof(float));
            table.Columns.Add("Total_price", typeof(float));
            table.Columns.Add("Bill_date", typeof(string));
            table.Columns.Add("Customer_id", typeof(int));
            table.Columns.Add("Delivery_boy_ID", typeof(int));

            table.Load(dr);
            DGV_Bills_shmal_submit_order.DataSource = table;
            ////////////////////////////////////////////////////////////
            OracleCommand cmb = new OracleCommand();
            cmb.Connection = conn;

            cmb.CommandText = "select Customer_Name,Address,Email,Phone_no from Customer where Customer_ID IN (Select Customer_ID from Bill)";
            cmb.CommandType = CommandType.Text;

            OracleDataReader drr = cmb.ExecuteReader();
            table1.Columns.Add("Customer_Name", typeof(string));
            table1.Columns.Add("Address", typeof(string));
            table1.Columns.Add("Email", typeof(string));
            table1.Columns.Add("Phone_no", typeof(string));
            table1.Load(drr);
            Datagridviewnos_shmal_submit_order.DataSource = table1;
            /////////////////////////////////////////////////////////////////
            OracleCommand cmbb = new OracleCommand();
            cmbb.Connection = conn;

            cmbb.CommandText = "select Delivery_boy_Name,Phone_no from Delivery_boy where Delivery_boy_ID IN (Select Delivery_boy_ID from Bill)";
            cmbb.CommandType = CommandType.Text;

            OracleDataReader ddrr = cmbb.ExecuteReader();
            table2.Columns.Add("Delivery_boy_Name", typeof(string));
            table2.Columns.Add("Phone_no", typeof(string));

            table2.Load(ddrr);
            dataGridViewnos_ymen_submit_orders.DataSource = table2;
            //////////////////////////////////////////////////////////////////
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            cm.CommandText = "select PRODUCTS_NAME from LIST_OF_BILL_PRODUCTS where Bill_ID =119";
            cm.CommandType = CommandType.Text;

            OracleDataReader dre = cm.ExecuteReader();
            table3.Columns.Add("PRODUCTS_NAME", typeof(string));

            table3.Load(dre);
            dataGridView_akhr_ymen_submit_orders.DataSource = table3;


        }

        private void Cash_Click(object sender, EventArgs e)
        {
            hand_by_hand han = new hand_by_hand();
            han.pay();
        }

        private void pay_credit_card_Click(object sender, EventArgs e)
        {
            credit_card cre = new credit_card();
            cre.pay();
        }
    }
}
