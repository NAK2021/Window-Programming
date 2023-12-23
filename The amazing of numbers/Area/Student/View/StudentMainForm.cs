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
using System.Diagnostics;
namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentMainForm : Form
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
        public StudentMainForm()
        {
            InitializeComponent();
            /*thiết lập kiểu viền của form thành không, loại bỏ viền mặc định.*/
            this.FormBorderStyle = FormBorderStyle.None;
            /*0, 0: Tọa độ của góc trên bên trái của hình chữ nhật.
            Width, Height: Tọa độ của góc dưới bên phải của hình chữ nhật, được đặt bằng chiều rộng và chiều cao của form.
            20, 20: Chiều rộng và chiều cao của hình elip được sử dụng để tạo các góc bo tròn.*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

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
            childForm.Show();
            childForm.BringToFront();
        }
        // Side Bar
        bool sidebarExpand;
        private void sidebar_timerTick_Tick_1(object sender, EventArgs e)
        {
            //SET the mininum and maximum size of the sizebar

            // if sidebar is expand , minimized it
/*            if (sidebarExpand)
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
            }*/
        }
         private void MenuBtn_Click(object sender, EventArgs e)
        {
            sidebar_timerTick.Start();
        }
        /*Close and Minimize window form*/
        // Close window
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        /*Panel list*/
        // Default panel  
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
        //Profile Student
        private void ProfileButton_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new StudentForm_StudentProfile());

        }
        private void ProfileButton_MouseHover_1(object sender, EventArgs e)
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
            OpenChildForm(new StudentForm_CourseButton());

        }
        private void CourseButton_MouseHover(object sender, EventArgs e)
        {
            CourseBtn.Show("Click here to Your Course", CourseButton);
        }
        private void CourseButton_MouseLeave(object sender, EventArgs e)
        {
            CourseBtn.Hide(CourseButton);   
        }
        // Fee panel
        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_StudentFee());
        }
          private void guna2Button3_MouseHover(object sender, EventArgs e)
        {
            FeeBtn.Show("Click here to Your Fee", guna2Button3);

        }
        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            FeeBtn.Hide(guna2Button3);

        }
        // Progess panel
        private void SystemButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_Progess());
        }
       private void SystemButton_MouseHover(object sender, EventArgs e)
        {
            ProgressBtn.Show("Click here to Your Progress", SystemButton);
        }
        private void SystemButton_MouseLeave(object sender, EventArgs e)
        {
            ProgressBtn.Hide(SystemButton);
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


        public void UpdateLable(int ImageNumber, int nextImageNumber)
        {
            
        }

   
    
        private void LoadChecked()
        {
      
        }
      
    
        private void head_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeTool_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FeeBtn_Popup(object sender, PopupEventArgs e)
        {

        }

    

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //Link Label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          Process.Start("https://www.hutech.edu.vn/homepage/tin-tuc/tin-hutech/14614461-giang-vien-sinh-vien-khoa-kien-truc-my-thuat-tham-du-hoi-thao-su-dung-vat-lieu-noi-that-ben-vung-va-");
        }
         private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hutech.edu.vn/homepage/tin-tuc/tin-hutech/14614440-video-hoc-sinh-09-truong-thpt-khu-vuc-quan-binh-thanh-va-tp-thu-duc-soi-noi-tranh-tai-tai-chung-ket-");
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hutech.edu.vn/homepage/tin-tuc/tin-hutech/14614437-hoi-doanh-nghiep-cuu-sinh-vien-vien-khoa-hoc-ung-dung-noi-tiep-lua-dam-me-cho-sinh-vien-chinh-thuc-r");
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hutech.edu.vn/homepage/tin-tuc/tin-hutech/14614417-le-trao-bang-tot-nghiep-thang-122023-tai-hutech-cam-on-cha-me-nguoi-khong-dung-tren-tham-do");
        } 
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hutech.edu.vn/homepage/tin-tuc/tin-hutech");
        }
        private void Picbox2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        /*       private void guna2Button1_Click(object sender, EventArgs e)
               {
                   DialogResult result = MessageBox.Show("Tin nhắn của bạn giờ đây có hiện dưới dạng nặc dang. Bạn có muốn tiếp tục không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                       if(result == DialogResult.Yes)
                   {
                      Form modalbackground = new Form();
                       using(Contact_mess modal = new Contact_mess())
                       {
                           modalbackground.StartPosition = FormStartPosition.Manual;
                           modalbackground.FormBorderStyle = FormBorderStyle.None;
                           modalbackground.Opacity = 0.50d;
                           modalbackground.BackColor = Color.Black;
                           modalbackground.Size = this.Size;
                           modalbackground.Location = this.Location;
                           modalbackground.ShowInTaskbar = false;
                           modalbackground.Show();
                           modal.Owner = modalbackground;

                           parentX = this.Location.X;
                           parentY = this.Location.Y;  

                           modal.ShowDialog();
                           modalbackground.Dispose();
                       }
                   }
                       else
                   {
                       this.Hide();
                   }

       */




        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
