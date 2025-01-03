
namespace firstproject
{
    partial class AddMemberInfo
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
            this.Save = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.dobBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "اضافه کردن عضو";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(331, 389);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(131, 49);
            this.Save.TabIndex = 11;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(230, 78);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(239, 22);
            this.NameBox.TabIndex = 1;
            // 
            // Name
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(582, 84);
            this.nameLabel.Name = "Name";
            this.nameLabel.Size = new System.Drawing.Size(21, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "نام";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(530, 142);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(73, 16);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "نام خانوادگی";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(566, 201);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(37, 16);
            this.Address.TabIndex = 4;
            this.Address.Text = "آدرس";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(532, 265);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(71, 16);
            this.Number.TabIndex = 5;
            this.Number.Text = "شماره تماس";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(547, 324);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(56, 16);
            this.dob.TabIndex = 6;
            this.dob.Text = "تاریخ تولد";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(230, 136);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(239, 22);
            this.LastNameBox.TabIndex = 7;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(230, 195);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(239, 22);
            this.AddressBox.TabIndex = 8;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(230, 259);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(239, 22);
            this.NumberBox.TabIndex = 9;
            // 
            // dobBox
            // 
            this.dobBox.Location = new System.Drawing.Point(230, 319);
            this.dobBox.Name = "dobBox";
            this.dobBox.Size = new System.Drawing.Size(239, 22);
            this.dobBox.TabIndex = 12;
            // 
            // AddMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dobBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddMemberInfo";
            this.Text = "AddMemberInfo";
            this.Load += new System.EventHandler(this.AddMemberInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.DateTimePicker dobBox;
    }
}