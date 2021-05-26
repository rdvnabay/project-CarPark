using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Personel:BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Passord { get; set; }
        public string[] Roles { get; set; }
      
  
        public short Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public PersonelContact PersonelContact { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
