using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodp
{
    class hand_by_hand : payment_strategy
    {
        public void pay()
        {
            MessageBox.Show("pay cash ");
        }
    }
}
