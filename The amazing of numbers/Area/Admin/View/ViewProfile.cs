using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Lecturer.View;

namespace The_amazing_of_numbers.Area.Admin.View
{
    public partial class ViewProfile : Form
    {
        public static int parentX, parentY;

        public ViewProfile()
        {
            InitializeComponent();
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;

        private void ChangPassBtn12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi Mật Khẩu không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (AdminChangePass modal = new AdminChangePass())
                {
                    modalbackground.StartPosition = FormStartPosition.CenterScreen;
                    modalbackground.FormBorderStyle = FormBorderStyle.None;
                    modalbackground.Opacity = 0;
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
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
            }
        }

        private void ChangePinBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi Mật Khẩu không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (AdminChangePin modal = new AdminChangePin())
                {
                    modalbackground.StartPosition = FormStartPosition.CenterScreen;
                    modalbackground.FormBorderStyle = FormBorderStyle.None;
                    modalbackground.Opacity = 0;
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
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
            }
        }

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
    
      
    }
}
