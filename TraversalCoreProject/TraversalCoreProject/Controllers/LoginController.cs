using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using reCAPTCHA.AspNetCore;
using System.Net;
using TraversalCoreProject.Models;
using TraversalCoreProject.Services;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
		public class reCaptchaResponse
		{
            [JsonProperty("Success")]
			public bool Success { get; set; }
			public string[] ErrorCodes { get; set; }
		}

		private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

		public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> SingUp(UserRegisterViewModel p)
        {

            AppUser appUser = new AppUser()
            {

                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.Username,
                

            };
            if(p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }


        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(UserSingInViewModel p)
        {
            

            var errorText = "";
			if (ModelState.IsValid)
            {
                var captchaSvc = new ReCaptcha(p.ReCaptchaResponse);
                var isCaptchaVerified = await captchaSvc.Verify();

                if (!isCaptchaVerified)
                {
                    errorText = "Doğrulama Başarısız!";
                    return StatusCode(500, errorText);
                }

				var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new {area="Member"});
                }
            }
            else
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View();
        }

		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index","Default");
		}
        
	}
}
