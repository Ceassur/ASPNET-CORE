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
    public class PostController : Controller
    {
        public ActionResult Index()
        {
            // Post listesini buradan al
            return View(PostRepository.Posts);
        }

        [HttpPost]
        public JsonResult IncreaseLikeCount(int postId)
        {
            // Burada postId ile ilgili postun Like sayısını artırabilirsin.
            // Örneğin: _Posts.FirstOrDefault(p => p.Id == postId)?.LikeCount++;
            var Post = PostRepository.GetById(postId);
            Post.LikeEmojiCount = Convert.ToString(Convert.ToInt32(Post.LikeEmojiCount) + 1);
            return Json(new { Success = true });
        }

        [HttpPost]
        public JsonResult IncreaseMiddleLikeCount(int postId)
        {
            // Burada postId ile ilgili postun Middle Like sayısını artırabilirsin.
            // Örneğin: _Posts.FirstOrDefault(p => p.Id == postId)?.MiddleLikeCount++;
            var Post = PostRepository.GetById(postId);
            Post.MiddlelikeEmojiCount = Convert.ToString(Convert.ToInt32(Post.MiddlelikeEmojiCount) + 1);

            return Json(new { Success = true });
        }

        [HttpPost]
        public JsonResult IncreaseDislikeCount(int postId)
        {
            // Burada postId ile ilgili postun Dislike sayısını artırabilirsin.
            // Örneğin: _Posts.FirstOrDefault(p => p.Id == postId)?.DislikeCount++;
            var Post = PostRepository.GetById(postId);
            Post.DislikeEmojiCount = Convert.ToString(Convert.ToInt32(Post.DislikeEmojiCount) + 1);
            return Json(new { Success = true });
        }
    }

}