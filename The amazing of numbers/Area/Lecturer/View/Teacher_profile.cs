using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Teacher_profile : Form
    {
        public Teacher_profile()
        {
            InitializeComponent();
        }
        /*Setting multi panel child content*/
        //Panel child content 
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
            Lecture_Profile.Controls.Add(childForm);
            Lecture_Profile.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec());
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec());
        }
    }
}
