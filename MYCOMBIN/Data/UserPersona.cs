
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MYCOMBIN.Models;

namespace MYCOMBIN.Data
{
    public class UserPersona
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]

        public UserInfo UserInfo { get; set; } = null;
        public int PersonaId { get; set; }

        [ForeignKey("PersonaId")]
        public Persona Persona { get; set; } = null;

        public DateTime CreateDate { get; set; }
    }
}