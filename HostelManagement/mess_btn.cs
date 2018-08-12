using HostelManagement.hmClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class mess_btn : Form
    {
        public mess_btn()
        {
            InitializeComponent();
        }

        hostelClass hc = new hostelClass();


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome wc = new welcome();
            wc.Show();
        }

        private void txtBoxRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mess_btn_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + hostelClass.UserID.ToString();
            DataTable dt1 = hc.mess_select();
            dgvMessList.DataSource = dt1;
            DataTable dt2 = hc.Stu_Mess();
            dgvStuMessList.DataSource = dt2;
        }

        public void Clear()
        {
            txtBoxItemName.Text = "";
            txtBoxTotalPrice.Text = "";
            txtBoxQuantity.Text = "";
            comboBox1.Text = "";
            txtBoxYear.Text = "";            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                hc.item_name = txtBoxItemName.Text;
                hc.item_quantity = int.Parse(txtBoxQuantity.Text);
                hc.total_price = int.Parse(txtBoxTotalPrice.Text);
                hc.month = comboBox1.Text;
                hc.year = txtBoxYear.Text;

                if ((hc.item_name != "") || (hc.item_quantity.ToString() != "") || (hc.total_price.ToString() != "") || (hc.month != "") || (hc.year != ""))
                {
                    bool success = hc.mess_insert(hc);

                    if (success == true)
                    {
                        MessageBox.Show("Item inserted succesfully !");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to insert item. Try Again !");
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something went wrong");
            }
            finally
            {

            }

            DataTable dt = hc.mess_select();
            dgvMessList.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try {
                string keyword = txtBoxSearch.Text;
                SqlConnection conn = new SqlConnection(myconnstr);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM hm_mess WHERE month LIKE '%" + keyword + "%' OR year LIKE '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvMessList.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
