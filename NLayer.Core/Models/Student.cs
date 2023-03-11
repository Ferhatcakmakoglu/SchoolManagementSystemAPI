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
        public string Branch { get; set; }
        public string StudentPhoneNumber { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentPhoneNumber { get; set; }
    }
}
