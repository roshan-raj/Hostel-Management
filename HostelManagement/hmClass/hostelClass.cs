using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.hmClass
{
    class hostelClass
    {
        public string Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public static string UserID { get; set; }
        public int room_id { get; set; }
        public string room_no { get; set; }
        public string room_type { get; set; }
        public string no_of_beds { get; set; }
        public string price { get; set; }
        public string description { get; set; }
        public string availability { get; set; }
        public string old_beds { get; set; }
        public int student_id { get; set; }
        public string student_name { get; set; }
        public string student_usn { get; set; }
        public string student_phone { get; set; }
        public string student_email { get; set; }
        public string mess { get; set; }

        public int itemID { get; set; }
        public string item_name { get; set; }
        public int item_quantity { get; set; }
        public int total_price { get; set;  }
        public string month { get; set;  }
        public string year { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Select(hostelClass h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM hm_login WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", h.username);
                cmd.Parameters.AddWithValue("@password", h.password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    UserID = h.username;
                    welcome settingsForm = new welcome();
                    settingsForm.Show();
                    isSuccess = true;
                }
                else
                {

                    MessageBox.Show("Please enter Correct Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed");
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool room_insert(hostelClass h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO hm_rooms (room_no, room_type, no_of_beds, price, description, availability, total_beds) VALUES (@room_no, @room_type, @no_of_beds, @price, @description, @availability, @no_of_beds)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@room_no", h.room_no);
                cmd.Parameters.AddWithValue("@room_type", h.room_type);
                cmd.Parameters.AddWithValue("@no_of_beds", h.no_of_beds);
                cmd.Parameters.AddWithValue("@price", h.price);
                cmd.Parameters.AddWithValue("@description", h.description);
                cmd.Parameters.AddWithValue("@availability", h.availability);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to add room, Try Again.");
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool room_update(hostelClass h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            conn.Open();
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT total_beds FROM hm_rooms WHERE room_id = @room_id",conn);
                cmd1.Parameters.AddWithValue("@room_id", h.room_id);
                SqlDataReader old_total_beds = null;
                old_total_beds = cmd1.ExecuteReader();
                while(old_total_beds.Read())
                {
                    old_beds = old_total_beds["total_beds"].ToString();
                    //MessageBox.Show(old_beds);
                }                
                string sql = "UPDATE hm_rooms SET room_no = @room_no, room_type = @room_type, total_beds = @no_of_beds, price = @price, description = @description WHERE room_id = @room_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@room_id", h.room_id);
                cmd.Parameters.AddWithValue("@room_no", h.room_no);
                cmd.Parameters.AddWithValue("@room_type", h.room_type);
                cmd.Parameters.AddWithValue("@no_of_beds", h.no_of_beds);
                cmd.Parameters.AddWithValue("@price", h.price);
                cmd.Parameters.AddWithValue("@description", h.description);

                old_total_beds.Close();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                    string sql0 = "UPDATE hm_rooms SET no_of_beds = no_of_beds + (total_beds - @old_beds) WHERE room_id = @room_id";
                    SqlCommand cmd0 = new SqlCommand(sql0, conn);
                    cmd0.Parameters.AddWithValue("@room_id", h.room_id);
                    cmd0.Parameters.AddWithValue("@old_beds", Convert.ToInt32(h.old_beds));
                    cmd0.ExecuteNonQuery();

                    string sql2 = "UPDATE hm_rooms SET availability = 'NO' WHERE no_of_beds < 1";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();

                    string sql3 = "UPDATE hm_rooms SET availability = 'YES' WHERE no_of_beds > 0";
                    SqlCommand cmd3 = new SqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to update the details, Try again." + ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool room_delete(hostelClass h)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM hm_rooms WHERE room_id = @room_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@room_id", h.room_id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete the room, Try Again.");
            }
            finally
            {

            }
            return isSuccess;
        }

        public DataTable room_select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM hm_rooms ORDER BY room_no";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable avail_room_select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM hm_rooms WHERE availability = 'YES'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable student_select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT s.student_id, s.student_name, s.student_usn, s.student_phone, s.student_email, s.mess, r.room_no FROM hm_student s, hm_rooms r WHERE s.room_id = r.room_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool student_insert(hostelClass h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO hm_student (student_name, student_usn, student_phone, student_email, room_id, mess) VALUES (@student_name, @student_usn, @student_phone, @student_email, @room_id, @mess)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@student_name", h.student_name);
                cmd.Parameters.AddWithValue("@student_usn", h.student_usn);
                cmd.Parameters.AddWithValue("@student_phone", h.student_phone);
                cmd.Parameters.AddWithValue("@student_email", h.student_email);
                cmd.Parameters.AddWithValue("@room_id", h.room_id);
                cmd.Parameters.AddWithValue("@mess", h.mess);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                string sql1 = "UPDATE hm_rooms SET no_of_beds = no_of_beds - 1 WHERE room_id = @room_id AND no_of_beds >= 1";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);                
                cmd1.Parameters.AddWithValue("@room_id", h.room_id);
                cmd1.ExecuteNonQuery();

                string sql2 = "UPDATE hm_rooms SET availability = 'NO' WHERE no_of_beds = 0";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to add the student, Try Again.");
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool student_update(hostelClass h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE hm_student SET student_name = @student_name, student_usn = @student_usn, student_phone = @student_phone, student_email = @student_email, mess = @mess WHERE student_id = @student_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@student_id", h.student_id);
                cmd.Parameters.AddWithValue("@student_name", h.student_name);
                cmd.Parameters.AddWithValue("@student_usn", h.student_usn);
                cmd.Parameters.AddWithValue("@student_phone", h.student_phone);
                cmd.Parameters.AddWithValue("@student_email", h.student_email);
                cmd.Parameters.AddWithValue("@mess", h.mess);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to update, Try Again!");
            }
            finally
            {

            }
            return isSuccess;
        }
        public bool student_delete(hostelClass h)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                conn.Open();
                string sql0 = "UPDATE hm_rooms SET no_of_beds = no_of_beds + 1 WHERE room_id IN (SELECT room_id FROM hm_student WHERE student_id = @student_id)";
                SqlCommand cmd0 = new SqlCommand(sql0, conn);
                cmd0.Parameters.AddWithValue("@student_id", h.student_id);
                int rows0 = cmd0.ExecuteNonQuery();

                string sql1 = "UPDATE hm_rooms SET availability = 'YES' WHERE availability = 'NO' AND room_id IN (SELECT room_id FROM hm_student WHERE student_id = @student_id)";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@student_id", h.student_id);
                int rows1 = cmd1.ExecuteNonQuery();


                string sql = "DELETE FROM hm_student WHERE student_id = @student_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@student_id", h.student_id);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to delete, Try Again!");
            }
            finally
            {

            }
            return isSuccess;
        }
        public DataTable mess_select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM hm_mess ORDER BY month";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool mess_insert(hostelClass h)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO hm_mess (item_name, item_quantity, total_price, month, year) VALUES (@item_name, @item_quantity, @total_price, @month, @year)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@item_name", h.item_name);
                cmd.Parameters.AddWithValue("@item_quantity", h.item_quantity);
                cmd.Parameters.AddWithValue("@total_price", h.total_price);
                cmd.Parameters.AddWithValue("@month", h.month);
                cmd.Parameters.AddWithValue("@year", h.year);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                MessageBox.Show("Failed to add room, Try Again.");
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public DataTable Stu_Mess()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT r.room_no, s.student_name, s.student_usn, s.student_phone FROM hm_student s, hm_rooms r WHERE s.mess = 'YES' AND s.room_id = r.room_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
