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
    public partial class ViewInfomations : Form
    {
        public ViewInfomations()
        {
            InitializeComponent();
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
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ViewStudentinfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile());
        }

        private void ViewLectureInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile());

        }

        private void ViewCourseInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse());

        }

        private void ViewDepartmentsInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment());

        }

        private void ViewClassInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered());

        }
        private void ViewInfomations_Load(object sender, EventArgs e)
        {

        }

    }
}
