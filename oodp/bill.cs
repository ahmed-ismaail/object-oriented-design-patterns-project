using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Windows.Forms;

namespace oodp
{
    public class bill
    {
        private float totle_price;
        private String date;

        delivery_boy boy = new delivery_boy();

   

        public void fill(Catalogue cat, customer cus)
        {

            calculate_total_price(cus);

            string constr = "data source = orcl; user id = hr; password=hr;";
            string customerID = "select CUSTOMER_ID from customer where EMAIL='" + cat.getCustomerEmail() + "'";

            OracleDataAdapter adapterr = new OracleDataAdapter(customerID, constr);
            DataSet dataSett = new DataSet();
            adapterr.Fill(dataSett);

            //MessageBox.Show(dataSett.Tables[0].Rows[0]["CUSTOMER_ID"].ToString());

            string deliveryboyid = "select DELIVERY_BOY_ID,NO_ORDERS from DELIVERY_BOY where NO_ORDERS< 2";

            OracleDataAdapter adapter = new OracleDataAdapter(deliveryboyid, constr);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            string inert = @"insert into bill values(1," + getTotle_price()
                           + ",'11/5/2019'," + int.Parse(dataSett.Tables[0].Rows[0]["CUSTOMER_ID"].ToString()) +
                           "," + int.Parse(dataSet.Tables[0].Rows[0]["DELIVERY_BOY_ID"].ToString()) + ",5 )";

            OracleDataAdapter adapteer = new OracleDataAdapter(inert, constr);
            DataSet dataSeet = new DataSet();
            adapteer.Fill(dataSeet);

            boy.setno_orders(int.Parse(dataSet.Tables[0].Rows[0]["NO_ORDERS"].ToString()) + 1);

            string update_no_orders = @"update DELIVERY_BOY set NO_ORDERS = " + boy.getno_orders()
                   + " where DELIVERY_BOY_ID = " + int.Parse(dataSet.Tables[0].Rows[0]["DELIVERY_BOY_ID"].ToString());


            OracleDataAdapter adapteerr = new OracleDataAdapter(update_no_orders, constr);
            DataSet dataSeett = new DataSet();
            adapteerr.Fill(dataSeett);


            /////////////////////////////////insert into table produts/////////////////////////////////////////

            for (int i = 0; i < cus.products.Count; i++)
            {
                // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
                string inertt = "insert into LIST_OF_BILL_PRODUCTS values(1,'" + cus.products[i].getName() + "')";

                OracleDataAdapter adapteerrr = new OracleDataAdapter(inertt, constr);
                DataSet dataSeettt = new DataSet();
                adapteerrr.Fill(dataSeettt);
            }


        }


        public void calculate_total_price(customer cust)
        {
            for (int i = 0; i < cust.products.Count(); i++)
            {
                setTotle_price(getTotle_price() + cust.products[i].get_price());
            }
        }

        public float getTotle_price()
        {
            return totle_price;
        }

        public void setTotle_price(float totle_price)
        {
            this.totle_price = totle_price;
        }

        public String getDate()
        {
            return date;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

    }
}
