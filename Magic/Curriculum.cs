using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace StudentCard
{
    public class Curriculum
    {
        public List<Faculty> Faculties { get; set; }
        public List<Speciality> Specialities { get; set; }
        public List<Group> Groups { get; set; }
        public List<Cource> Cources { get; set; }

        /* public void SaveCurriculumData()
         {
             var curriculumInfo = new Curriculum();
             curriculumInfo.Faculties = new List<Faculty>
             {
                 new Faculty()
             };
             var fac1 = curriculumInfo.Faculties[0];
             fac1.ID = 1;
             fac1.Name = "Психолого-педагогический";
             curriculumInfo.Specialities = new List<Speciality> { new Speciality() };
             curriculumInfo.Specialities.Add(new Speciality());
             var spec1 = curriculumInfo.Specialities[0];
             spec1.Name = "Учитель информатики";
             spec1.ID = 1;
             spec1.FacultyID = 1;
             curriculumInfo.Groups = new List<Group> { new Group() };
             curriculumInfo.Groups.Add(new Group());
             var group1 = curriculumInfo.Groups[0];
             group1.ID = 1;
             group1.Name = "ПИ1";
             group1.SpecialityID = 1;

             var fullSavePath = Path.Combine(Properties.Settings.Default.PathToData, "CurriculumInfo.json");

             using (var writer = new StreamWriter(fullSavePath))
             {
                 var json = JsonConvert.SerializeObject(curriculumInfo);
                 writer.Write(json);
             }
         }*/
    }
}