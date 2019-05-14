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
    public partial class View_Product_To_Admin : Form
    {
        public int x = -1;

        public View_Product_To_Admin()
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
    }
}
