using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentForm_StudentProfile : Form
    {

 
        public StudentForm_StudentProfile()
        {
            InitializeComponent();
           /* this.VerticalScroll.Value = desiredScrollPosition;*/
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild ;
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
            ProfileUser_Info.Controls.Add(childForm);
            ProfileUser_Info.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.Focus();
        }
        //Edit Profile
        private void EditInfo_Button(object sender, EventArgs e)
        {
            OpenChildForm ( new ProfileEdition());
           
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Student_Score());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileEdition());
        }
    }
}
