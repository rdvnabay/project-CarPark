using System.Collections;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Floor:BaseEntity
    {
        public int Number { get; set; }
        public ICollection<Slot> Slots { get; set; }
    }
}