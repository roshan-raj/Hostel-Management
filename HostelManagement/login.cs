using HostelManagement.hmClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        hostelClass hc = new hostelClass();

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            hc.username = textBoxUsername.Text;
            hc.password = textBoxPassword.Text;
          
            bool value = hc.Select(hc);

            if (value)
            {
                clear();
                this.Hide();
            }
                    
        }

        public void clear ()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
