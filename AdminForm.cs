using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace firstproject
{
    public partial class AdminForm : Form
    {
        public AdminForm(string role)
        {
            InitializeComponent();
            CreateMenu();
            userStatusLabel.Text = $"ورود با: {role}";
            Timer timer = new Timer();
            timer.Interval = 1000000;  // updating
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // دریافت تاریخ و ساعت محلی به شمسی
            PersianCalendar pc = new PersianCalendar();
            DateTime now = DateTime.Now;
            string date = $"{pc.GetYear(now)}/{pc.GetMonth(now):00}/{pc.GetDayOfMonth(now):00}";
            string time = now.ToString("HH:mm:ss");

            dateTimeStatusLabel.Text = $"تاریخ: {date}  |  ساعت: {time}";
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید خارج شوید؟",
                                         "خروج از سیستم",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // نمایش مجدد فرم ورود
                loginform loginForm = new loginform();
                loginForm.Show();

                // بستن فرم جاری (AdminForm)
                this.Close();
            }
        }

        // باز کردن فرم اطلاعات کتاب‌ها
        private void AddBookInfo(object sender, EventArgs e)
        {
            AddBookInfo addBookForm = new AddBookInfo();
            addBookForm.Show();
        }

        // باز کردن فرم اطلاعات اعضا
        private void AddMemberInfo(object sender, EventArgs e)
        {
            AddMemberInfo addMemberForm = new AddMemberInfo();
            addMemberForm.Show();
        }

        // باز کردن فرم افزودن دسته‌بندی
        private void AddCategory(object sender, EventArgs e)
        {
            AddCategory addCategoryForm = new AddCategory();
            addCategoryForm.Show();
        }


        private void CreateMenu()
        {
            // ایجاد منوی اصلی
            MenuStrip menuStrip = new MenuStrip();

            // ایجاد آیتم‌های منوی اصلی
            ToolStripMenuItem infoMenu = new ToolStripMenuItem("ورود اطلاعات");
            ToolStripMenuItem loanMenu = new ToolStripMenuItem("امانت دادن کتاب");
            ToolStripMenuItem staffMenu = new ToolStripMenuItem("کارکنان");
            ToolStripMenuItem aboutMenu = new ToolStripMenuItem("درباره ما");
            ToolStripMenuItem logoutMenu = new ToolStripMenuItem("خروج");

            //// اضافه کردن زیرمنو به ورود اطلاعات
            infoMenu.DropDownItems.Add("اطلاعات کتاب‌ها", null, AddBookInfo);
            infoMenu.DropDownItems.Add("اطلاعات اعضا", null, AddMemberInfo);
            infoMenu.DropDownItems.Add("اضافه کردن فهرست عنوان(Category)", null, AddCategory);

            //// اضافه کردن زیرمنو به کارکنان
            //staffMenu.DropDownItems.Add("کارکنان", null, ShowStaff);
            //staffMenu.DropDownItems.Add("کاربران", null, ShowUsers);

            //// اضافه کردن رویداد کلیک برای خروج
            logoutMenu.Click += logoutMenu_Click;

            menuStrip.RightToLeft = RightToLeft.Yes;
            //menuStrip.RightToLeftLayout = true;

            // اضافه کردن آیتم‌ها به منو
            menuStrip.Items.Add(infoMenu);
            menuStrip.Items.Add(loanMenu);
            menuStrip.Items.Add(staffMenu);
            menuStrip.Items.Add(aboutMenu);
            menuStrip.Items.Add(logoutMenu);

            // اضافه کردن MenuStrip به فرم
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
