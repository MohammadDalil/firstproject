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
    public partial class AddBookInfo : Form
    {
        public AddBookInfo()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            string query = "SELECT DISTINCT Category FROM Books";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        categorybook.Items.Add(reader["Category"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در بارگذاری دسته‌بندی‌ها: " + ex.Message);
                }
            }
        }

        private void AddBookInfo_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // دریافت اطلاعات از فیلدها
            string bookId = bookID.Text;
            string title = titlebook.Text;
            string author = authorbook.Text;
            string publisher = publisherbook.Text;
            string category = categorybook.SelectedItem?.ToString();
            string quantity = quantitybook.Text;

            // اعتبارسنجی
            if (string.IsNullOrWhiteSpace(bookId) || string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(publisher) ||
                string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید.");
                return;
            }

            // ثبت اطلاعات در دیتابیس
            string query = "INSERT INTO Books (Book_ID, Book_Title, Author, Publisher, Category, Quantity) " +
                           "VALUES (@bookId, @title, @author, @publisher, @category, @quantity)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@quantity", quantity);

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("کتاب با موفقیت اضافه شد.");
                        this.Close();  // بستن فرم
                    }
                    else
                    {
                        MessageBox.Show("افزودن کتاب ناموفق بود.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در افزودن کتاب: " + ex.Message);
                }
            }
        }
        // دکمه انصراف
        private void cancelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید فرم را ببندید؟",
                                         "تأیید",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }


        }
    }
}

