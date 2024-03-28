using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MYCOMBIN.Controllers
{
    public class LogoutController : Controller
    {

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}