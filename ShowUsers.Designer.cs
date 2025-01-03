
using System;

namespace firstproject
{
    partial class ShowUsers
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
            this.UserName = new System.Windows.Forms.Label();
            this.UserRole = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.RePassword = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserRoleBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.RePasswordBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشخصات کاربران";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(390, 93);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 13);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "نام کاربری";
            this.UserName.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserRole
            // 
            this.UserRole.AutoSize = true;
            this.UserRole.Location = new System.Drawing.Point(415, 141);
            this.UserRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserRole.Name = "UserRole";
            this.UserRole.Size = new System.Drawing.Size(25, 13);
            this.UserRole.TabIndex = 2;
            this.UserRole.Text = "نقش";
            this.UserRole.Click += new System.EventHandler(this.label3_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(402, 184);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(44, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "گذرواژه";
            // 
            // RePassword
            // 
            this.RePassword.AutoSize = true;
            this.RePassword.Location = new System.Drawing.Point(380, 233);
            this.RePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(71, 13);
            this.RePassword.TabIndex = 4;
            this.RePassword.Text = "تکرار گذرواژه";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(140, 88);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(204, 20);
            this.UserNameBox.TabIndex = 5;
            this.UserNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UserRoleBox
            // 
            this.UserRoleBox.Location = new System.Drawing.Point(140, 136);
            this.UserRoleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserRoleBox.Name = "UserRoleBox";
            this.UserRoleBox.Size = new System.Drawing.Size(204, 20);
            this.UserRoleBox.TabIndex = 6;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(140, 179);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(204, 20);
            this.PasswordBox.TabIndex = 7;
            // 
            // RePasswordBox
            // 
            this.RePasswordBox.Location = new System.Drawing.Point(140, 228);
            this.RePasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RePasswordBox.Name = "RePasswordBox";
            this.RePasswordBox.Size = new System.Drawing.Size(204, 20);
            this.RePasswordBox.TabIndex = 8;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(482, 297);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(72, 39);
            this.Save.TabIndex = 9;
            this.Save.Text = "ثبت";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(374, 297);
            this.New.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(70, 39);
            this.New.TabIndex = 10;
            this.New.Text = "جدید";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(266, 297);
            this.Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(70, 39);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "ویرایش";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(50, 297);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(70, 39);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "حذف";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(155, 297);
            this.View.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(77, 39);
            this.View.TabIndex = 14;
            this.View.Text = "مشاهده";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(599, 263);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RePasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserRoleBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserRole);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowUsers";
            this.Text = "ShowUsers";
            this.Load += new System.EventHandler(this.ShowUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void See_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserRole;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label RePassword;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox UserRoleBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox RePasswordBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}