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
    public partial class Category_Form : Form
    {
        public Category_Form()
        {
            InitializeComponent();
        }

        private void Category_Form_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Product_To_Admin clothes = new View_Product_To_Admin();
            clothes.Show();
        }
    }
}
