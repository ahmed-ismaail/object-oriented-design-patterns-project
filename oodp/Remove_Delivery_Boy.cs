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
    public partial class Remove_Delivery_Boy : Form
    {

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public Remove_Delivery_Boy()
        {
            InitializeComponent();
        }

        private void Remove_Delivery_Boy_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select   Delivery_boy_ID from Delivery_boy";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_Delivery_boy_delete.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_Delivery_boy_delete_SelectedIndexChanged(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Delivery_boy where Delivery_boy_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_Delivery_boy_delete.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {

                Full_Name_del_Delivery_Boy_box.Text = dr[0].ToString();
                Phone_del_Delivery_Boy_box.Text= dr[2].ToString();
                No_Orders_del_delivery_boy_box.Text = dr[3].ToString();
                

            }
            if (dr[3].ToString() != "0")
            {
                MessageBox.Show("Warning this delivery boy has orders Are u sure delete him?");
            }
            dr.Close();
        }

        private void Delete_for_add_del_boy_button_Click(object sender, EventArgs e)
        {
            manager man = new manager();
            man.RemoveDelivaryBoy(this);
        }
    }
}
