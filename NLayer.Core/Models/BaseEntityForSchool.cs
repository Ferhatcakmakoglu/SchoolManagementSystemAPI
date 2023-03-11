using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class BaseEntityForSchool
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SchoolType { get; set; } //Middle School, University..
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
