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
    public partial class TripInformation : Form
    {
        TransportInfomation transp = new TransportInfomation("Data Source=ABRAR-LAPTOP;Initial Catalog=transportinformation;Integrated Security=True");
        public TripInformation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = transp.DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transp.Insert(txtslip.Text, txtdate.Text, txtfactory.Text, txtvehical.Text, txtmaterial.Text, txtdrivername.Text, txtcustomerName.Text, txtcustomeremail.Text, txttransportamount.Text, txtamountpaid.Text);
            dataGridView1.DataSource = transp.DisplayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transp.Update(txtslip.Text, txtdate.Text, txtfactory.Text, txtvehical.Text, txtmaterial.Text, txtdrivername.Text, txtcustomerName.Text, txtcustomeremail.Text, txttransportamount.Text, txtamountpaid.Text);
            dataGridView1.DataSource = transp.DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transp.DeleteData(txtslip.Text, txtdate.Text, txtfactory.Text, txtvehical.Text, txtmaterial.Text, txtdrivername.Text, txtcustomerName.Text, txtcustomeremail.Text, txttransportamount.Text, txtamountpaid.Text);
            dataGridView1.DataSource = transp.DisplayData();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtslip.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfactory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtvehical.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtmaterial.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtdrivername.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtcustomerName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcustomeremail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txttransportamount.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtamountpaid.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
