using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class Credentials : IEntry
    {
        public string Email { get;set; } = string.Empty;
        public string Passward { get; set; } = string.Empty;

        //nav properties
        public User? User { get; set; }
        public Guid? UserId { get; set; }
    }
}