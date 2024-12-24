using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusiMe.Infrastructure.Data.Entities
{
    public class UserManagement
    {
        [Required]
        [Column("Id", TypeName ="UUID")]
        public Guid Id {get; set;}
        [Required]
        [Column("UserName", TypeName = "varchar")]
        public string UserName {get; set;}
        [Column("Email", TypeName = "varchar")]
        public string Email {get; set;}
        [Column("Gemder", TypeName = "varchar")]
        public string Gender { get; set; }
        [Column("Chennals", TypeName = "UUID[]")]
        public Guid[] Channels { get; set; }
        [Column("IsSubscribed", TypeName = "boolean")]
        public bool? IsSubscribed {get; set; }

        public UserManagement(){
            Email = "";
            Gender = "Unknown";
            Channels = [];
        }
    }
}