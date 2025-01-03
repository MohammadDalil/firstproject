using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstproject
{
    public partial class ShowStaff : Form
    {
        public ShowStaff()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT emp_id, emp_name, emp_surname, position, emp_dobirth, address, contact_no, email FROM Employee";

            using (SqlConnection connection = DBConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable; // نمایش داده‌ها در DataGridView
                        dataGridView1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("هیچ داده‌ای یافت نشد.", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطایی رخ داد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(emp_idBox.Text))
            {
                MessageBox.Show("لطفاً از وارد کردن اطلاعات در باکس شناسه کارمندی خودداری کنید. این مقدار به‌صورت خودکار تعیین می‌شود.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameBox.Text) ||
                string.IsNullOrWhiteSpace(PositionBox.Text) ||
                string.IsNullOrWhiteSpace(AddressBox.Text) ||
                string.IsNullOrWhiteSpace(NumberBox.Text) ||
                string.IsNullOrWhiteSpace(EmailBox.Text))
            {
                MessageBox.Show("لطفاً تمامی فیلدها را پر کنید.");
                return;
            }

            // ذخیره اطلاعات در دیتابیس
            string query = "INSERT INTO Employee (emp_name, emp_surname, position, emp_dobirth, address, contact_no, email) " +
                           "VALUES (@Name, @Surname, @Position, @DOB, @Address, @Contact, @Email)";

            using (SqlConnection connection = DBConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", NameBox.Text);
                command.Parameters.AddWithValue("@Surname", LastNameBox.Text);
                command.Parameters.AddWithValue("@Position", PositionBox.Text);
                command.Parameters.AddWithValue("@DOB", dobBox.Value);
                command.Parameters.AddWithValue("@Address", AddressBox.Text);
                command.Parameters.AddWithValue("@Contact", NumberBox.Text);
                command.Parameters.AddWithValue("@Email", EmailBox.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("اطلاعات کارمند ذخیره شد.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emp_idBox.Text))
            {
                MessageBox.Show("لطفاً یک کارمند را انتخاب کنید.");
                return;
            }

            // حذف اطلاعات از دیتابیس
            string query = "DELETE FROM Employee WHERE emp_id = @ID";

            using (SqlConnection connection = DBConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", emp_idBox.Text);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("کارمند حذف شد.");
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            emp_idBox.Clear();
            NameBox.Clear();
            LastNameBox.Clear();
            PositionBox.Clear();
            AddressBox.Clear();
            NumberBox.Clear();
            EmailBox.Clear();
            dobBox.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // اطمینان از اینکه ردیف معتبر انتخاب شده است
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // پر کردن تکست‌باکس‌ها با داده‌های انتخابی
                emp_idBox.Text = row.Cells["emp_id"].Value.ToString(); // فقط نمایش؛ غیرقابل ویرایش
                NameBox.Text = row.Cells["emp_name"].Value.ToString();
                LastNameBox.Text = row.Cells["emp_surname"].Value.ToString();
                PositionBox.Text = row.Cells["position"].Value.ToString();
                dobBox.Value = Convert.ToDateTime(row.Cells["emp_dobirth"].Value);
                AddressBox.Text = row.Cells["address"].Value.ToString();
                NumberBox.Text = row.Cells["contact_no"].Value.ToString();
                EmailBox.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emp_idBox.Text))
            {
                MessageBox.Show("لطفاً ابتدا یک کارمند را از لیست انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Employee SET emp_name = @Name, emp_surname = @Surname, position = @Position, emp_dobirth = @DOB, address = @Address, contact_no = @Contact, email = @Email WHERE emp_id = @Id";

            using (SqlConnection connection = DBConnection.GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                dataGridView1.Visible = false;
                command.Parameters.AddWithValue("@Id", emp_idBox.Text);
                command.Parameters.AddWithValue("@Name", NameBox.Text);
                command.Parameters.AddWithValue("@Surname", LastNameBox.Text);
                command.Parameters.AddWithValue("@Position", PositionBox.Text);
                command.Parameters.AddWithValue("@DOB", dobBox.Value);
                command.Parameters.AddWithValue("@Address", AddressBox.Text);
                command.Parameters.AddWithValue("@Contact", NumberBox.Text);
                command.Parameters.AddWithValue("@Email", EmailBox.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("اطلاعات با موفقیت به‌روزرسانی شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("به‌روزرسانی اطلاعات با مشکل مواجه شد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطایی رخ داد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
