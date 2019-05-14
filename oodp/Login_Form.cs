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
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            
        Register_Form re = new Register_Form();
            re.Show();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            customer custmer = new customer();
            manager manger = new manager();

            if (Customer_rdo_Button.Checked == true)
                custmer.Login(this);
            
            else
                manger.Login(this);
        }
    }
}
