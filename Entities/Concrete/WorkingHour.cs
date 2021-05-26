using System.Collections;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class WorkingHour
    {
        public ICollection<Translate>  Translates { get; set; }
    }
}