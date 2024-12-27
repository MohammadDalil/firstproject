
namespace firstproject
{
    partial class AddBookInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookID = new System.Windows.Forms.TextBox();
            this.titlebook = new System.Windows.Forms.TextBox();
            this.authorbook = new System.Windows.Forms.TextBox();
            this.publisherbook = new System.Windows.Forms.TextBox();
            this.quantitybook = new System.Windows.Forms.TextBox();
            this.categorybook = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جزییات کتاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "شناسه کتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "عنوان کتاب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "نویسنده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ناشر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(683, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "دسته";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(683, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "تعداد";
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(539, 61);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(100, 20);
            this.bookID.TabIndex = 7;
            // 
            // titlebook
            // 
            this.titlebook.Location = new System.Drawing.Point(341, 102);
            this.titlebook.Name = "titlebook";
            this.titlebook.Size = new System.Drawing.Size(298, 20);
            this.titlebook.TabIndex = 8;
            // 
            // authorbook
            // 
            this.authorbook.Location = new System.Drawing.Point(341, 151);
            this.authorbook.Name = "authorbook";
            this.authorbook.Size = new System.Drawing.Size(298, 20);
            this.authorbook.TabIndex = 9;
            // 
            // publisherbook
            // 
            this.publisherbook.Location = new System.Drawing.Point(341, 193);
            this.publisherbook.Name = "publisherbook";
            this.publisherbook.Size = new System.Drawing.Size(298, 20);
            this.publisherbook.TabIndex = 10;
            // 
            // quantitybook
            // 
            this.quantitybook.Location = new System.Drawing.Point(539, 283);
            this.quantitybook.Name = "quantitybook";
            this.quantitybook.Size = new System.Drawing.Size(100, 20);
            this.quantitybook.TabIndex = 11;
            // 
            // categorybook
            // 
            this.categorybook.FormattingEnabled = true;
            this.categorybook.Location = new System.Drawing.Point(517, 238);
            this.categorybook.Name = "categorybook";
            this.categorybook.Size = new System.Drawing.Size(121, 21);
            this.categorybook.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(563, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(451, 346);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.categorybook);
            this.Controls.Add(this.quantitybook);
            this.Controls.Add(this.publisherbook);
            this.Controls.Add(this.authorbook);
            this.Controls.Add(this.titlebook);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookInfo";
            this.Text = "AddBookInfo";
            this.Load += new System.EventHandler(this.AddBookInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.TextBox titlebook;
        private System.Windows.Forms.TextBox authorbook;
        private System.Windows.Forms.TextBox publisherbook;
        private System.Windows.Forms.TextBox quantitybook;
        private System.Windows.Forms.ComboBox categorybook;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}