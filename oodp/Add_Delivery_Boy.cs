using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodp
{
    public partial class Add_Delivery_Boy : Form
    {
        public Add_Delivery_Boy()
        {
            InitializeComponent();
        }

        private void Add_Delivery_Boy_Load(object sender, EventArgs e)
        {

        }

        private void Save_for_add_del_boy_button_Click(object sender, EventArgs e)
        {
            manager man = new manager();
            man.addDelivayBoy(this);
        }
    }
}
