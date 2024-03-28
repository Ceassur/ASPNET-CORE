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
    public class BestOfWeekController : Controller
    {
        public IActionResult Index()
        {
            var filteredPosts = PostRepository.Posts.Where(post => int.Parse(post.LikeEmojiCount) >= 20).ToList();
            return View(filteredPosts);
        }
    }
}