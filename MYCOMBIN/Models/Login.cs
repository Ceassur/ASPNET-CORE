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
    public class Login
    {
        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}