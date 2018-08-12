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
    public partial class hostel_btn : Form
    {
        public hostel_btn()
        {
            InitializeComponent();
        }

        hostelClass hc = new hostelClass();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hostel_btn_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + hostelClass.UserID.ToString();
            DataTable dt = hc.room_select();
            dgvRoomList.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtBoxRoom_id.Text = "";
            txtBoxRoomNo.Text = "";
            cmbRoomType.Text = "";
            txtBoxNoBeds.Text = "";
            txtBoxPrice.Text = "";
            txtBoxDesc.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            hc.room_no = txtBoxRoomNo.Text;
            hc.room_type = cmbRoomType.Text;
            hc.no_of_beds = txtBoxNoBeds.Text;
            hc.price = txtBoxPrice.Text;
            hc.description = txtBoxDesc.Text;
            hc.availability = "YES";

            if ((hc.room_type != "") || (hc.no_of_beds != "") || (hc.price != "") || (hc.description != ""))
            {
                bool success = hc.room_insert(hc);

                if (success == true)
                {
                    MessageBox.Show("New Room Added Succesfully !");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Failed to add new room. Try Again !");
            }

            DataTable dt = hc.room_select();
            dgvRoomList.DataSource = dt;
        }

        private void dgvRoomList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBoxRoom_id.Text = dgvRoomList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxRoomNo.Text = dgvRoomList.Rows[rowIndex].Cells[1].Value.ToString();
            cmbRoomType.Text = dgvRoomList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxNoBeds.Text = dgvRoomList.Rows[rowIndex].Cells[4].Value.ToString();
            txtBoxPrice.Text = dgvRoomList.Rows[rowIndex].Cells[5].Value.ToString();
            txtBoxDesc.Text = dgvRoomList.Rows[rowIndex].Cells[6].Value.ToString();
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM hm_rooms WHERE room_no LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvRoomList.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                hc.room_id = int.Parse(txtBoxRoom_id.Text);
                hc.room_no = txtBoxRoomNo.Text;
                hc.room_type = cmbRoomType.Text;
                hc.no_of_beds = txtBoxNoBeds.Text;
                hc.price = txtBoxPrice.Text;
                hc.description = txtBoxDesc.Text;

                bool suucess = hc.room_update(hc);
                if (suucess == true)
                {
                    MessageBox.Show("Updated Succesfully !");
                    DataTable dt = hc.room_select();
                    dgvRoomList.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something Went wrong.");
            }
            finally
            {
                
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                hc.room_id = Convert.ToInt32(txtBoxRoom_id.Text);
                bool success = hc.room_delete(hc);
                if (success == true)
                {
                    MessageBox.Show("Room Deleted Succesfully!");
                    DataTable dt = hc.room_select();
                    dgvRoomList.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to Delete, Try Again");
                }
            }
            catch
            {
                MessageBox.Show("Oops! Something Went wrong.");
            }
        }

        private void txtBoxRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRoomType_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNoBeds_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNoBeds_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void lbl_roomNo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxRoom_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome wc = new welcome();
            wc.Show();
        }
    }
}
