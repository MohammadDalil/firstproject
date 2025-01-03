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
    public partial class borrowbook : Form
    {
        public borrowbook()
        {
            InitializeComponent();
        }

        private void LoadBookTitles()
        {
            string query = "SELECT Book_Title FROM Books WHERE Quantity > 0";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookComboBox.Items.Add(reader["Book_Title"].ToString());
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("مشکل در اتصال به دیتابیس: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در خواندن اطلاعات کتاب‌ها: " + ex.Message);
                }
            }
        }

        private void borrowbook_Load(object sender, EventArgs e)
        {
            LoadBookTitles();
        }

        

        private void issueBooksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            string bookTitle = bookComboBox.Text;
            string memberId = memberIdTextBox.Text;
            string empId = empIdTextBox.Text;

            if (string.IsNullOrWhiteSpace(bookTitle) || string.IsNullOrWhiteSpace(memberId) || string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("لطفاً تمام اطلاعات را وارد کنید.");
                return;
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                // بررسی تعداد کتاب
                string checkQuantityQuery = "SELECT Quantity FROM Books WHERE Book_Title = @bookTitle";
                SqlCommand checkQuantityCommand = new SqlCommand(checkQuantityQuery, connection);
                checkQuantityCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                int quantity = (int)checkQuantityCommand.ExecuteScalar();

                if (quantity <= 0)
                {
                    MessageBox.Show("کتاب موجود نیست.");
                    return;
                }

                DateTime returnDate = DateTime.Now.AddDays(10);

                // به‌روزرسانی جدول امانت‌ها
                string issueQuery = @"INSERT INTO Issue_Books (Book_Title, Member_Id, emp_Id, Issue_Date, Return_Date, Status) 
                              VALUES (@bookTitle, @memberId, @empId, GETDATE(), @returnDate, 'Borrowed')";
                SqlCommand issueCommand = new SqlCommand(issueQuery, connection);
                issueCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                issueCommand.Parameters.AddWithValue("@memberId", memberId);
                issueCommand.Parameters.AddWithValue("@empId", empId);
                //issueCommand.ExecuteNonQuery();

                // کاهش تعداد کتاب در جدول Books
                string updateBookQuery = "UPDATE Books SET Quantity = Quantity - 1 WHERE Book_Title = @bookTitle";
                SqlCommand updateBookCommand = new SqlCommand(updateBookQuery, connection);
                updateBookCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                updateBookCommand.ExecuteNonQuery();

                MessageBox.Show($"کتاب '{bookTitle}' با موفقیت امانت داده شد.\nتاریخ بازگشت: {returnDate:yyyy/MM/dd}");
                LoadIssueBooks(); // به‌روزرسانی GridView
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string bookTitle = bookComboBox.Text;

            if (string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("لطفاً عنوان کتاب را انتخاب کنید.");
                return;
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                // به‌روزرسانی جدول امانت‌ها
                string returnQuery = @"UPDATE Issue_Books SET Status = 'Returned', Return_Date = GETDATE() 
                               WHERE Book_Title = @bookTitle AND Status = 'Issued'";
                SqlCommand returnCommand = new SqlCommand(returnQuery, connection);
                returnCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                int rowsAffected = returnCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // افزایش تعداد کتاب در جدول Books
                    string updateBookQuery = "UPDATE Books SET Quantity = Quantity + 1 WHERE Book_Title = @bookTitle";
                    SqlCommand updateBookCommand = new SqlCommand(updateBookQuery, connection);
                    updateBookCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                    updateBookCommand.ExecuteNonQuery();

                    MessageBox.Show("کتاب با موفقیت بازگردانده شد.");
                    LoadIssueBooks(); // به‌روزرسانی GridView
                }
                else
                {
                    MessageBox.Show("کتاب در حال حاضر امانت داده نشده است.");
                }
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            bookComboBox.SelectedIndex = -1;
            memberIdTextBox.Clear();
            empIdTextBox.Clear();
        }

        private void LoadIssueBooks()
        {
            string query = @"SELECT I.Book_Id, B.Book_Title, B.Author, I.Return_Date 
                     FROM Issue_Books I
                     INNER JOIN Books B ON I.Book_Id = B.Book_Id
                     WHERE I.Status = 'Issued'";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                issueBooksGridView.DataSource = table;
            }
        }

        private void ViewUserBorrowedBooks(string memberId, string empId)
        {
            string query = "SELECT ib.Book_Id, ib.Book_Title, b.Author, ib.Return_Date FROM Issue_Books ib INNER JOIN Books b ON ib.Book_Title = b.Book_Title WHERE ib.Member_Id = @memberId AND ib.Emp_Id = @empId AND ib.Status = 'Issued'";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@memberId", memberId);
                adapter.SelectCommand.Parameters.AddWithValue("@empId", empId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                issueBooksGridView.DataSource = table;
            }
        }


        private void viewButton_Click(object sender, EventArgs e)
        {
            string memberId = memberIdTextBox.Text;
            string empId = empIdTextBox.Text;
            if (string.IsNullOrWhiteSpace(memberId) || string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("لطفاً شناسه کاربر و کارمند را وارد کنید.");
                return;
            }
            ViewUserBorrowedBooks(memberId, empId);
        }

        private void borrowbook_Load_1(object sender, EventArgs e)
        {

        }
    }
}
