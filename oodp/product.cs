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
    public class product : store_observer
    {

        private String name;
        private int quantity;
        private float price;
        private string pro_category;

        OracleDataAdapter adapter;
        DataSet dataSett;
        OracleDataAdapter adapteer;
        DataSet dataSeett;
       
        public float get_price()
        {
            return price;
        }
        public product ()
        {

        }
        public product(int x)
        {
            string constr = "data source = orcl; user id = hr; password=hr;";
            string productt = "select * from product ";

            adapter = new OracleDataAdapter(productt, constr);
            dataSett = new DataSet();
            adapter.Fill(dataSett);

            setCategory(dataSett.Tables[0].Rows[x]["CATEGORY_NAME"].ToString());
            setName(dataSett.Tables[0].Rows[x]["P_NAME"].ToString());
            setQuantity(int.Parse(dataSett.Tables[0].Rows[x]["QUANTITY"].ToString()));
            setPrice(float.Parse(dataSett.Tables[0].Rows[x]["PRICE"].ToString()));   
        }
        
        public void setPrice(float price)
        {
            this.price = price;
        }

        public float setPrice()
        {
            return price;
        }

        public void check_quantity()
        {
            if (this.getQuantity() < 1)
                MessageBox.Show("this product is out of store");
        }

        public void update()
        {
            this.setQuantity(this.getQuantity() - 1);
           
               
        }

        public void buy_product()
        {
            check_quantity();
            update();
            //MessageBox.Show(getName());

            string constr = "data source = orcl; user id = hr; password=hr;";
            string produt = "update PRODUCT set QUANTITY = "+getQuantity()+" where P_NAME ='"+getName()+"'";

            adapter = new OracleDataAdapter(produt, constr);
            dataSett = new DataSet();
            adapter.Fill(dataSett);

        }

        public void return_product(Return_Product_Form re)
        {
            string constr = "data source = orcl; user id = hr; password=hr;";
            string productt = "select QUANTITY  from PRODUCT where P_NAME= '"+ re.textBox_product_name.Text.ToString()+"'";
          
            adapteer = new OracleDataAdapter(productt, constr);
            dataSeett = new DataSet();
            adapteer.Fill(dataSeett);
            this.setQuantity(int.Parse(dataSeett.Tables[0].Rows[0]["QUANTITY"].ToString()) +1 );
            
            this.setName(re.textBox_product_name.Text);

            string constrr = "data source = orcl; user id = hr; password=hr;";
            string produt = "update PRODUCT set QUANTITY = " + getQuantity() + " where P_NAME ='" + getName() + "'";

            adapter = new OracleDataAdapter(produt, constrr);
            dataSett = new DataSet();
            adapter.Fill(dataSett);
            


        }

        public void calc_new_Price(Return_Product_Form re)
        {
            bill bil = new bill();
            OracleDataAdapter adaptt;
            DataSet dataStt;
            string constrr = "data source = orcl; user id = hr; password=hr;";
            string produtt = "select PRICE from PRODUCT where P_NAME='"+re.textBox_product_name.Text.ToString()+"'";

            adaptt = new OracleDataAdapter(produtt, constrr);
            dataStt = new DataSet();
            adaptt.Fill(dataStt);
            /////////////////////////////////////////////////
            OracleDataAdapter adapttr;
            DataSet dataSstt;
            string consttrr = "data source = orcl; user id = hr; password=hr;";
            string produut = "select TOTAL_PRICE from BILL where BILL_ID= " + int.Parse(re.Select_Bill_ID_for_return_bill.SelectedItem.ToString());

            adapttr = new OracleDataAdapter(produut, consttrr);
            dataSstt = new DataSet();
            adapttr.Fill(dataSstt);
            /////////////////////////////////////////////////////////
           
            float Totalprice = float.Parse(dataSstt.Tables[0].Rows[0]["TOTAL_PRICE"].ToString()) - float.Parse(dataStt.Tables[0].Rows[0]["PRICE"].ToString());
            bil.setTotle_price(Totalprice);
            
           //////////////////////////////////////////////////

            OracleDataAdapter adapt;
            DataSet dataSt;

            string constttrr = "data source = orcl; user id = hr; password=hr;";
            string prod= "update BILL set TOTAL_PRICE = " + bil.getTotle_price() + " where BILL_ID =" + int.Parse(re.Select_Bill_ID_for_return_bill.SelectedItem.ToString());

            adapt = new OracleDataAdapter(prod, constttrr);
            dataSt = new DataSet();
            adapt.Fill(dataSt);

        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getCategory()
        {
            return pro_category;
        }

        public void setCategory(String pro_category)
        {
            this.pro_category = pro_category;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }

    }
}
