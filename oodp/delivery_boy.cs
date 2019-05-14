using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodp
{
    class delivery_boy
    {
        private String name;
        private String phone_no;
        private int no_orders;
        private int id;

        public void add_order()
        {
            if (no_orders < 2)
            {
                no_orders++;
            }
            else
                MessageBox.Show("this delivery boy is busy ");
        }



        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getPhone_no()
        {
            return phone_no;
        }

        public void setPhone_no(String phone_no)
        {
            this.phone_no = phone_no;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setno_orders(int no_orders)
        {
            this.no_orders = no_orders;
        }

        public int getno_orders()
        {
            return no_orders;
        }

    }
}
