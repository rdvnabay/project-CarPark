using Core.DataAccess.MongoDb.Configuration;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.MongoDb.Context
{
    public abstract class MongoDbContext
    {
        public readonly IConfiguration Configuration;
        public readonly MongoConnectionSettings MongoConnectionSettings;

        protected MongoDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
            MongoConnectionSettings = configuration.GetSection("MongoDbSettings") as MongoConnectionSettings;
        }
    }
}
