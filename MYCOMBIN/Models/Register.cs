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
    public class Register
    {
        public int Id { get; set; }

        public string? username { get; set; }

        public string? fullName { get; set; }

        public string? email { get; set; }

        public string? phone { get; set; }

        public string? password { get; set; }

        public bool remember { get; set; }
    }


}