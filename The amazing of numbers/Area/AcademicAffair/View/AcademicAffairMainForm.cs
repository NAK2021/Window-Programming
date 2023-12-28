using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Lecturer.View;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AcademicAffairMainForm : Form
    {
        public AcademicAffairMainForm()
        {
            InitializeComponent();
        }

        private void AcademicAffairMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dBUniversityDataSet.Student);

        }
        private void hideSubMenu()
        {

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AddingButton_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(ProfileDropDownPanel);
        }

        private void AddingButton_MouseLeave(object sender, EventArgs e)
        {
            if (ProfileDropDownPanel.Visible == true)
            {
                ProfileDropDownPanel.Visible = true;
            }
        }

        private void StatisticButton_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(CourseDropDownPanel);
        }

        private void StatisticButton_MouseLeave(object sender, EventArgs e)
        {
            if (CourseDropDownPanel.Visible == true)
            {
                CourseDropDownPanel.Visible = true;
            }
        }

        private void ViewButton_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(StaDropDownPanel);
        }

        private void ViewButton_MouseLeave(object sender, EventArgs e)
        {
            if (StaDropDownPanel.Visible == true)
            {
                StaDropDownPanel.Visible = true;
            }
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
        private void HomeButton2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void panelchild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudent());
        }

        private void AddLecture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddLecture());
        }

        private void Addcourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCourse());
        }
    }
}
