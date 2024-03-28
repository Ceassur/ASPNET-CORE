using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYCOMBIN.Models;
using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace MYCOMBIN.Controllers
{
    public class UploadController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadPost(string description)
        {

            try
            {
                var file = Request.Form.Files[0];

                // Resmi belirli bir yere kaydetmek için bir yol belirle
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Image/PostImage", file.FileName);

                // Resmi kaydet

                var imageUrl = "/Images/" + file.FileName;
                // Burada başka işlemler yapabilirsin.
                // Örneğin, _Posts listesine ekleyebilirsin.
                // _Posts.Add(new Post { ProfileImage = imagePath, Description = description, ... });

                // Şu anlık konsola yazdırıyoruz:
                Console.WriteLine("Uploaded Post:");
                Console.WriteLine($"ProfileImage: {imagePath}");
                Console.WriteLine($"Description: {description}");

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Hata durumunda bir şeyler yapabilirsin.
                ViewBag.ErrorMessage = $"Hata: {ex.Message}";
                return View("Index");
            }
        }
    }
}