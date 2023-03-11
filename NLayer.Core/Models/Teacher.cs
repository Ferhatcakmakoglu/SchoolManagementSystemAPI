using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Teacher : BaseEntityForPerson
    {
        //Teacher name, surnmame.. is added from BaseEntityForPerson class
        public string Branch { get; set; } //Math, Science
        public string BranchType { get; set; } //Teacher or Manager

    }
}
