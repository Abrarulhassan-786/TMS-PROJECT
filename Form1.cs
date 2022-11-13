using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transport_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsignacc_Click(object sender, EventArgs e)
        {
            Form f1 = new SignUp();
            f1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f2 = new Login_Form();
            f2.Show();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form F3 = new ContactUs();
            F3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f4 = new Trip_Expenditure();
            f4.Show();
        }
    }
}
