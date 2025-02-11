using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusiMe.Common.Enums;

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
        [Column("Gender")]
        public Gender Gender { get; set; }
        [Column("Channels", TypeName = "UUID[]")]
        public List<Guid> Channels { get; set; }
        [Column("IsSubscribed", TypeName = "boolean")]
        public bool? IsSubscribed {get; set; }

        public UserManagement(){
            UserName = "";
            Email = "";
            Gender = Gender.Unknown;
            Channels = new();
        }
    }
}