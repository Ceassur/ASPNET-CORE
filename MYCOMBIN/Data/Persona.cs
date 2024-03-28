using System.ComponentModel.DataAnnotations;

namespace MYCOMBIN.Data
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public string? Description { get; set; }

    }
}