using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYCOMBIN.Models;

namespace MYCOMBIN.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index(string Nickname)
        {
            return View(Repository.GetByNickName(Nickname));
        }
    }
}