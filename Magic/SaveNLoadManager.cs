using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace StudentCard
{
    public class SaveNLoadManager
    {
        /// <summary>
        /// Сохранение информации о студенте в файл json
        /// </summary>
        /// <param name="student">текущий студент</param>
        public void SaveData(Student student)
        {
            var fullSavePath = Path.Combine(Magic.Properties.Settings.Default.PathToStudentInfo, student.Guid.ToString() + ".json");
            using (var writer = new StreamWriter(fullSavePath))
            {
                var json = JsonConvert.SerializeObject(student);
                writer.Write(json);
            }
        }

        /// <summary>
        /// удаление данных о студенте
        /// </summary>
        /// <param name="student"></param>
        public void DeleteData(Student student)
        {
            var fullPathToStudent = Path.Combine(Magic.Properties.Settings.Default.PathToStudentInfo, student.Guid.ToString() + ".json");
            if (student.Photo)
            {
                var fullPathToFoto = Path.Combine(Magic.Properties.Settings.Default.PathToPhoto, student.Guid.ToString() + ".jpg");
                File.Delete(fullPathToFoto);
            }
            File.Delete(fullPathToStudent);
        }

        /// <summary>
        /// загрузка файла студента
        /// </summary>
        /// <param name="studentsData"></param>
        /// <returns></returns>
        private Student LoadStudentFile(string studentsData)
        {
            var fullDataPath = Path.Combine(Magic.Properties.Settings.Default.PathToStudentInfo, studentsData);

            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Student>(json);
            }
        }

        /// <summary>
        /// Список всех студентов в указанной директории
        /// </summary>
        /// <param name="PathToStudentInfo">путь к файлам</param>
        /// <returns>список студентов</returns>
        private List<Student> GetStudents(string PathToStudentInfo)
        {
            if (!Directory.Exists(PathToStudentInfo))
            {
                Directory.CreateDirectory(PathToStudentInfo);
            }

            var studentList = new List<Student>();
            foreach (var student in Directory.GetFiles(PathToStudentInfo))
            {
                var i = LoadStudentFile(Path.GetFileName(student));
                studentList.Add(i);
            }
            return studentList;
        }

        /// <summary>
        /// Указание директории для получения списка студентов
        /// </summary>
        /// <returns></returns>
        public List<Student> LoadStudentData()
        {
            return GetStudents(Magic.Properties.Settings.Default.PathToStudentInfo);
        }

        /// <summary>
        /// Загрузка информации об институте
        /// </summary>
        /// <returns>объект со списками информации</returns>
        public Curriculum LoadCurruculumData()
        {
            var fullDataPath = Path.Combine(Magic.Properties.Settings.Default.PathToData, "CurriculumInfo.json");
            using (var reader = new StreamReader(fullDataPath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Curriculum>(json); ;
            }
        }

        /// <summary>
        /// Загрузка фото
        /// </summary>
        /// <param name="student">текущий студент</param>
        /// <param name="pictureBox"></param>
        public void LoadFoto(Student student, PictureBox pictureBox)
        {
            pictureBox.ImageLocation = Path.Combine(Magic.Properties.Settings.Default.PathToPhoto, student.Guid.ToString() + ".jpg");
        }

        /// <summary>
        /// загрузка дефолтного фото
        /// </summary>
        /// <param name="pictureBox"></param>
        public void LoadDefaultPhoto(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = Path.Combine(Magic.Properties.Settings.Default.PathToPhoto, "DefaultPhoto.jpg");
            pictureBox.Name = "Default";
        }

        /// <summary>
        /// сохранение фото
        /// </summary>
        /// <param name="student"></param>
        /// <param name="pictureBox"></param>
        public void SavePhoto(Student student, PictureBox pictureBox)
        {
            pictureBox.Image.Save(Path.Combine(Magic.Properties.Settings.Default.PathToPhoto, student.Guid.ToString() + ".jpg"));
        }
    }
}