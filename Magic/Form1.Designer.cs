namespace StudentCard
{
    partial class StudentCard
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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.saveStudentCardButton = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.showStudentListbutton = new System.Windows.Forms.Button();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.middlenameLabel = new System.Windows.Forms.Label();
            this.middlenameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefonNumberLabel = new System.Windows.Forms.Label();
            this.specialityComboBox = new System.Windows.Forms.ComboBox();
            this.courceComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.specialityLabel = new System.Windows.Forms.Label();
            this.courceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(15, 22);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(169, 20);
            this.surnameTextBox.TabIndex = 0;
            // 
            // saveStudentCardButton
            // 
            this.saveStudentCardButton.Location = new System.Drawing.Point(15, 350);
            this.saveStudentCardButton.Name = "saveStudentCardButton";
            this.saveStudentCardButton.Size = new System.Drawing.Size(341, 28);
            this.saveStudentCardButton.TabIndex = 1;
            this.saveStudentCardButton.Text = "Сохранить данные";
            this.saveStudentCardButton.UseVisualStyleBackColor = true;
            this.saveStudentCardButton.Click += new System.EventHandler(this.saveStudentCardButton_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 6);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Фамилия";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(15, 71);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(169, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            // 
            // showStudentListbutton
            // 
            this.showStudentListbutton.Location = new System.Drawing.Point(15, 394);
            this.showStudentListbutton.Name = "showStudentListbutton";
            this.showStudentListbutton.Size = new System.Drawing.Size(341, 29);
            this.showStudentListbutton.TabIndex = 6;
            this.showStudentListbutton.Text = "Список студентов";
            this.showStudentListbutton.UseVisualStyleBackColor = true;
            this.showStudentListbutton.Click += new System.EventHandler(this.showStudentListbutton_Click);
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(193, 22);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(121, 21);
            this.facultyComboBox.TabIndex = 7;
            this.facultyComboBox.SelectedIndexChanged += new System.EventHandler(this.facultyComboBox_SelectedIndexChanged);
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Location = new System.Drawing.Point(190, 9);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(63, 13);
            this.facultyLabel.TabIndex = 8;
            this.facultyLabel.Text = "Факультет";
            // 
            // middlenameLabel
            // 
            this.middlenameLabel.AutoSize = true;
            this.middlenameLabel.Location = new System.Drawing.Point(12, 104);
            this.middlenameLabel.Name = "middlenameLabel";
            this.middlenameLabel.Size = new System.Drawing.Size(54, 13);
            this.middlenameLabel.TabIndex = 9;
            this.middlenameLabel.Text = "Отчество";
            // 
            // middlenameTextBox
            // 
            this.middlenameTextBox.Location = new System.Drawing.Point(15, 120);
            this.middlenameTextBox.Name = "middlenameTextBox";
            this.middlenameTextBox.Size = new System.Drawing.Size(169, 20);
            this.middlenameTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(15, 170);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(169, 20);
            this.cityTextBox.TabIndex = 11;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(15, 218);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(169, 20);
            this.streetTextBox.TabIndex = 12;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 154);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 13);
            this.cityLabel.TabIndex = 13;
            this.cityLabel.Text = "Город";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(12, 202);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(38, 13);
            this.adressLabel.TabIndex = 14;
            this.adressLabel.Text = "Адрес";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(15, 314);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(169, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(15, 266);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(169, 20);
            this.telefonTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(14, 298);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(139, 13);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Адрес электронной почты";
            // 
            // telefonNumberLabel
            // 
            this.telefonNumberLabel.AutoSize = true;
            this.telefonNumberLabel.Location = new System.Drawing.Point(12, 250);
            this.telefonNumberLabel.Name = "telefonNumberLabel";
            this.telefonNumberLabel.Size = new System.Drawing.Size(155, 13);
            this.telefonNumberLabel.TabIndex = 18;
            this.telefonNumberLabel.Text = "Контактный номер телефона";
            // 
            // specialityComboBox
            // 
            this.specialityComboBox.FormattingEnabled = true;
            this.specialityComboBox.Location = new System.Drawing.Point(193, 70);
            this.specialityComboBox.Name = "specialityComboBox";
            this.specialityComboBox.Size = new System.Drawing.Size(121, 21);
            this.specialityComboBox.TabIndex = 19;
            this.specialityComboBox.SelectedIndexChanged += new System.EventHandler(this.specialityComboBox_SelectedIndexChanged);
            // 
            // courceComboBox
            // 
            this.courceComboBox.FormattingEnabled = true;
            this.courceComboBox.Location = new System.Drawing.Point(193, 119);
            this.courceComboBox.Name = "courceComboBox";
            this.courceComboBox.Size = new System.Drawing.Size(121, 21);
            this.courceComboBox.TabIndex = 20;
            this.courceComboBox.SelectedIndexChanged += new System.EventHandler(this.courceComboBox_SelectedIndexChanged);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(193, 169);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupComboBox.TabIndex = 21;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(190, 153);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(42, 13);
            this.groupLabel.TabIndex = 22;
            this.groupLabel.Text = "Группа";
            // 
            // specialityLabel
            // 
            this.specialityLabel.AutoSize = true;
            this.specialityLabel.Location = new System.Drawing.Point(190, 55);
            this.specialityLabel.Name = "specialityLabel";
            this.specialityLabel.Size = new System.Drawing.Size(85, 13);
            this.specialityLabel.TabIndex = 23;
            this.specialityLabel.Text = "Специальность";
            // 
            // courceLabel
            // 
            this.courceLabel.AutoSize = true;
            this.courceLabel.Location = new System.Drawing.Point(190, 104);
            this.courceLabel.Name = "courceLabel";
            this.courceLabel.Size = new System.Drawing.Size(31, 13);
            this.courceLabel.TabIndex = 24;
            this.courceLabel.Text = "Курс";
            // 
            // StudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 435);
            this.Controls.Add(this.courceLabel);
            this.Controls.Add(this.specialityLabel);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.courceComboBox);
            this.Controls.Add(this.specialityComboBox);
            this.Controls.Add(this.telefonNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.middlenameTextBox);
            this.Controls.Add(this.middlenameLabel);
            this.Controls.Add(this.facultyLabel);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.showStudentListbutton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.saveStudentCardButton);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "StudentCard";
            this.Text = "Карточка студента";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button saveStudentCardButton;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button showStudentListbutton;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label middlenameLabel;
        private System.Windows.Forms.TextBox middlenameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telefonNumberLabel;
        private System.Windows.Forms.ComboBox specialityComboBox;
        private System.Windows.Forms.ComboBox courceComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label specialityLabel;
        private System.Windows.Forms.Label courceLabel;
    }
}

