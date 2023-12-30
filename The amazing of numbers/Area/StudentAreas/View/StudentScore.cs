using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class Student_Score : Form
    {
        private User user;
        public Student_Score()
        {
            InitializeComponent();
            customizeDesign();
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
            UserInfo.Controls.Add(childForm);
            UserInfo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
   private void EditProBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileEdition(user));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new StudentForm_StudentProfile(user));
        }
     
        private void customizeDesign()
        {
            HK1_ScorePanel.Visible = false;
            HK2_ScorePanel.Visible = false;
           /* panelPlaylistSubmenu.Visible = false;
            panelToolSubmenu.Visible = false;
            panelImageSubmenu.Visible = false;*/
        } 
        private void hideSubMenu()
        {
            if (HK1_ScorePanel.Visible == true)
            {
                HK1_ScorePanel.Visible = true;
            }
            if (HK2_ScorePanel.Visible == true)
            {
                HK2_ScorePanel.Visible = true;
            }
     /*       if (panelToolSubmenu.Visible == true)
            {
                panelToolSubmenu.Visible = false;
            }*/
         /*   if (panelImageSubmenu.Visible == true)
            {
                panelImageSubmenu.Visible = false;

            }*/
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
        private void HK1_Button_Click(object sender, EventArgs e)
        {
            showSubMenu(HK1_ScorePanel);
        }
        private void HK2_Button_Click(object sender, EventArgs e)
        {
            showSubMenu(HK2_ScorePanel);
        }
        private void Student_Score_Load(object sender, EventArgs e)
        {
          
        }
        private void UserInfo_Paint(object sender, PaintEventArgs e)
        {

        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild1;
        private void OpenChildForm2(Form childForm)
        {
            if (currentFormChild1 != null)
            {
                currentFormChild1.Close();
            }
            currentFormChild1 = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelData.Controls.Add(childForm);
            panelData.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new Score202223());
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild1 != null)
            {
                currentFormChild1.Close();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            
            OpenChildForm2(new Score202122());

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new Score202425());
        }

        private void ProfileUser_Info_Paint(object sender, PaintEventArgs e)
        {

        }

     
    }
}
