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
    public partial class AddLecture : Form
    {
        public AddLecture()
        {
            InitializeComponent();
        }
        private void AddingButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNo.Text, txtID.Text, txtName.Text,
                           txtDOB.Text, txtSex.Text, txtEmail.Text, txtPhone.Text,
                           txtDeparment.Text, txtStatus.Text, txtTeachingExperience.Text
                           , txtAcademicRank.Text, txtAssignedSubject.Text);
            clear();
        }
        //add to dataGridView
        private void addbtn_Click(object sender, EventArgs e)
        {
           
        }
        //reset each add
        public void clear()
        {
            txtNo.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtDOB.Text = "";
            txtSex.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtDeparment.Text = "";
            txtStatus.Text = "";
            txtTeachingExperience.Text = "";
            txtAcademicRank.Text = "";
            txtAssignedSubject.Text = "";
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLecture_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtTeachingExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeparment_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
