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
    public partial class View_Bills_by_Date : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public View_Bills_by_Date()
        {
            InitializeComponent();
        }

        private void Select_Customer_Id_for_view_his_bills_SelectedIndexChanged(object sender, EventArgs e)
        {

            manager man = new manager();
            man.View_bills_for_specific_Date(this);
        }

        private void View_Bills_by_Date_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Bill_date from Bill";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Select_Date_for_view_his_bills.Items.Add(dr[0]);

            }
            dr.Close();
        }
    }
}
