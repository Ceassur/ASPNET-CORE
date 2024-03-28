using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MYCOMBIN.Models;

namespace MYCOMBIN.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? ProfileImage { get; set; }
        public string? NickName { get; set; }
        public string? PostImage { get; set; }
        public string? Description { get; set; }
        public string? LikeEmojiCount { get; set; }
        public string? MiddlelikeEmojiCount { get; set; }
        public string? DislikeEmojiCount { get; set; }
        public DateTime? UploadTime { get; set; }
    }
}