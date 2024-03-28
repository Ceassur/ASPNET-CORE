using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.CommentDTOs
{
    public class CommentDTO
    {
        public DateTime CommentDate { get; set; }
        public bool CommentState { get; set; }

        [BindProperty(Name = "g-recaptcha-response")]
        public string ReCaptchaResponse { get; set; } = string.Empty;
    }
}
