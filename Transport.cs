using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Management_System
{
    class Transport
    {
       
        public string DriverName;
        public string customerName;
        public string customerEmail;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter adpt;
        public DataTable dt;

        public Transport(string Con_String)
        {
            con = new SqlConnection(Con_String);
        }
        public void signup(string first, string last, string email, string pass, string confpass)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO RegistrationForm (First_Name,Last_Name,Email,Pass_Word,Confirm_Password)values(@first,@last,@email,@pass,@confpass)", con);
            cmd.Parameters.AddWithValue("@first", first);
            cmd.Parameters.AddWithValue("@last", last);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@confpass", confpass);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Logins(string email, string password)
        {

            con.Open();
           adpt = new SqlDataAdapter("SELECT Email ,Pass_Word FROM RegistrationForm where  Email = '" + email + "' and Pass_Word ='" + password + "'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successfuly", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login_Form.log = true;
            }
            else
            {
                MessageBox.Show("Email or pass is incorrect!");
                Login_Form.log = false;
            }
            con.Close();
        }
    }
    class TransportInfomation : Transport
    {
        private string slipNo;
        private string Date;
        private string Factory;
        private string VehicalNo;
        public string typesofMaterial;
        public string transportAmount;
        public string AmountPaid;

        public TransportInfomation(string Con_String) :base(Con_String)
        {
                
        }
        public DataTable DisplayData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            dt = new DataTable();
            adpt = new SqlDataAdapter();
            cmd.CommandText = "select * from transportinformation";
            cmd.ExecuteNonQuery();
            adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public void Insert(string slip,string date,string factory,string vehicNo,string Material,string driverN,string customerN,string custemail,string tranpAmount,string amountpaid)
        {
            slipNo = slip;
            Date = date;
            Factory = factory;
            VehicalNo = vehicNo;
            typesofMaterial = Material;
            DriverName = driverN;
            customerName = customerN;
            customerEmail = custemail;
            transportAmount = tranpAmount;
            AmountPaid = amountpaid;
            if (slipNo != "" && Date != "" && Factory != "" && VehicalNo != "" && typesofMaterial != "" && DriverName != "" && customerName != "" && customerEmail != "" && transportAmount != "" && AmountPaid != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into transportinformation values('" + slipNo + "','" + Date + "','" + Factory + "','" + VehicalNo + "','" + typesofMaterial + "','" + DriverName + "','" + customerName + "','" + customerEmail + "','" + transportAmount + "','" + AmountPaid + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted Data ","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Provide Data","Unsuccessfully",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }
        public void Update(string slip, string date, string factory, string vehicNo, string Material, string driverN, string customerN, string custemail, string tranpAmount, string amountpaid)
        {
            slipNo = slip;
            Date = date;
            Factory = factory;
            VehicalNo = vehicNo;
            typesofMaterial = Material;
            DriverName = driverN;
            customerName = customerN;
            customerEmail = custemail;
            transportAmount = tranpAmount;
            AmountPaid = amountpaid;
            if (slipNo != "" && Date != "" && Factory != "" && VehicalNo != "" && typesofMaterial != "" && DriverName != "" && customerName != "" && customerEmail != "" && transportAmount != "" && AmountPaid != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update transportinformation set slipNo='"+slipNo+"',date_d='"+Date+"',factory='"+Factory+"',vehicalNo='"+VehicalNo+"',typesoftransp='"+typesofMaterial+"',driverName='"+DriverName+"',customerName='"+customerName+"',customerEmail='"+customerEmail+"',transportAmount='"+transportAmount+"',amount_paid='"+AmountPaid+"' where slipNo='"+slipNo+"'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Data ", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Provide Data", "Unsuccessfully", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        public void DeleteData(string slip, string date, string factory, string vehicNo, string Material, string driverN, string customerN, string custemail, string tranpAmount, string amountpaid)
        {
            slipNo = slip;
            Date = date;
            Factory = factory;
            VehicalNo = vehicNo;
            typesofMaterial = Material;
            DriverName = driverN;
            customerName = customerN;
            customerEmail = custemail;
            transportAmount = tranpAmount;
            AmountPaid = amountpaid;
            if (slipNo != "" && Date != "" && Factory != "" && VehicalNo != "" && typesofMaterial != "" && DriverName != "" && customerName != "" && customerEmail != "" && transportAmount != "" && AmountPaid != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from transportinformation where slipNo='" + slipNo + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Data ", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Provide Data", "Unsuccessfully", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
    }
        class TransportExpenses : Transport
        {
            private string date;
            private string VehicalNo;
            private string DriverWages;
            private string Diesel;
            private string Punchar;
            private string Oil;
            private string RoadToken;
            private string Repair;

            public TransportExpenses(string Con_String) :base(Con_String)
            {
                    
            }
            public void ExpensesData(string da, string v, string dri, string die, string pun, string O, string tok, string rep)
            {
                date = da;
                VehicalNo = v;
                DriverWages = dri;
                Diesel = die;
                Punchar = pun;
                Oil = O;
                RoadToken = tok;
                Repair = rep;

                if (date != "" && VehicalNo != "" && DriverWages != "" && Diesel != "" && Punchar != "" && Oil != "" && RoadToken != "" && Repair != "")
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into TransportExpenses values('" + date + "','" + VehicalNo + "','" + DriverWages + "','" + Diesel + "','" + Punchar + "','" + Oil + "','" + RoadToken + "','" + Repair +"')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Save Data ", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Provide Data", "Unsuccessfully", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
           
        }

    }

