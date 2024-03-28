using System.ComponentModel.DataAnnotations;

namespace MYCOMBIN.Data
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string? Telephone { get; set; }

        public string? Password { get; set; }
        public string? ProfileImage { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

        public bool IsActive2 { get; set; }
        public ICollection<UserPersona> UserPersona { get; set; } = new List<UserPersona>();
//Tablolar arasında ki ilişkiyi kurmak için tablo üzerinde bunu belirtmem gerekiyor burada olduğu gibi!!
    }
}