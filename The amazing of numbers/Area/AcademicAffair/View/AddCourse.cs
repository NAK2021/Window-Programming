using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNo.Text, txtCourseID.Text, txtCourseName.Text,
                txtDeparmentID.Text, txtCredits.Text, txtCost.Text);
            clear();
        }
        //reset each add
        public void clear()
        {
            txtNo.Text = "";
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtDeparmentID.Text = "";
            txtCredits.Text = "";
            txtCost.Text = "";
        }
    }
}
