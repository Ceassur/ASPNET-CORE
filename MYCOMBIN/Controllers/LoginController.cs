using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MYCOMBIN.Data;
using MYCOMBIN.Models;

namespace MYCOMBIN.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context){

            _context = context;
        } // Dataya veri göndermek için yazılır

        public IActionResult Index()
        {
            ViewData["HeaderName"] = "Login Sayfası";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(Login login)
        {
            //var user = await _context.UserInfos.FirstOrDefaultAsync(u => u.Email == login.email);
            var userList = await _context.UserInfos.ToListAsync();

            foreach (var item in userList)
            {
                if (item.Email == login.Email)
                {

                    string hashedInputPassword = CreateMD5(login.Password);

                    if (hashedInputPassword == item.Password)
                    {
                        // Şifreler eşleşiyor, giriş başarılı
                        // Burada giriş başarılı olduğunu işaretleyebilirsiniz, örneğin session kullanarak veya başka bir yöntemle
                        return RedirectToAction("Index", "ProfileDetail"); // Giriş yapıldıysa ana sayfaya yönlendir
                    }
                }
            }

            // Giriş başarısız, kullanıcı adı veya şifre hatalı
            // Burada giriş başarısız olduğunu kullanıcıya bildirebilirsiniz
            return View("LoginFailed"); // Giriş başarısızsa özel bir view gösterebilirsiniz
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes); // .NET 5 +
            }
        }
    }
}