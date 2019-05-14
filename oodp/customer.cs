using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace oodp
{
    public class customer
    {
        private string name;
        private string email;
        private int id;
        private string phone_no;
        private string password;
        private string address;
        public List<product> products = new List<product>();

        product prduct;


        OracleDataAdapter adapterr;
        DataSet dataSett;


        public void register(Register_Form re)
        {
            string ordb = "data source = orcl; user id =hr; password=hr;";
            OracleConnection con;
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            this.setName(re.name_txt_box.Text.ToString());
            this.setEmail(re.email_txt_box.Text.ToString());
            this.setPhone_no(re.phone_txt_box.Text.ToString());
            this.setAddress(re.address_txt_box.Text.ToString());
            this.setPassword(re.password_txt_box.Text.ToString());
            this.setId(int.Parse(re.Id_txt_box.Text));


            cmd.CommandText = "insert into customer values (:name,:id,:address,:email,:phone,:pass)";
            cmd.Parameters.Add("name", this.getName());
            cmd.Parameters.Add("id", this.getId());
            cmd.Parameters.Add("address", this.getAddress());
            cmd.Parameters.Add("email", this.getEmail());
            cmd.Parameters.Add("phone", this.getPhone_no());
            cmd.Parameters.Add("pass", this.getPassword());

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Login(Login_Form log)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";

            string emaill = "select email from customer";

            adapterr = new OracleDataAdapter(emaill, constr);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);

            for (int i = 0; i < dataSett.Tables[0].Rows.Count; i++)
            {
                if (dataSett.Tables[0].Rows[i]["email"].ToString() == log.email_txt_box.Text)
                {

                    Catalogue cat = new Catalogue();
                    cat.setCustomerEmail(log.email_txt_box.Text);

                    string constrr = "Data Source=orcl;User Id=hr;Password=hr;";

                    string password = "select CUSTOMER_PASSWORD from customer where email =:email";
                    OracleDataAdapter adapterrr = new OracleDataAdapter(password, constrr);
                    adapterrr.SelectCommand.Parameters.Add("email", log.email_txt_box.Text);
                    DataSet dataSettt = new DataSet();
                    adapterrr.Fill(dataSettt);

                    for (int j = 0; j < dataSettt.Tables[0].Rows.Count; j++)
                    {
                        if (dataSettt.Tables[0].Rows[j]["CUSTOMER_PASSWORD"].ToString() == log.password_txt_box.Text)
                        {
                            MessageBox.Show("U R N");

                            cat.Show();

                            break;
                        }
                    }
                    break;
                }
                else if (dataSett.Tables[0].Rows[i]["email"].ToString() != log.email_txt_box.Text && i == dataSett.Tables[0].Rows.Count - 1)
                {
                    MessageBox.Show("this email or password does not exist");
                }
            }
        }

        public void buy()
        {
            prduct = new product(Catalogue.x);
            //buy_product decrease the quantity of the product 
            prduct.buy_product();
            //when press buy button add the product to the list of products
            products.Add(prduct);
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getPhone_no()
        {
            return phone_no;
        }

        public void setPhone_no(string phone_no)
        {
            this.phone_no = phone_no;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
    }
}
