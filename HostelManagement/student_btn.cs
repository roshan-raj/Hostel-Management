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
    public partial class student_btn : Form
    {
        public student_btn()
        {
            InitializeComponent();
        }

        hostelClass hc = new hostelClass();

        public void Clear()
        {
            txtBoxStudentID.Text = "";
            txtBoxRoomID.Text = "";
            txtBoxStudentName.Text = "";
            txtBoxUSN.Text = "";
            txtBoxPhone.Text = "";
            txtBoxEmail.Text = "";
            txtBoxRoomNo.Text = "";
            cmbMessFaci.Text = "";
        }

        private void lbl_roomNo_Click(object sender, EventArgs e)
        {

        }

        private void student_btn_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + hostelClass.UserID.ToString();
            DataTable dt1 = hc.avail_room_select();
            dgvAvailableRooms.DataSource = dt1;
            DataTable dt2 = hc.student_select();
            dgvStudentList.DataSource = dt2;
        }

        private void dgvAvailableRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAvailableRooms_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBoxRoomNo.Text = dgvAvailableRooms.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxRoomID.Text = dgvAvailableRooms.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxNumberBedsH.Text = dgvAvailableRooms.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void dgvStudentList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtBoxStudentID.Text = dgvStudentList.Rows[rowIndex].Cells[0].Value.ToString();
            txtBoxStudentName.Text = dgvStudentList.Rows[rowIndex].Cells[1].Value.ToString();
            txtBoxUSN.Text = dgvStudentList.Rows[rowIndex].Cells[2].Value.ToString();
            txtBoxPhone.Text = dgvStudentList.Rows[rowIndex].Cells[3].Value.ToString();
            txtBoxEmail.Text = dgvStudentList.Rows[rowIndex].Cells[4].Value.ToString();
            txtBoxRoomNo.Text = dgvStudentList.Rows[rowIndex].Cells[6].Value.ToString();
            cmbMessFaci.Text = dgvStudentList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                hc.student_name = txtBoxStudentName.Text;
                hc.student_usn = txtBoxUSN.Text;
                hc.student_phone = txtBoxPhone.Text;
                hc.student_email = txtBoxEmail.Text;
                hc.room_id = int.Parse(txtBoxRoomID.Text);
                hc.mess = cmbMessFaci.Text;

                if ((hc.student_name != "") || (hc.student_phone != "") || (hc.student_email != "") || (hc.student_usn != ""))
                {
                    bool success = hc.student_insert(hc);

                    if (success == true)
                    {
                        MessageBox.Show("Room assigned succesfully !");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to assign room. Try Again !");
                }
            }
            catch
            {
                MessageBox.Show("Student with the above details has a room already.");
            }
            finally
            {

            }

            DataTable dt = hc.student_select();
            dgvStudentList.DataSource = dt;
            DataTable dt1 = hc.avail_room_select();
            dgvAvailableRooms.DataSource = dt1;
        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBoxStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxRoomID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                hc.student_id = int.Parse(txtBoxStudentID.Text);
                hc.student_name = txtBoxStudentName.Text;
                hc.student_usn = txtBoxUSN.Text;
                hc.student_phone = txtBoxPhone.Text;
                hc.student_email = txtBoxEmail.Text;
                hc.mess = cmbMessFaci.Text;

                bool success = hc.student_update(hc);
                if (success == true)
                {
                    MessageBox.Show("Updated Successfully!");
                    DataTable dt = hc.student_select();
                    dgvStudentList.DataSource = dt;
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed!");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                hc.student_id = Convert.ToInt32(txtBoxStudentID.Text);
                bool success = hc.student_delete(hc);
                if (success == true)
                {
                    MessageBox.Show("Student Details Deleted Succesfully!");
                    DataTable dt = hc.student_select();
                    dgvStudentList.DataSource = dt;
                    DataTable dt1 = hc.avail_room_select();
                    dgvAvailableRooms.DataSource = dt1;
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
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM hm_rooms WHERE room_no LIKE '%" + keyword + "%' AND availability = 'YES'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAvailableRooms.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT s.student_id, s.student_name, s.student_usn, s.student_phone, s.student_email, r.room_no FROM hm_student s, hm_rooms r WHERE student_name LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStudentList.DataSource = dt;
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome wc = new welcome();
            wc.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
