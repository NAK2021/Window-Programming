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
        //add to dataGridView
        private void addbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNo.Text, txtID.Text, txtName.Text, 
                txtDOB.Text, txtSex.Text, txtEmail.Text, txtPhone.Text, 
                txtDeparment.Text, txtStatus.Text, txtTeachingExperience.Text
                , txtAcademicRank.Text, txtAssignedSubject.Text);
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
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtDeparment.Text = "";
            txtStatus.Text = "";
            txtTeachingExperience.Text = "";
            txtAcademicRank.Text = "";
            txtAssignedSubject.Text = "";
        }
    }
}
