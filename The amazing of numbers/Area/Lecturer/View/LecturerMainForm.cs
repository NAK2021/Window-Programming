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

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class LecturerMainForm : Form
    {
        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        /*Set border line for winForm*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        /*Đoạn này khai báo một phương thức static extern cho hàm CreateRoundRectRgn từ thư viện GDI32.dll. 
         * Hàm này được sử dụng để tạo một vùng hình chữ nhật có góc bo tròn.
         */
        private static extern IntPtr CreateRoundRectRgn
             (
                 int nLeftRect,     // x-coordinate of upper-left corner
                 int nTopRect,      // y-coordinate of upper-left corner
                 int nRightRect,    // x-coordinate of lower-right corner
                 int nBottomRect,   // y-coordinate of lower-right corner
                 int nWidthEllipse, // height of ellipse
                 int nHeightEllipse // width of ellipse
             );
        public LecturerMainForm()
        {
            InitializeComponent();
            customizeDesign();
            /*thiết lập kiểu viền của form thành không, loại bỏ viền mặc định.*/
            this.FormBorderStyle = FormBorderStyle.None;
            /*0, 0: Tọa độ của góc trên bên trái của hình chữ nhật.
            Width, Height: Tọa độ của góc dưới bên phải của hình chữ nhật, được đặt bằng chiều rộng và chiều cao của form.
            20, 20: Chiều rộng và chiều cao của hình elip được sử dụng để tạo các góc bo tròn.*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        //Header Panel Selected Menu
        private void customizeDesign()
        {
            ProfileDropDownPanel.Visible = false;
            CourseDropDownPanel.Visible = false;
            ProgressDropDownPanel.Visible = false;
            /* HK2_ScorePanel.Visible = false;*/
            /* panelPlaylistSubmenu.Visible = false;
             panelToolSubmenu.Visible = false;
             panelImageSubmenu.Visible = false;*/
        }
        private void hideSubMenu()
        {
            /*  if (ProfileDropDownPanel.Visible == true)
              {
                  ProfileDropDownPanel.Visible = true;
              }*/
            /*      if (CourseDropDownPanel.Visible == true)
                  {
                      CourseDropDownPanel.Visible = true;
                  }*/
            /*            if (panelToolSubmenu.Visible == true)
                        {
                            panelToolSubmenu.Visible = false;
                        }
                        if (panelImageSubmenu.Visible == true)
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
         private void HomeButton2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void ProfileButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_profile());
        }

        private void CourseButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_course());

        }
        private void AchievmentsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_TeaClas());
        }
        // Profile --- > Hover Button
        private void ProfileHoverOn(object sender, EventArgs e)
        {
            showSubMenu(ProfileDropDownPanel);
        }
        private void ProfileHoverOff(object sender, EventArgs e)
        {
            if (ProfileDropDownPanel.Visible == true)
            {
                ProfileDropDownPanel.Visible = true;
            }
        }
        // Course --- > Hover Button
        private void CourseHoverOn(object sender, EventArgs e)
        {
            showSubMenu(CourseDropDownPanel);
        }
        private void CourseHoverOff(object sender, EventArgs e)
        {
            if (CourseDropDownPanel.Visible == true)
            {
                CourseDropDownPanel.Visible = true;
            }

        }
        //Class ----> Button Hover And Click
        private void ProgressHoverOn(object sender, EventArgs e)
        {
            showSubMenu(ProgressDropDownPanel);
        }
        private void ProgressHoverOff(object sender, EventArgs e)
        {
            if (ProgressDropDownPanel.Visible == true)
            {
                ProgressDropDownPanel.Visible = true;
            }
        }
        private void EditProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec());
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterTeach());
        }

        private void RegisterClassButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterClass()); 
        }

        private void ViewClassesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ScoringButton_Click(object sender, EventArgs e)
        {

        }
        // Side Bar
        bool sidebarExpand; 
        private void sidebar_timerTick_Tick(object sender, EventArgs e)
        {
            //SET the mininum and maximum size of the sizebar
            // if sidebar is expand , minimized it
            if (sidebarExpand)
            {
                SideBar.Width -= 1000;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_timerTick.Stop();
                }
            }
            else
            {
                SideBar.Width += 1000;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_timerTick.Stop();
                }
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            sidebar_timerTick.Start();
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
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // Default Panel
        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
     private void HomeButton_MouseHover(object sender, EventArgs e)
        {
            HomeTool.Show("Click here to Your Home", HomeButton);

        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeTool.Hide(HomeButton);

        }
        //Profile
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_profile());

        }
        private void ProfileButton_MouseHover(object sender, EventArgs e)
        {
            UserProfile.Show("Click here to Your Profile", ProfileButton);

        }
        private void ProfileButton_MouseLeave(object sender, EventArgs e)
        {
            UserProfile.Hide(ProfileButton);

        }
        //Course
        private void CourseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_course());
        } 
        private void CourseButton_MouseHover(object sender, EventArgs e)
        {
            CourseBtn.Show("Click here to Your Course", CourseButton);

        }
        private void CourseButton_MouseLeave(object sender, EventArgs e)
        {
            CourseBtn.Hide(CourseButton);
        }
        //Teacher Class 
        private void TeaClassButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_TeaClas());

        }
        private void SystemButton_MouseHover(object sender, EventArgs e)
        {
            ClassBtn.Show("Click here to Your Class", SystemButton);
        }
        private void SystemButton_MouseLeave(object sender, EventArgs e)
        {
            ClassBtn.Hide(SystemButton);

        }
        //Minimize and Close WinForm
        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WindowState = FormWindowState.Minimized;

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
