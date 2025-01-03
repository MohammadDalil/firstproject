
namespace firstproject
{
    partial class borrowbook
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
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.issueBooksGridView = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.issueBooksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب کتاب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "شناسه کارمند ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "شناسه عضویت";
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(471, 33);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(121, 21);
            this.bookComboBox.TabIndex = 3;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.Location = new System.Drawing.Point(471, 77);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.empIdTextBox.TabIndex = 4;
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.Location = new System.Drawing.Point(471, 123);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.memberIdTextBox.TabIndex = 5;
            // 
            // issueBooksGridView
            // 
            this.issueBooksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueBooksGridView.Location = new System.Drawing.Point(-1, 222);
            this.issueBooksGridView.Name = "issueBooksGridView";
            this.issueBooksGridView.Size = new System.Drawing.Size(801, 226);
            this.issueBooksGridView.TabIndex = 6;
            this.issueBooksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueBooksGridView_CellContentClick);
            this.issueBooksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.issueBooksGridView_CellContentClick);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(517, 167);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 7;
            this.newButton.Text = "جدید";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(357, 167);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(104, 23);
            this.borrowButton.TabIndex = 8;
            this.borrowButton.Text = "به امانت بردن";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(184, 167);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(131, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "برگرداندن کتاب";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(73, 167);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "مشاهده";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // borrowbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.issueBooksGridView);
            this.Controls.Add(this.memberIdTextBox);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(this.bookComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "borrowbook";
            this.Text = "borrowbook";
            this.Load += new System.EventHandler(this.borrowbook_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.issueBooksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.DataGridView issueBooksGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button viewButton;
    }
}