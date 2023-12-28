using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.AcademicAffair
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

      
        //add to DataGirdView
        private void addbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNo.Text, txtID.Text, txtName.Text, txtDOB.Text, txtSex.Text, txtClass.Text, txtPhone.Text, txtDeparment.Text, txtStatus.Text);
            clear();
        }
        //reset each add
        public void clear()
        {
            txtNo.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtDOB.Text = "";
            txtSex.Text = "";
            txtClass.Text = "";
            txtPhone.Text = "";
            txtDeparment.Text = "";
            txtStatus.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
