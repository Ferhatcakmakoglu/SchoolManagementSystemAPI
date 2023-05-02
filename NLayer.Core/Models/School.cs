using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class School : BaseEntityForSchool
    {
        public int DateOfConstruction { get; set; } //school age
        public int NumberOfStudent { get; set; }
        public int NumberOfTeacher { get; set; }
        public string Adress { get; set; }
        public string MailAdress { get; set; }
        public string PhoneNumber { get; set; }
        //public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        
    }
}
