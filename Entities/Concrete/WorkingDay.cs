using System.Collections;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class WorkingDay:BaseEntity
    {
        public ICollection<Translate> Translates { get; set; }
        public ICollection<WorkingHour> WorkinHours { get; set; }
    }
}