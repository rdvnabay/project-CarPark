using AspNetMvcCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcCore.Controllers
{
    public class UserController : Controller
    {
        private IStringLocalizer<UserController> _localizer;
        public UserController(IStringLocalizer<UserController> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            var firstName = _localizer["FirstName"];
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserModel userModel)
        {
            return View(userModel);
        }
    }
}
