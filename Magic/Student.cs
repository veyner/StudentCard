using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCard
{
    public class Student
    {
        public Guid Guid { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string TelefonNumber { get; set; }
        public string Email { get; set; }
        public bool Photo { get; set; }

        public int FacultyID { get; set; }
        public int SpecialityID { get; set; }
        public int GroupID { get; set; }
        public int CourceID { get; set; }
    }
}