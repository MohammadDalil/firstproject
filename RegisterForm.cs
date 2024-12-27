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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {   //getting infos from user 
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string role = roleComboBox.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {   //error handler for completing all fields
                MessageBox.Show("لطفاً همه فیلدها را پر کنید.");
                return;
            }
            using (SqlConnection connection = DBConnection.GetConnection())
            {   //cheking given name with previous data in DB
                //if there is any same username or not!
                string checkUserQuery = "SELECT COUNT(*) FROM users WHERE UserName = @username";
                SqlCommand checkCmd = new SqlCommand(checkUserQuery, connection);
                checkCmd.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {   //yes there is a same username -> we handle that 
                        MessageBox.Show("این نام کاربری قبلاً ثبت شده است.");
                        return;
                    }

                    // new registration (-> we dont have same username)
                    string insertQuery = "INSERT INTO Users (UserName, Password, UserRole) VALUES (@username, @password, @role)";
                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ثبت‌ نام با موفقیت انجام شد!");
                    this.Hide();
                    loginform loginform = new loginform();
                    loginform.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ثبت اطلاعات: " + ex.Message);
                }
            }
        }
        //choose one role from all 3 roles in combobox
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            roleComboBox.Items.Add("مدیر");
            roleComboBox.Items.Add("کارمند");
            roleComboBox.Items.Add("عضو");
            roleComboBox.SelectedIndex = 0; //default value
        }
    }
}
        



    

