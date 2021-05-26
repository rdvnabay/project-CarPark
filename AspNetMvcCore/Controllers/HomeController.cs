﻿using AspNetMvcCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AspNetMvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Loglama yapıldı");
            var client = new MongoClient("mongodb+srv://rdvnabay:12345@carparkcluster.m1mmp.mongodb.net/CarParkDb?retryWrites=true&w=majority");
            var database = client.GetDatabase("CarParkDb");
            var collection = database.GetCollection<Test>("Test");

            var test = new Test
            {
                _Id = ObjectId.GenerateNewId(),
                FirstName = "Rıdvan",
                LastName = "Abay",
                Age = 28,
                Addresses = new List<Address>()
                {
                    new Address
                    {
                        Title="İstanbul",
                        Description="Adres 1"
                    },
                    new Address
                    {
                        Title="Ankara",
                        Description="Adres 2"
                    }
                }
            };
            collection.InsertOne(test);
            return View();
        }
    }
}