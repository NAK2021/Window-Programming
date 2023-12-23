using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentForm_Progess : Form
    {
        public StudentForm_Progess()
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
            StudentProgress.Controls.Add(childForm);
            StudentProgress.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void StudentForm_Progess_Load(object sender, EventArgs e)
        {

        }


        private void AchievementButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentAchievements());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhGiaRenLuyen());
        }
    }
}
