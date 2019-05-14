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
    public partial class View_All_Bills : Form
    {
        public View_All_Bills()
        {
            InitializeComponent();
        }

        private void View_All_Bills_Load(object sender, EventArgs e)
        {

        }

        private void Viewfor_all_bills_Click(object sender, EventArgs e)
        {
            manager man = new manager();
            man.getBills(this);
        }
    }
}
