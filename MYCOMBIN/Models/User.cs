using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYCOMBIN.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? RealName { get; set; }
        public string? NickName { get; set; }
        public string? ProfileImage { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Tags { get; set; }
        public bool IsActive { get; set; }
        public string? Instagram { get; set; }
    }
}