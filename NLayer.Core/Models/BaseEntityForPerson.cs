using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public abstract class BaseEntityForPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime CreatedTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
