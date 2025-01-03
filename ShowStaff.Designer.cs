
namespace firstproject
{
    partial class ShowStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.emp_id = new System.Windows.Forms.Label();
            this.emp_idBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشخصات کارمند";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(460, 121);
            this.NameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(20, 13);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "نام";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(421, 161);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(69, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "نام خانوادگی";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(442, 205);
            this.Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(42, 13);
            this.Position.TabIndex = 3;
            this.Position.Text = "موقعیت";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(436, 243);
            this.dob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(53, 13);
            this.dob.TabIndex = 4;
            this.dob.Text = "تاریخ تولد";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(448, 284);
            this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(30, 13);
            this.Address.TabIndex = 5;
            this.Address.Text = "آدرس";
            this.Address.Click += new System.EventHandler(this.label6_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(430, 359);
            this.Number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(58, 13);
            this.Number.TabIndex = 6;
            this.Number.Text = "شماره تلفن";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(428, 401);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "آدرس ایمیل";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(139, 116);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(240, 20);
            this.NameBox.TabIndex = 8;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(139, 156);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(240, 20);
            this.LastNameBox.TabIndex = 9;
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(139, 200);
            this.PositionBox.Margin = new System.Windows.Forms.Padding(2);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(240, 20);
            this.PositionBox.TabIndex = 10;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(139, 282);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(240, 52);
            this.AddressBox.TabIndex = 11;
            this.AddressBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(139, 357);
            this.NumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(240, 20);
            this.NumberBox.TabIndex = 12;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(139, 238);
            this.dobBox.Margin = new System.Windows.Forms.Padding(2);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(240, 20);
            this.dobBox.TabIndex = 13;
            this.dobBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(139, 396);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(240, 20);
            this.EmailBox.TabIndex = 14;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(435, 464);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(70, 37);
            this.Save.TabIndex = 15;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(343, 464);
            this.New.Margin = new System.Windows.Forms.Padding(2);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(70, 37);
            this.New.TabIndex = 16;
            this.New.Text = "جدید";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(251, 464);
            this.Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(72, 37);
            this.Edit.TabIndex = 17;
            this.Edit.Text = "ویرایش";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(62, 464);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(68, 37);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "حذف";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(156, 464);
            this.View.Margin = new System.Windows.Forms.Padding(2);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(68, 37);
            this.View.TabIndex = 19;
            this.View.Text = "مشاهده";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.button5_Click);
            // 
            // emp_id
            // 
            this.emp_id.AutoSize = true;
            this.emp_id.Location = new System.Drawing.Point(411, 83);
            this.emp_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(81, 13);
            this.emp_id.TabIndex = 20;
            this.emp_id.Text = "شناسه کارمندی";
            // 
            // emp_idBox
            // 
            this.emp_idBox.Location = new System.Drawing.Point(139, 78);
            this.emp_idBox.Margin = new System.Windows.Forms.Padding(2);
            this.emp_idBox.Name = "emp_idBox";
            this.emp_idBox.Size = new System.Drawing.Size(240, 20);
            this.emp_idBox.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(572, 335);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.emp_idBox);
            this.Controls.Add(this.emp_id);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowStaff";
            this.Text = "ShowStaff";
            this.Load += new System.EventHandler(this.ShowStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PositionBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.DateTimePicker dobBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label emp_id;
        private System.Windows.Forms.TextBox emp_idBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}