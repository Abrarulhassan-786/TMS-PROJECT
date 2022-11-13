using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transport_Management_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
       
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Transport trans = new Transport("Data Source=ABRAR-LAPTOP;Initial Catalog=RegistrationForm;Integrated Security=True");
            if (txtfirst.Text != "" && txtlast.Text != "" && txtemail.Text != "" && txtpass.Text != "" && txtconfpass.Text != "")
            {
                trans.signup(txtfirst.Text, txtlast.Text, txtemail.Text, txtpass.Text, txtconfpass.Text);
                MessageBox.Show("Recorde Inserted ", "SucessFully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Provide The Data", "Acknowledgement", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
