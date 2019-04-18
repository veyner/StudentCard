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

using Newtonsoft.Json;

namespace StudentCard
{
    public partial class StudentCard : Form
    {
        private StudentTable _studentTable;
        private List<Student> _dataStudent;
        private Student _student;
        private ComboBoxManager _comboBoxManager;
        private SaveNLoadManager _manager;
        private bool _save;
        private bool _changes;

        public StudentCard(StudentTable studentTable, List<Student> dataStudent)
        {
            _dataStudent = dataStudent;
            _studentTable = studentTable;
            InitializeComponent();
            _comboBoxManager = new ComboBoxManager();
            _manager = new SaveNLoadManager();
            _comboBoxManager.LoadInfoToFacultyCombobox(FacultyComboBox);
            _comboBoxManager.LoadInfoToCourceComboBox(CourceComboBox);
            _manager.LoadDefaultPhoto(PhotoPictureBox);
            _changes = false;
        }

        /// <summary>
        /// загрузка данных студента в текстбоксы и комбобоксы
        /// </summary>
        /// <param name="student">текущий студент</param>
        public void ChangeBoxes(Student student)
        {
            _student = student;

            SurnameTextBox.Text = _student.Surname;
            NameTextBox.Text = _student.Name;
            MiddlenameTextBox.Text = _student.MiddleName;
            CityTextBox.Text = _student.City;
            AddressTextBox.Text = _student.Street;
            TelefonTextBox.Text = _student.TelefonNumber;
            EmailTextBox.Text = _student.Email;

            FacultyComboBox.ValueMember = nameof(Faculty.ID);
            FacultyComboBox.SelectedValue = _student.FacultyID;

            SpecialityComboBox.ValueMember = nameof(Speciality.ID);
            SpecialityComboBox.SelectedValue = _student.SpecialityID;

            CourceComboBox.ValueMember = nameof(Cource.ID);
            CourceComboBox.SelectedValue = _student.CourceID;

            GroupComboBox.ValueMember = nameof(Group.ID);
            GroupComboBox.SelectedValue = _student.GroupID;

            if (_student.Photo)
            {
                _manager.LoadFoto(_student, PhotoPictureBox);
                PhotoPictureBox.Name = _student.Guid.ToString();
            }
            else
            {
                _manager.LoadDefaultPhoto(PhotoPictureBox);
            }
            _changes = false;
        }

        private void SaveStudentCardButton_Click(object sender, EventArgs e)
        {
            if (_student == null)
            {
                _student = new Student
                {
                    Guid = Guid.NewGuid()
                };
                _dataStudent.Add(_student);
            }
            SaveCurrentStudent(_student);
        }

        /// <summary>
        /// сохранение данных о конкретном студенте
        /// </summary>
        /// <param name="student">текущий студент</param>
        private void SaveCurrentStudent(Student student)
        {
            var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
            var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
            var currentCource = (Cource)CourceComboBox.SelectedItem;
            var currentGroup = (Group)GroupComboBox.SelectedItem;
            if (CheckResult(currentFaculty, currentSpeciality, currentCource, currentGroup))
            {
                student.Surname = SurnameTextBox.Text;
                student.Name = NameTextBox.Text;
                student.MiddleName = MiddlenameTextBox.Text;
                student.City = CityTextBox.Text;
                student.Street = AddressTextBox.Text;
                student.TelefonNumber = TelefonTextBox.Text;
                student.Email = EmailTextBox.Text;
                student.FacultyID = currentFaculty.ID;
                student.SpecialityID = currentSpeciality.ID;
                student.CourceID = currentCource.ID;
                student.GroupID = currentGroup.ID;
                if (PhotoPictureBox.Name == student.Guid.ToString())
                {
                    student.Photo = true;
                    _manager.SavePhoto(student, PhotoPictureBox);
                }
                else
                {
                    student.Photo = false;
                }
                _manager.SaveData(student);
                MessageBox.Show($"Данные {student.Surname} сохранены");
                _save = true;
                Close();
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        private bool CheckResult(Faculty faculty, Speciality speciality, Cource cource, Group group)
        {
            var result = true;

            var checkSurname = CheckTextBox(SurnameLabel, SurnameTextBox);
            var checkName = CheckTextBox(NameLabel, NameTextBox);
            var checkMidname = CheckTextBox(MiddlenameLabel, MiddlenameTextBox);
            var checkCity = CheckTextBox(CityLabel, CityTextBox);
            var checkAddress = CheckTextBox(AddressLabel, AddressTextBox);
            var checkFaculty = CheckComboBox(FacultyLabel, FacultyComboBox, faculty.ID);
            var checkSpeciality = CheckComboBox(SpecialityLabel, SpecialityComboBox, speciality.ID);
            var checkCource = CheckComboBox(CourceLabel, CourceComboBox, cource.ID);
            var checkGroup = CheckComboBox(GroupLabel, GroupComboBox, group.ID);

            if (!checkSurname
                || !checkName
                || !checkMidname
                || !checkCity
                || !checkAddress
                || !checkFaculty
                || !checkSpeciality
                || !checkCource
                || !checkGroup)
            {
                result = false;
            }
            return result;
        }

        private bool CheckTextBox(Label label, TextBox textBox)
        {
            var result = true;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                label.Text += "*";
                result = false;
            }
            return result;
        }

        private bool CheckComboBox(Label label, ComboBox combobox, int id)
        {
            var result = true;
            if (id == 0 && combobox.SelectedIndex == 0)
            {
                label.Text += "*";
                result = false;
            }
            return result;
        }

        private void FotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenPhoto(_student);
        }

        /// <summary>
        /// Открытие окна для поиска фото
        /// </summary>
        /// <param name="student">текущий студент</param>
        private void OpenPhoto(Student student)
        {
            if (FotoOpenFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            PhotoPictureBox.ImageLocation = FotoOpenFileDialog.FileName;
            PhotoPictureBox.Name = student.Guid.ToString();
        }

        private void StudentCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_changes && !_save && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                "Закрыть форму без сохранения?",
                "Закрыть",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            if (!_changes)
            {
                e.Cancel = false;
            }
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _changes = true;
            _comboBoxManager.LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
        }

        private void CourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _changes = true;
            _comboBoxManager.LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox, CourceComboBox);
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void MiddlenameTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void TelefonTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        private void PhotoPictureBox_RegionChanged(object sender, EventArgs e)
        {
            _changes = true;
        }

        public Student GetCurrentStudentFromCard()
        {
            return _student;
        }
    }
}