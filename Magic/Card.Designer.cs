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
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SaveStudentCardButton = new System.Windows.Forms.Button();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.MiddlenameLabel = new System.Windows.Forms.Label();
            this.MiddlenameTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TelefonTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelefonNumberLabel = new System.Windows.Forms.Label();
            this.SpecialityComboBox = new System.Windows.Forms.ComboBox();
            this.CourceComboBox = new System.Windows.Forms.ComboBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.CourceLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.FotoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(241, 6);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(244, 26);
            this.SurnameTextBox.TabIndex = 0;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // SaveStudentCardButton
            // 
            this.SaveStudentCardButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveStudentCardButton.FlatAppearance.BorderSize = 0;
            this.SaveStudentCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveStudentCardButton.Location = new System.Drawing.Point(285, 337);
            this.SaveStudentCardButton.Name = "SaveStudentCardButton";
            this.SaveStudentCardButton.Size = new System.Drawing.Size(176, 28);
            this.SaveStudentCardButton.TabIndex = 1;
            this.SaveStudentCardButton.Text = "Сохранить";
            this.SaveStudentCardButton.UseVisualStyleBackColor = false;
            this.SaveStudentCardButton.Click += new System.EventHandler(this.SaveStudentCardButton_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(156, 9);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(81, 20);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(241, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(244, 26);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(156, 41);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Имя";
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(138, 232);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(250, 28);
            this.FacultyComboBox.TabIndex = 7;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultyLabel.Location = new System.Drawing.Point(38, 235);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(94, 20);
            this.FacultyLabel.TabIndex = 8;
            this.FacultyLabel.Text = "Факультет";
            // 
            // MiddlenameLabel
            // 
            this.MiddlenameLabel.AutoSize = true;
            this.MiddlenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddlenameLabel.Location = new System.Drawing.Point(156, 75);
            this.MiddlenameLabel.Name = "MiddlenameLabel";
            this.MiddlenameLabel.Size = new System.Drawing.Size(83, 20);
            this.MiddlenameLabel.TabIndex = 9;
            this.MiddlenameLabel.Text = "Отчество";
            // 
            // MiddlenameTextBox
            // 
            this.MiddlenameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddlenameTextBox.Location = new System.Drawing.Point(241, 72);
            this.MiddlenameTextBox.Name = "MiddlenameTextBox";
            this.MiddlenameTextBox.Size = new System.Drawing.Size(244, 26);
            this.MiddlenameTextBox.TabIndex = 10;
            this.MiddlenameTextBox.TextChanged += new System.EventHandler(this.MiddlenameTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityTextBox.Location = new System.Drawing.Point(241, 104);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(244, 26);
            this.CityTextBox.TabIndex = 11;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTextBox.Location = new System.Drawing.Point(241, 136);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(244, 26);
            this.AddressTextBox.TabIndex = 12;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityLabel.Location = new System.Drawing.Point(156, 107);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(56, 20);
            this.CityLabel.TabIndex = 13;
            this.CityLabel.Text = "Город";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(156, 139);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(57, 20);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Адрес";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(241, 200);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(244, 26);
            this.EmailTextBox.TabIndex = 15;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // TelefonTextBox
            // 
            this.TelefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelefonTextBox.Location = new System.Drawing.Point(241, 168);
            this.TelefonTextBox.Name = "TelefonTextBox";
            this.TelefonTextBox.Size = new System.Drawing.Size(244, 26);
            this.TelefonTextBox.TabIndex = 16;
            this.TelefonTextBox.TextChanged += new System.EventHandler(this.TelefonTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(4, 203);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(211, 20);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Адрес электронной почты";
            // 
            // TelefonNumberLabel
            // 
            this.TelefonNumberLabel.AutoSize = true;
            this.TelefonNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelefonNumberLabel.Location = new System.Drawing.Point(4, 171);
            this.TelefonNumberLabel.Name = "TelefonNumberLabel";
            this.TelefonNumberLabel.Size = new System.Drawing.Size(235, 20);
            this.TelefonNumberLabel.TabIndex = 18;
            this.TelefonNumberLabel.Text = "Контактный номер телефона";
            // 
            // SpecialityComboBox
            // 
            this.SpecialityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialityComboBox.FormattingEnabled = true;
            this.SpecialityComboBox.Location = new System.Drawing.Point(138, 266);
            this.SpecialityComboBox.Name = "SpecialityComboBox";
            this.SpecialityComboBox.Size = new System.Drawing.Size(250, 28);
            this.SpecialityComboBox.TabIndex = 19;
            this.SpecialityComboBox.SelectedIndexChanged += new System.EventHandler(this.SpecialityComboBox_SelectedIndexChanged);
            // 
            // CourceComboBox
            // 
            this.CourceComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourceComboBox.FormattingEnabled = true;
            this.CourceComboBox.Location = new System.Drawing.Point(138, 300);
            this.CourceComboBox.Name = "CourceComboBox";
            this.CourceComboBox.Size = new System.Drawing.Size(121, 28);
            this.CourceComboBox.TabIndex = 20;
            this.CourceComboBox.SelectedIndexChanged += new System.EventHandler(this.CourceComboBox_SelectedIndexChanged);
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(138, 334);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 28);
            this.GroupComboBox.TabIndex = 21;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(71, 337);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(61, 20);
            this.GroupLabel.TabIndex = 22;
            this.GroupLabel.Text = "Группа";
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialityLabel.Location = new System.Drawing.Point(4, 269);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(128, 20);
            this.SpecialityLabel.TabIndex = 23;
            this.SpecialityLabel.Text = "Специальность";
            // 
            // CourceLabel
            // 
            this.CourceLabel.AutoSize = true;
            this.CourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourceLabel.Location = new System.Drawing.Point(89, 303);
            this.CourceLabel.Name = "CourceLabel";
            this.CourceLabel.Size = new System.Drawing.Size(43, 20);
            this.CourceLabel.TabIndex = 24;
            this.CourceLabel.Text = "Курс";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Location = new System.Drawing.Point(14, 9);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(136, 156);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoPictureBox.TabIndex = 27;
            this.PhotoPictureBox.TabStop = false;
            this.PhotoPictureBox.RegionChanged += new System.EventHandler(this.PhotoPictureBox_RegionChanged);
            this.PhotoPictureBox.Click += new System.EventHandler(this.FotoPictureBox_Click);
            // 
            // FotoOpenFileDialog
            // 
            this.FotoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(265, 314);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(232, 20);
            this.ErrorLabel.TabIndex = 28;
            this.ErrorLabel.Text = "Заполните отмеченные поля";
            this.ErrorLabel.Visible = false;
            // 
            // StudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 370);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.Controls.Add(this.CourceLabel);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.CourceComboBox);
            this.Controls.Add(this.SpecialityComboBox);
            this.Controls.Add(this.TelefonNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelefonTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.MiddlenameTextBox);
            this.Controls.Add(this.MiddlenameLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.SaveStudentCardButton);
            this.Controls.Add(this.SurnameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentCard";
            this.Text = "Карточка студента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentCard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button SaveStudentCardButton;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label MiddlenameLabel;
        private System.Windows.Forms.TextBox MiddlenameTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TelefonTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelefonNumberLabel;
        private System.Windows.Forms.ComboBox SpecialityComboBox;
        private System.Windows.Forms.ComboBox CourceComboBox;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.Label CourceLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.OpenFileDialog FotoOpenFileDialog;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

