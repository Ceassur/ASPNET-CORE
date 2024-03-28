using System.ComponentModel.DataAnnotations;

namespace MYCOMBIN.Data
{
    public class SendInfo
    {
        [Key]

        public string? Email { get; set; }

        public string? Password { get; set; }

    }
}