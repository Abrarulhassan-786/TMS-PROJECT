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
    public partial class Trip_Expenditure : Form
    {
        
        public Trip_Expenditure()
        {
            InitializeComponent();
        }

        private void Trip_Expenditure_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TransportExpenses Expenses=new TransportExpenses("Data Source=ABRAR-LAPTOP;Initial Catalog=TransportExpenses;Integrated Security=True");
            Expenses.ExpensesData(txtdate.Text, txtvehical.Text, txtdriverwages.Text, txtdiesel.Text, txtpunchar.Text, txtOil.Text, txtToken.Text, txtrepair.Text);
        }
    }
}
