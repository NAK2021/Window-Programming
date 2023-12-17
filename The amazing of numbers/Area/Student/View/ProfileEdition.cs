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
    public partial class ProfileEdition : Form
    {
        public ProfileEdition()
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
            ProfileUser_Info.Controls.Add(childForm);
            ProfileUser_Info.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void EditInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }
    }
}
