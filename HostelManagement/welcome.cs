using HostelManagement.hmClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + hostelClass.UserID.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHostel_Click(object sender, EventArgs e)
        {
            hostel_btn hbo = new hostel_btn();
            hbo.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            login l = new login();
            l.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            student_btn sbo = new student_btn();
            sbo.Show();
            this.Hide();
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            mess_btn mb = new mess_btn();
            mb.Show();
            this.Hide();
        }
    }
}
