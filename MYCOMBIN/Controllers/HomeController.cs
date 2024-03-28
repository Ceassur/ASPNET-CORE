using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MYCOMBIN.Models;

namespace MYCOMBIN.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string messageDay = "İyi Günler";
        string messageNight = "İyi Akşamlar";

        string[] motivationSample = new string[]
        {
            "Stil senin kişisel ifaden, her gün yeni bir tuval.",
            "Moda sadece kıyafetlerde değil, kendine olan güveninde de yansır.",
            "Kıyafetlerinle kendi hikayeni anlat, her parça bir anıyı sembolize eder.",
            "Her gün giydiğin kıyafet, gününü ve ruh halini yansıtır.",
            "Tarz, kendini ifade etmenin en güzel yollarından biridir.",
            "Moda sadece trendler değil, kendini keşfetme yolculuğudur.",
            "Her sezon yeni bir moda akımı, yeni bir başlangıç demektir.",
            "Kıyafetlerle oyna, kombinlerle sınırları zorla, kendi tarzını yarat.",
            "Bir parça kumaşla bile dünyaya farklı bir perspektif sunabilirsin.",
            "Moda, sadece kıyafetlerin değil, ruhunun bir yansımasıdır."
        };

        Random random = new Random();

        // 1 ile 10 arasında rastgele bir sayı üret
        int randomNum = random.Next(0, 10);
        String messageMotivation = motivationSample[randomNum];
        ViewBag.MessageMotivation = messageMotivation;

        int hour = DateTime.Now.Hour;

        if (hour > 19)
        {
            ViewBag.Message = messageNight;
        }
        else
        {
            ViewBag.Message = messageDay;
        }

        Multiple model = new Multiple();
        model.Users = Repository.Users;
        model.Posts = PostRepository.Posts;
        return View(model);
    }
    public IActionResult ProfileDetail()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
