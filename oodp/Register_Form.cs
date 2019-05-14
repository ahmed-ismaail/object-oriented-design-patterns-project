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
    public partial class Register_Form : Form
    {

        public Register_Form()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Customer_rdo_Button.Checked == true)
            { 
               customer custmer =new customer();
               custmer.register(this);
            }
            else
            {
                manager manger = new manager();
                manger.register(this);
            }
        }

        private void Manager_rdo_Button_CheckedChanged(object sender, EventArgs e)
        {
                address_label.Visible = false;
                address_txt_box.Visible = false;
                phone_label.Visible = false;
                phone_txt_box.Visible = false ;

        }

        private void Customer_rdo_Button_CheckedChanged(object sender, EventArgs e)
        {
            address_label.Visible = true;
            address_txt_box.Visible = true;
            phone_label.Visible = true;
            phone_txt_box.Visible = true;
        }
    }
}
