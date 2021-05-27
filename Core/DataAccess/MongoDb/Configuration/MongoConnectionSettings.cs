using MongoDB.Driver;

namespace Core.DataAccess.MongoDb.Configuration
{
    public class MongoConnectionSettings
    {
        private MongoClientSettings MongoClientSettings { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public MongoConnectionSettings(MongoClientSettings mongoClientSettings)
        {
            MongoClientSettings = mongoClientSettings;
        }

        public MongoConnectionSettings()
        {

        }

        public MongoClientSettings GetMongoClientSettings()
        {
            return MongoClientSettings;
        }
    }
}
