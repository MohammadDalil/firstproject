using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace firstproject
{
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShowUsers_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string username = UserNameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();
            string confirmPassword = RePasswordBox.Text.Trim();
            string role = UserRoleBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("رمز عبور و تأیید رمز عبور با هم مطابقت ندارند.");
                return;
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "INSERT INTO Users (UserName, Passwordd, UserRole) VALUES (@username, @password, @role)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("کاربر با موفقیت ثبت شد.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ثبت کاربر: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {
            UserNameBox.Clear();
            UserRoleBox.Clear();
            PasswordBox.Clear();
            RePasswordBox.Clear();

            MessageBox.Show("فرم برای ورود اطلاعات جدید آماده است.");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string username = UserNameBox.Text;

            // بررسی اینکه نام کاربری خالی نباشد
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("لطفاً نام کاربری را وارد کنید.");
                return;
            }

            // نمایش پیام تأیید حذف
            var confirmResult = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این کاربر را حذف کنید؟",
                                                "تأیید حذف",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                // اتصال به دیتابیس
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    string query = "DELETE FROM Users WHERE UserName = @username";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("کاربر با موفقیت حذف شد.");
                        }
                        else
                        {
                            MessageBox.Show("کاربری با این نام پیدا نشد.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطا در حذف کاربر: " + ex.Message);
                    }
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
            string username = UserNameBox.Text;
            string role = UserRoleBox.Text;
            string password = PasswordBox.Text;
            string confirmPassword = RePasswordBox.Text;

            // بررسی خالی نبودن فیلدها و تطابق گذرواژه‌ها
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("لطفاً تمامی فیلدها را پر کنید.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("گذرواژه و تکرار گذرواژه مطابقت ندارند.");
                return;
            }

            // به‌روزرسانی اطلاعات در دیتابیس
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "UPDATE Users SET UserRole = @role, Passwordd = @password WHERE UserName = @username";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("اطلاعات با موفقیت به‌روزرسانی شد.");
                        View_Click(sender, e); // به‌روزرسانی DataGridView
                    }
                    else
                    {
                        MessageBox.Show("کاربری با این نام پیدا نشد.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ویرایش اطلاعات: " + ex.Message);
                }
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT UserName, UserRole, Passwordd FROM Users";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در نمایش اطلاعات: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  // بررسی کلیک روی یک ردیف معتبر
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // انتقال داده‌ها از سلول‌های ردیف به TextBoxها
                UserNameBox.Text = row.Cells["UserName"].Value.ToString();
                UserRoleBox.Text = row.Cells["UserRole"].Value.ToString();
                PasswordBox.Text = row.Cells["Passwordd"].Value.ToString();
                RePasswordBox.Text = row.Cells["Passwordd"].Value.ToString();

                // پنهان کردن DataGridView بعد از کلیک
                dataGridView1.Visible = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {   
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                UserNameBox.Text = row.Cells["UserName"].Value.ToString();
                UserRoleBox.Text = row.Cells["UserRole"].Value.ToString();
                PasswordBox.Text = row.Cells["Passwordd"].Value.ToString();
                RePasswordBox.Text = row.Cells["Passwordd"].Value.ToString();
                //dataGridView1.Visible = false;
            }
        }   
    }
}
