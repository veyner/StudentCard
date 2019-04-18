using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace StudentCard
{
    public partial class StudentCard : Form
    {
        public StudentCard()
        {
            InitializeComponent();
            new ComboBoxManager().LoadInfoToFacultyCombobox(facultyComboBox);
        }

        public void ChangeTextBoxes(Student student)
        {
            surnameTextBox.Text = student.Surname;
            nameTextBox.Text = student.Name;
            middlenameTextBox.Text = student.Name;
            cityTextBox.Text = student.City;
            streetTextBox.Text = student.Street;
            telefonTextBox.Text = student.TelefonNumber.ToString();
            emailTextBox.Text = student.Email;

            facultyComboBox.ValueMember = nameof(Faculty.ID);
            facultyComboBox.SelectedValue = student.FacultyID;

            specialityComboBox.ValueMember = nameof(Speciality.ID);
            specialityComboBox.SelectedValue = student.SpecialityID;

            courceComboBox.ValueMember = nameof(Cource.ID);
            courceComboBox.SelectedValue = student.CourceID;

            groupComboBox.ValueMember = nameof(Group.ID);
            groupComboBox.SelectedValue = student.GroupID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void facultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToSpecialityComboBox(specialityComboBox, facultyComboBox);
        }

        private void specialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToCourceComboBox(courceComboBox, specialityComboBox);
        }

        private void courceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new ComboBoxManager().LoadInfoToGroupComboBox(groupComboBox, courceComboBox);
        }

        private void saveStudentCardButton_Click(object sender, EventArgs e)
        {
            var student = new Student();
            var currentFaculty = (Faculty)facultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)specialityComboBox.SelectedItem;
            var currentCource = (Cource)courceComboBox.SelectedItem;
            var currentGroup = (Group)groupComboBox.SelectedItem;

            student.Surname = surnameTextBox.Text;
            student.Name = nameTextBox.Text;
            student.MiddleName = middlenameTextBox.Text;
            student.City = cityTextBox.Text;
            student.Street = streetTextBox.Text;
            student.TelefonNumber = long.Parse(telefonTextBox.Text);
            student.Email = emailTextBox.Text;
            student.FacultyID = currentFaculty.ID;
            student.SpecialityID = currentSpeciality.ID;
            student.CourceID = currentCource.ID;
            student.GroupID = currentGroup.ID;
            new SaveNLoadManager().SaveData(student);
            MessageBox.Show($"Данные {student.Surname} сохранены");
        }

        private void showStudentListbutton_Click(object sender, EventArgs e)
        {
            new StudentTable().Show();
        }
    }
}