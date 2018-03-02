using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestingTodoAPI.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }
    }
}