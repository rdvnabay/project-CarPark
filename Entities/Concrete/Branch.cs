using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Branch:BaseEntity
    {
        public string Name { get; set; }
        public string WebSite { get; set; }
        public string[] PhoneNumber { get; set; }
        public string[] Personels { get; set; }
        public string[] EmailAddresses { get; set; }

        public Address Address { get; set; }
        public ICollection<WorkingDay> WorkingDays { get; set; }
        public ICollection<Floor> Floors { get; set; }
    }
}
