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

        private void LoadBooks()
        {
            string query = "SELECT * FROM Books";  // دریافت تمام کتاب‌ها از دیتابیس

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);
                    booksGridView.DataSource = table;  // نمایش داده‌ها در DataGridView
                    booksGridView.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در بارگذاری اطلاعات کتاب‌ها: " + ex.Message);
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

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // اطمینان از اینکه روی یک ردیف کلیک شده
            {
                DataGridViewRow row = booksGridView.Rows[e.RowIndex];

                bookID.Text = row.Cells["Book_ID"].Value.ToString();
                titlebook.Text = row.Cells["Book_Title"].Value.ToString();
                authorbook.Text = row.Cells["Author"].Value.ToString();
                publisherbook.Text = row.Cells["Publisher"].Value.ToString();
                categorybook.Text = row.Cells["Category"].Value.ToString();
                quantitybook.Text = row.Cells["Quantity"].Value.ToString();
                booksGridView.Visible = false;
            }
        }

        private void UpdateBook()
        {
            string query = "UPDATE Books SET Book_Title = @title, Author = @author, Publisher = @publisher, Category = @category, Quantity = @quantity WHERE Book_ID = @id";



            using (SqlConnection connection = DBConnection.GetConnection())
            {


                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", bookID.Text);
                cmd.Parameters.AddWithValue("@title", titlebook.Text);
                cmd.Parameters.AddWithValue("@author", authorbook.Text);
                cmd.Parameters.AddWithValue("@publisher", publisherbook.Text);
                cmd.Parameters.AddWithValue("@category", categorybook.Text);
                cmd.Parameters.AddWithValue("@quantity", quantitybook.Text);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("اطلاعات کتاب با موفقیت ویرایش شد.");
                    LoadBooks();  // بارگذاری مجدد لیست کتاب‌ها
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ویرایش اطلاعات: " + ex.Message);
                }
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bookID.Text) || string.IsNullOrWhiteSpace(titlebook.Text) ||
                string.IsNullOrWhiteSpace(authorbook.Text) || string.IsNullOrWhiteSpace(publisherbook.Text) ||
                string.IsNullOrWhiteSpace(categorybook.Text) || string.IsNullOrWhiteSpace(quantitybook.Text))
            {
                //MessageBox.Show("لطفاً همه فیلدها را پر کنید.");
                return; // جلوگیری از ادامه عملیات
            }

            UpdateBook();
        }
        
        private void AddBook()
        {
            string query = "INSERT INTO Books (Book_Title, Author, Publisher, Category, Quantity) VALUES (@title, @author, @publisher, @category, @quantity)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", titlebook.Text);
                cmd.Parameters.AddWithValue("@author", authorbook.Text);
                cmd.Parameters.AddWithValue("@publisher", publisherbook.Text);
                cmd.Parameters.AddWithValue("@category", categorybook.Text);
                cmd.Parameters.AddWithValue("@quantity", quantitybook.Text);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("کتاب جدید با موفقیت اضافه شد.");
                    LoadBooks();  // لیست کتاب‌ها را بارگذاری مجدد کن
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در افزودن کتاب: " + ex.Message);
                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            AddBook();
        }
    }
}

