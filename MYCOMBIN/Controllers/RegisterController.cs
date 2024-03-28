using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Azure.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using MYCOMBIN.Data;
using MYCOMBIN.Models;


namespace MYCOMBIN.Controllers
{
    public class RegisterController : Controller
    {

        private readonly DataContext _context;

        public RegisterController(DataContext context)
        {

            _context = context;
        }

        // Dataya veri göndermek için yazılır

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserList(Register register)
        {
            //var userList =await _context.UserInfos.ToListAsync();

            //Tarihe Göre Büyükten Küçüğe Göre Sırala
            //var userList = await _context.UserInfos.OrderByDescending(x => x.UpdateDate).ToListAsync();

            //Tarihe Göre Küçükten Büyüğe Göre Sırala
            //var userList = await _context.UserInfos.OrderBy(x => x.UpdateDate).ToListAsync();

            var userList = await _context.UserInfos.Where(x => x.IsActive == true).OrderByDescending(x => x.UpdateDate).ToListAsync();

            //var userList = await _context.UserInfos.Where(x => x.UpdateDate < DateTime.Now.Date).ToListAsync();

            //var userList = await _context.UserInfos.Where(x => x.IsActive == true && x.Email.Contains("acunmedya")).ToListAsync();

            return View(userList);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserInfo userInfo)
        {

            _context.Update(userInfo);
            await _context.SaveChangesAsync();

            return View();
        }
        public async Task<IActionResult> Delete(int id)
        {
            var readUser = await _context.UserInfos.FindAsync(id);
            readUser.IsActive = false;

            _context.Update(readUser);
            await _context.SaveChangesAsync();

            return RedirectToAction("UserList");
        }

        public async Task<IActionResult> Edit(int id)
        {
//Tabloları çağırmak için sql sorgusu kullanarak veri tabanından ilişkili tabloları çekmek 
            var user = await _context.UserInfos
            .Where(x => x.Id == id)
            .Include(x => x.UserPersona)
            .ThenInclude(x => x.Persona)
            .FirstOrDefaultAsync();


            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(Register register)
        {
            var userList = await _context.UserInfos.ToListAsync();

            UserInfo newRegister = new UserInfo();

            newRegister.Username = register.username;
            newRegister.FullName = register.fullName;
            newRegister.Email = register.email;
            newRegister.Telephone = register.phone;
            newRegister.Password = CreateMD5(register.password);
            newRegister.UpdateDate = DateTime.Now;
            newRegister.UpdateDate = DateTime.Today;
            newRegister.IsActive = true;
            _context.UserInfos.Add(newRegister);
            await _context.SaveChangesAsync();
            return View("Index", "Home");
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