using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MYCOMBIN.Data;
using MYCOMBIN.Models;

namespace MYCOMBIN.Controllers
{
    public class ProfileDetailController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewData["Post"] = PostRepository.GetById(id);
            return View(Repository.GetById(id));
        }
    }
}