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
    public partial class View_Bill_For_Customer : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public View_Bill_For_Customer()
        {
            InitializeComponent();
        }

        private void View_Bill_For_Customer_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Customer_id from Bill";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Customer_for_view_bills.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void Select_Customer_Id_for_view_his_bills_SelectedIndexChanged(object sender, EventArgs e)
        {

            manager man = new manager();
            man.get_Bills_for_one_Customer(this);
        }

        private void dataGridView_akhr_ymen_submit_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
