using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Student : BaseEntityForPerson
    {
        //Students name, surnmame.. is added from BaseEntityForPerson class
        public int ClassLevel { get; set; }
        public string ClassBranch { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentPhoneNumber { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
