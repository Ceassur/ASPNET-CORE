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
    public class Multiple
    {
        public List<User>? Users { get; set; }
        public List<Post>? Posts { get; set; }
    }
}