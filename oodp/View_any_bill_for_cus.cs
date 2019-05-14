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
    public partial class View_any_bill_for_cus : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public View_any_bill_for_cus()
        {
            InitializeComponent();
        }
       
        private void View_any_bill_for_cus_Load(object sender, EventArgs e)
        {
            
            
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "select BILL_ID from Bill where CUSTOMER_ID=2016170" ;
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Bill_Id_for_view_bills_for_cus.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void Select_Bill_Id_for_view_bills_for_cus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Bill where Bill_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", Select_Bill_Id_for_view_bills_for_cus.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("Bill_ID", typeof(int));
            table.Columns.Add("Total_price", typeof(float));
            table.Columns.Add("Bill_date", typeof(string));
            table.Columns.Add("Customer_id", typeof(int));
            table.Columns.Add("Delivery_boy_ID", typeof(int));
            table.Columns.Add("Delivery_Charges", typeof(int));

            table.Load(dre);
            DGV_Bills_one_for_cus.DataSource = table;
            ////////////////////////////////////////////////////////////
            OracleCommand cmb = new OracleCommand();
            cmb.Connection = conn;

            cmb.CommandText = "select Customer_Name,Address,Email,Phone_no from Customer where Customer_ID =2016170";
            cmb.CommandType = CommandType.Text;

            OracleDataReader drr = cmb.ExecuteReader();
            table1.Columns.Add("Customer_Name", typeof(string));
            table1.Columns.Add("Address", typeof(string));
            table1.Columns.Add("Email", typeof(string));
            table1.Columns.Add("Phone_no", typeof(string));
            table1.Load(drr);
            Datagridviewnos_one_for_cus.DataSource = table1;
            /////////////////////////////////////////////////////////////////
            OracleCommand cmbb = new OracleCommand();
            cmbb.Connection = conn;

            cmbb.CommandText = "select Delivery_boy_Name,Phone_no from Delivery_boy where Delivery_boy_ID IN (Select Delivery_boy_ID from Bill where  Bill_ID ='" + Select_Bill_Id_for_view_bills_for_cus.SelectedItem.ToString() + "' )";
            cmbb.CommandType = CommandType.Text;

            OracleDataReader ddrr = cmbb.ExecuteReader();
            table2.Columns.Add("Delivery_boy_Name", typeof(string));
            table2.Columns.Add("Phone_no", typeof(string));

            table2.Load(ddrr);
            dataGridViewakhr_one_for_cus.DataSource = table2;
            ////////////////////////////////////////////////////////////////////////////////
            OracleCommand cqm = new OracleCommand();
            cqm.Connection = conn;
            // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            cqm.CommandText = "select PRODUCTS_NAME from LIST_OF_BILL_PRODUCTS where Bill_ID =119";
            cqm.CommandType = CommandType.Text;

            OracleDataReader dwre = cqm.ExecuteReader();
            table3.Columns.Add("PRODUCTS_NAME", typeof(string));

            table3.Load(dwre);
            dataGridView_akhr_ymen_View_specific.DataSource = table3;

            dre.Close();

        }
    }
}
