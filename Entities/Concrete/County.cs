namespace Entities.Concrete
{
    public  class County:BaseEntity
    {
        public string Name { get; set; }
        public string PostCode { get; set; }
        public string Latitude { get; set; }
        public string Logitude { get; set; }
    }
}
