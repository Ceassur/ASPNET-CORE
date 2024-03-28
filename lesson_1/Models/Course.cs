using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson_1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? TeacherName { get; set; }
        public int MyProperty { get; set; }

        public string? Myimage { get; set; }
    }
}