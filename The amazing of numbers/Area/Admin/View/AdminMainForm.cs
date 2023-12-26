using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Admin.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Admin.View
{
    public partial class AdminMainForm : Form
    {

        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        public AdminMainForm()
        {
         
            InitializeComponent();
        }
        /*Cusor Moving Form*/
        private void Form_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void Form_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
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
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FeeButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddingRule());
        }

        private void EditingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditRule());

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewProfile());
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddingRule());
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditRule());
        }

        private void SystemButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewProfile());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
