using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities.Concrete
{
    public class BaseEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
