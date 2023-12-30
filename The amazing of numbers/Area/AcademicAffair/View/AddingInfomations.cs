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
    public partial class AddingInfomations : Form
    {
        public AddingInfomations()
        {
            InitializeComponent();
        }
       private void guna2Button1_Click(object sender, EventArgs e)
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
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            AddingFunction.Controls.Add(childForm);
            AddingFunction.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
         private void StudentButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void LectureFunc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddLecture());
        }

        private void CourseFunc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCourse());

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Adding_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddingFunction_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
