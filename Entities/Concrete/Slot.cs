using System.Collections;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Slot:BaseEntity
    {
        public ICollection<Translate>Translates { get; set; }
    }
}