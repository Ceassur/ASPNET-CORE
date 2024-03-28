using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYCOMBIN.Models
{
    public class PostRepository
    {
        private static readonly List<Post> _Posts = new List<Post>();

        static PostRepository()
        {
            _Posts = new List<Post>()
            {
                // new Post() { Id = 1, ProfileImage = "1.png", NickName = "Grethrain", PostImage = "post1.png", Description = "Güzel bir gün!", LikeEmojiCount = "10", MiddlelikeEmojiCount = "5", DislikeEmojiCount = "2", UploadTime = DateTime.Now.AddDays(-1) },
                new Post() { Id = 2, ProfileImage = "2.png", NickName = "Sparkle123", PostImage = "post2.png", Description = "Yeni bir maceraya hazırım!", LikeEmojiCount = "9", MiddlelikeEmojiCount = "8", DislikeEmojiCount = "3", UploadTime = DateTime.Now.AddHours(-6) },
                new Post() { Id = 3, ProfileImage = "3.png", NickName = "Anonymous", PostImage = "post3.png", Description = "Hayatın tadını çıkarın!", LikeEmojiCount = "15", MiddlelikeEmojiCount = "7", DislikeEmojiCount = "1", UploadTime = DateTime.Now.AddDays(-2) },
                new Post() { Id = 4, ProfileImage = "4.png", NickName = "Sunflower", PostImage = "post4.png", Description = "Gökyüzüne bakarak huzur buluyorum.", LikeEmojiCount = "20", MiddlelikeEmojiCount = "10", DislikeEmojiCount = "5", UploadTime = DateTime.Now.AddHours(-10) },
                new Post() { Id = 5, ProfileImage = "5.png", NickName = "TechGeek", PostImage = "post5.png", Description = "Bugün biraz teknoloji keşfi yaptım!", LikeEmojiCount = "18", MiddlelikeEmojiCount = "9", DislikeEmojiCount = "4", UploadTime = DateTime.Now.AddDays(-3) },
                new Post() { Id = 6, ProfileImage = "6.png", NickName = "Moonlight", PostImage = "post6.png", Description = "Kitap okumak beni her zaman rahatlatır.", LikeEmojiCount = "22", MiddlelikeEmojiCount = "11", DislikeEmojiCount = "6", UploadTime = DateTime.Now.AddHours(-8) },
                new Post() { Id = 7, ProfileImage = "7.png", NickName = "Dancer", PostImage = "post7.png", Description = "Doğanın güzellikleri hiç bitmez.", LikeEmojiCount = "30", MiddlelikeEmojiCount = "15", DislikeEmojiCount = "8", UploadTime = DateTime.Now.AddDays(-4) },
                new Post() { Id = 8, ProfileImage = "8.png", NickName = "NatureLover", PostImage = "post8.png", Description = "Güzel anılar biriktiriyoruz.", LikeEmojiCount = "14", MiddlelikeEmojiCount = "6", DislikeEmojiCount = "3", UploadTime = DateTime.Now.AddHours(-12) },
                new Post() { Id = 9, ProfileImage = "9.png", NickName = "GamerX", PostImage = "post9.png", Description = "Kahve keyfi ☕️", LikeEmojiCount = "28", MiddlelikeEmojiCount = "14", DislikeEmojiCount = "7", UploadTime = DateTime.Now.AddDays(-5) },
                new Post() { Id = 10, ProfileImage = "10.png", NickName = "Bookworm", PostImage = "post10.png", Description = "Yeni insanlar tanıdım, yeni dostluklar kurdum.", LikeEmojiCount = "12", MiddlelikeEmojiCount = "4", DislikeEmojiCount = "2", UploadTime = DateTime.Now.AddHours(-14) },
                new Post() { Id = 11, ProfileImage = "11.png", NickName = "Traveler", PostImage = "post11.png", Description = "Bugün biraz sanatla ilgilendim.", LikeEmojiCount = "24", MiddlelikeEmojiCount = "12", DislikeEmojiCount = "6", UploadTime = DateTime.Now.AddDays(-6) },
                new Post() { Id = 12, ProfileImage = "12.png", NickName = "Fashionista", PostImage = "post12.png", Description = "Eğlenceli bir gün geçirdim!", LikeEmojiCount = "16", MiddlelikeEmojiCount = "8", DislikeEmojiCount = "4", UploadTime = DateTime.Now.AddHours(-16) }
            };

        }
        public static List<Post> Posts
        {
            get
            {
                return _Posts;
            }
        }
        public static Post? GetByNickName(string NickName)
        {
            return _Posts.FirstOrDefault(u => u.NickName == NickName);
        }
        public static Post? GetById(int id)
        {
            return _Posts.FirstOrDefault(u => u.Id == id);
        }
        public static void AddPost(Post model)
        {
            _Posts.Add(model);
        }
    }
}