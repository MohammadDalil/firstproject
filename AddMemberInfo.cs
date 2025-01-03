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
    public partial class AddMemberInfo : Form
    {
        public AddMemberInfo()
        {
            InitializeComponent();
        }

        private void AddMemberInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // بررسی پر بودن فیلدها
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameBox.Text) ||
                string.IsNullOrWhiteSpace(AddressBox.Text) ||
                string.IsNullOrWhiteSpace(NumberBox.Text))
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // گرفتن اطلاعات از کنترل‌ها
            string memberName = NameBox.Text.Trim();
            string memberSurname = LastNameBox.Text.Trim();
            string address = AddressBox.Text.Trim();
            string contactNo = NumberBox.Text.Trim();
            DateTime dob = dobBox.Value;

            // اتصال به دیتابیس
            string connectionString = "Data Source=.;Initial Catalog=Library;Integrated Security=True"; // اتصال به دیتابیس
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // بررسی وجود اطلاعات مشابه در دیتابیس
                    string checkQuery = "SELECT COUNT(*) FROM Members WHERE member_Name = @Name AND Member_Surname = @Surname AND Address = @Address AND Contact_no = @ContactNo AND DOB = @DOB";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Name", memberName);
                        checkCommand.Parameters.AddWithValue("@Surname", memberSurname);
                        checkCommand.Parameters.AddWithValue("@Address", address);
                        checkCommand.Parameters.AddWithValue("@ContactNo", contactNo);
                        checkCommand.Parameters.AddWithValue("@DOB", dob);

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("این عضو قبلاً در سیستم ثبت شده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // ذخیره اطلاعات جدید در دیتابیس
                    string insertQuery = "INSERT INTO Members (member_Name, Member_Surname, Address, Contact_no, DOB) VALUES (@Name, @Surname, @Address, @ContactNo, @DOB)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Name", memberName);
                        insertCommand.Parameters.AddWithValue("@Surname", memberSurname);
                        insertCommand.Parameters.AddWithValue("@Address", address);
                        insertCommand.Parameters.AddWithValue("@ContactNo", contactNo);
                        insertCommand.Parameters.AddWithValue("@DOB", dob);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("عضو جدید با موفقیت ثبت شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // پاک کردن فیلدها بعد از ذخیره موفقیت‌آمیز
                            NameBox.Clear();
                            LastNameBox.Clear();
                            AddressBox.Clear();
                            NumberBox.Clear();
                            dobBox.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("خطایی در ثبت اطلاعات رخ داد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
