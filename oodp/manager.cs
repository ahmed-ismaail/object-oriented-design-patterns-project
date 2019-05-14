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
    class manager
    {
        private string name;
        private string email;
        private int id;
        private string password;
        private static manager m = new manager();


        OracleDataAdapter adapterr;
        DataSet dataSett;

        public manager()
        {
            this.setName(name);
            this.setEmail(email);
            this.setPassword(password);
            this.setId(id);
        }

        //////////singleton//////////////
        public static manager getmanger()
        {
            return m;
        }

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
            this.setPassword(re.password_txt_box.Text.ToString());
            this.setId(int.Parse(re.Id_txt_box.Text));


            cmd.CommandText = "insert into MANAGER values (:name,:id,:email,:pass)";
            cmd.Parameters.Add("name", this.getName());
            cmd.Parameters.Add("id", this.getId());
            cmd.Parameters.Add("email", this.getEmail());
            cmd.Parameters.Add("pass", this.getPassword());

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Login(Login_Form log)
        {
            string constr = "Data Source=orcl;User Id=hr;Password=hr;";

            string emaill = "select email from manager";

            adapterr = new OracleDataAdapter(emaill, constr);
            dataSett = new DataSet();
            adapterr.Fill(dataSett);

            for (int i = 0; i < dataSett.Tables[0].Rows.Count; i++)
            {
                if (dataSett.Tables[0].Rows[i]["email"].ToString() == log.email_txt_box.Text)
                {
                    string constrr = "Data Source=orcl;User Id=hr;Password=hr;";

                    string password = "select Manager_Password from manager where email =:email";
                    OracleDataAdapter adapterrr = new OracleDataAdapter(password, constrr);
                    adapterrr.SelectCommand.Parameters.Add("email", log.email_txt_box.Text);
                    DataSet dataSettt = new DataSet();
                    adapterrr.Fill(dataSettt);

                    for (int j = 0; j < dataSettt.Tables[0].Rows.Count; j++)
                    {
                        if (dataSettt.Tables[0].Rows[j]["Manager_Password"].ToString() == log.password_txt_box.Text)
                        {
                            MessageBox.Show("U R N");

                            Manager_Form man = new Manager_Form();
                            man.Show();
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

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void getBills(View_All_Bills al)
        {

            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Bill";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            table.Columns.Add("Bill_ID", typeof(float));
            table.Columns.Add("Total_price", typeof(float));
            table.Columns.Add("Bill_date", typeof(string));
            table.Columns.Add("Customer_id", typeof(int));
            table.Columns.Add("Delivery_boy_ID", typeof(int));
            table.Columns.Add("Delivery_Charges", typeof(float));
              


            table.Load(dr);
            al.DGV_Bills.DataSource = table;
            ////////////////////////////////////////////////////////////
            OracleCommand cmb = new OracleCommand();
            cmb.Connection = conn;

            cmb.CommandText = "select Customer_Name,Address,Email,Phone_no from Customer where Customer_ID IN (Select Customer_ID from Bill)";
            cmb.CommandType = CommandType.Text;

            OracleDataReader drr = cmb.ExecuteReader();
            table1.Columns.Add("Customer_Name", typeof(string));
            table1.Columns.Add("Address", typeof(string));
            table1.Columns.Add("Email", typeof(string));
            table1.Columns.Add("Phone_no", typeof(string));
            table1.Load(drr);
            al.Datagridviewnos.DataSource = table1;
            /////////////////////////////////////////////////////////////////
            OracleCommand cmbb = new OracleCommand();
            cmbb.Connection = conn;

            cmbb.CommandText = "select Delivery_boy_Name,Phone_no from Delivery_boy where Delivery_boy_ID IN (Select Delivery_boy_ID from Bill)";
            cmbb.CommandType = CommandType.Text;

            OracleDataReader ddrr = cmbb.ExecuteReader();
            table2.Columns.Add("Delivery_boy_Name", typeof(string));
            table2.Columns.Add("Phone_no", typeof(string));

            table2.Load(ddrr);
            al.dataGridViewakhr.DataSource = table2;
            ////////////////////////////////////////////////////////////////////
            OracleCommand cwm = new OracleCommand();
            cwm.Connection = conn;
            // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            cwm.CommandText = "select PRODUCTS_NAME from LIST_OF_BILL_PRODUCTS where Bill_ID =119";
            cwm.CommandType = CommandType.Text;

            OracleDataReader drrre = cwm.ExecuteReader();
            table3.Columns.Add("PRODUCTS_NAME", typeof(string));

            table3.Load(drrre);
            al.dataGridView_akhr_ymen_View_all_bills.DataSource = table3;
        }

        public void get_Bills_for_one_Customer(View_Bill_For_Customer vw)
        {
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Bill where Customer_id=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", vw.Select_Customer_for_view_bills.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("Bill_ID", typeof(int));
            table.Columns.Add("Total_price", typeof(float));
            table.Columns.Add("Bill_date", typeof(string));
            table.Columns.Add("Customer_id", typeof(int));
            table.Columns.Add("Delivery_boy_ID", typeof(int));
            table.Columns.Add("Delivery_Charges", typeof(int));

            table.Load(dre);
            vw.DGV_Bills_one.DataSource = table;
            ////////////////////////////////////////////////////////////
            OracleCommand cmb = new OracleCommand();
            cmb.Connection = conn;

            cmb.CommandText = "select Customer_Name,Address,Email,Phone_no from Customer where Customer_ID =' " + vw.Select_Customer_for_view_bills.SelectedItem.ToString()+"'";
            cmb.CommandType = CommandType.Text;

            OracleDataReader drr = cmb.ExecuteReader();
            table1.Columns.Add("Customer_Name", typeof(string));
            table1.Columns.Add("Address", typeof(string));
            table1.Columns.Add("Email", typeof(string));
            table1.Columns.Add("Phone_no", typeof(string));
            table1.Load(drr);
            vw.Datagridviewnos_one.DataSource = table1;
            /////////////////////////////////////////////////////////////////
            OracleCommand cmbb = new OracleCommand();
            cmbb.Connection = conn;

            cmbb.CommandText = "select Delivery_boy_Name,Phone_no from Delivery_boy where Delivery_boy_ID IN (Select Delivery_boy_ID from Bill where  Customer_ID =' " + vw.Select_Customer_for_view_bills.SelectedItem.ToString() + "'"+")";
            cmbb.CommandType = CommandType.Text;

            OracleDataReader ddrr = cmbb.ExecuteReader();
            table2.Columns.Add("Delivery_boy_Name", typeof(string));
            table2.Columns.Add("Phone_no", typeof(string));

            table2.Load(ddrr);
            vw.dataGridViewakhr_one.DataSource = table2;
            ////////////////////////////////////////////////////////////////////////////////
            OracleCommand cqm = new OracleCommand();
            cqm.Connection = conn;
            // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            cqm.CommandText = "select PRODUCTS_NAME from LIST_OF_BILL_PRODUCTS where Bill_ID =119";
            cqm.CommandType = CommandType.Text;

            OracleDataReader dwre = cqm.ExecuteReader();
            table3.Columns.Add("PRODUCTS_NAME", typeof(string));

            table3.Load(dwre);
            vw.dataGridView_akhr_ymen_Cus.DataSource = table3;

            dre.Close();

        }

        public void View_bills_for_specific_Date(View_Bills_by_Date bil)
        {
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select * from Bill where Bill_date=:datee";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("datee", bil.Select_Date_for_view_his_bills.SelectedItem.ToString());
            OracleDataReader dre = c.ExecuteReader();

            table.Columns.Add("Bill_ID", typeof(int));
            table.Columns.Add("Total_price", typeof(float));
            table.Columns.Add("Bill_date", typeof(string));
            table.Columns.Add("Customer_id", typeof(int));
            table.Columns.Add("Delivery_boy_ID", typeof(int));
            table.Columns.Add("Delivery_Charges", typeof(float));

            table.Load(dre);
            bil.DGV_Bills_one_Date.DataSource = table;
            ////////////////////////////////////////////////////////////

            OracleCommand cmb = new OracleCommand();
            cmb.Connection = conn;

            cmb.CommandText = "select Customer_Name,Address,Email,Phone_no from Customer where Customer_ID IN (Select Customer_ID from Bill where Bill_date = '"+ bil.Select_Date_for_view_his_bills.SelectedItem.ToString() + ")";
            cmb.CommandType = CommandType.Text;

            OracleDataReader drr = cmb.ExecuteReader();
            table1.Columns.Add("Customer_Name", typeof(string));
            table1.Columns.Add("Address", typeof(string));
            table1.Columns.Add("Email", typeof(string));
            table1.Columns.Add("Phone_no", typeof(string));
            table1.Load(drr);
            bil.Datagridviewnos_one_Date.DataSource = table1;
            /////////////////////////////////////////////////////////////////
            OracleCommand cmbb = new OracleCommand();
            cmbb.Connection = conn;

            cmbb.CommandText = "select Delivery_boy_Name,Phone_no from Delivery_boy where Delivery_boy_ID IN (Select Delivery_boy_ID from Billwhere Bill_date = '" + bil.Select_Date_for_view_his_bills.SelectedItem.ToString() + ")";
            cmbb.CommandType = CommandType.Text;

            OracleDataReader ddrr = cmbb.ExecuteReader();
            table2.Columns.Add("Delivery_boy_Name", typeof(string));
            table2.Columns.Add("Phone_no", typeof(string));

            table2.Load(ddrr);
            bil.dataGridViewakhr_one_Date.DataSource = table2;
            ////////////////////////////////////////////////////////////////////////
            OracleCommand crm = new OracleCommand();
            crm.Connection = conn;
            // edite here باليز in id 3shan ehna bnktbo b edeno k input fe gomlt el insert
            crm.CommandText = "select PRODUCTS_NAME from LIST_OF_BILL_PRODUCTS where Bill_ID =119";
            crm.CommandType = CommandType.Text;

            OracleDataReader dere = crm.ExecuteReader();
            table3.Columns.Add("PRODUCTS_NAME", typeof(string));

            table3.Load(dere);
            bil.dataGridView_akhr_ymen_bill_date.DataSource = table3;

            dre.Close();

        }

        public void addDelivayBoy(Add_Delivery_Boy booy)
        {

            delivery_boy boy = new delivery_boy();
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            boy.setName(booy.Full_Name_Delivery_Boy_box.Text.ToString());
            boy.setId(int.Parse(booy.ID_Delivery_Boy_box.Text.ToString()));
            boy.setPhone_no(booy.Phone_No_delivery_boy_box.Text.ToString());


            cmd.CommandText = "insert into Delivery_boy values (:Full_Name,:ID,:Phone_No,:No_Orders)";
            cmd.Parameters.Add("Full_Name", boy.getName());
            cmd.Parameters.Add("ID", boy.getId());
            cmd.Parameters.Add("Phone_No", boy.getPhone_no());
            cmd.Parameters.Add("No_Orders", "0");

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Delivery Boy is added");
            }


        }

        public void RemoveDelivaryBoy(Remove_Delivery_Boy booy)
        {

            delivery_boy boy = new delivery_boy();
            string ordb = "Data source=orcl;User Id=hr; Password=hr;";
            OracleConnection conn;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "delete from Delivery_boy where Delivery_boy_ID=:id";

            cmd.Parameters.Add("id", booy.cmb_Delivery_boy_delete.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                booy.cmb_Delivery_boy_delete.Items.RemoveAt(booy.cmb_Delivery_boy_delete.SelectedIndex);
                booy.Full_Name_del_Delivery_Boy_box.Text = "";
                booy.Phone_del_Delivery_Boy_box.Text = "";
                booy.No_Orders_del_delivery_boy_box.Text = "";



                MessageBox.Show("Delivery Boy deleted");
            }


        }
    }

}
