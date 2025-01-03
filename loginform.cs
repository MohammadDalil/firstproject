using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstproject
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("لطفاً نام کاربری و رمز عبور را وارد کنید.");
                return;
            }
            string query = "SELECT * FROM users WHERE UserName = @username AND Passwordd = @password";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string role = reader["UserRole"].ToString();

                        if (role == "Administrator")  
                        {
                            MessageBox.Show("ورود موفق! خوش آمدید مدیر عزیز");
                            AdminForm adminForm = new AdminForm();
                            this.Hide();
                            adminForm.Show();
                        }
                        else  
                        {
                            MessageBox.Show("ورود موفق! خوش آمدید");
                            MainForm userForm = new MainForm();
                            this.Hide();
                            userForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ورود: " + ex.Message);
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // showing approval toast
            var result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید از برنامه خارج شوید؟",
                                         "تأیید خروج",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // if answer is yes
            {
                // clearing inputs
                usernameTextBox.Clear();
                passwordTextBox.Clear();

                // terminating
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
    
