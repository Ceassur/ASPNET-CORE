using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSingInViewModel
    {
        
        public string username { get; set; }

        
        public string password { get; set; }

        [BindProperty(Name = "g-recaptcha-response")]
		public string ReCaptchaResponse { get; set; } = string.Empty;

	}
}
