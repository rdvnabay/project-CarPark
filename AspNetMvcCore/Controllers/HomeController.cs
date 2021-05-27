using AspNetMvcCore.Models;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace AspNetMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<HomeController> _localizer;
        public HomeController(
            ILogger<HomeController> logger,
            IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            var sayHello = _localizer["Say_Hello"];

            var cultureInfo = CultureInfo.GetCultureInfo("tr-TR");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            var sayHelloEng = _localizer["Say_Hello"];

            //var test = new Test
            //{
            //    _Id = ObjectId.GenerateNewId(),
            //    FirstName = "Ramazan",
            //    LastName = "Beyaz",
            //    Age = 25,
            //    Addresses = new List<Address>()
            //    {
            //        new Address
            //        {
            //            Title="İstanbul",
            //            Description="Adres 1"
            //        },
            //        new Address
            //        {
            //            Title="Ankara",
            //            Description="Adres 2"
            //        }
            //    }
            //};

            //_logger.LogError("Loglama yapıldı {@test}", test);
            //var client = new MongoClient("mongodb+srv://rdvnabay:12345@carparkcluster.m1mmp.mongodb.net/CarParkDb?retryWrites=true&w=majority");
            //var database = client.GetDatabase("CarParkDb");
            //var collection = database.GetCollection<Test>("Test");


            //collection.InsertOne(test);
            var jsonString = System.IO.File.ReadAllText("cities.json");
            var cities = JsonConvert.DeserializeObject<List<CityModel>>(jsonString);
           // var citiesCollection = database.GetCollection<City>("City");
            foreach (var item in cities)
            {
                var city = new City
                {
                    Id = ObjectId.GenerateNewId(),
                    Name = item.Name,
                    Plate = item.Plate,
                    Latitude = item.Latitude,
                    Logitude = item.Longitude,
                    Counties = new List<County>()
                };
                foreach (var county in item.Counties)
                {
                    city.Counties.Add(
                        new County
                        {
                            Id = ObjectId.GenerateNewId(),
                            Name = county,
                            Latitude = "",
                            Logitude = "",
                            PostCode = ""
                        }
                    );
                }
               // citiesCollection.InsertOne(city);
            }
            return View();
        }
    }
}
