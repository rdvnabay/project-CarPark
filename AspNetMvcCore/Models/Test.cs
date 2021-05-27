using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace AspNetMvcCore.Models
{
    public class Test
    {
        [BsonId]
        public ObjectId _Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //public ICollection<Address> Addresses { get; set; }
    }

    //public class Address
    //{
    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //}
}
