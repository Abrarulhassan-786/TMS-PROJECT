using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Transport_Management_System
{
    public partial class Login_Form : Form
    {
        SqlConnection con;
        SqlDataAdapter adp;
        public static bool log;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Transport login = new Transport("Data Source=ABRAR-LAPTOP;Initial Catalog=RegistrationForm;Integrated Security=True");
            login.Logins(UserName.Text, Password.Text);
            this.Hide();
            TripInformation tr = new TripInformation();
            tr.Show();
            
           
        }

        private void againSignup_Click(object sender, EventArgs e)
        {
            SignUp Sig = new SignUp();
            LayoutMdi(MdiLayout.ArrangeIcons);
            Sig.Show();
        }
    }
}
