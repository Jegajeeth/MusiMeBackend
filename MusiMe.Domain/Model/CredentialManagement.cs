using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class CredentialManagement : IEntry
    {
        public Guid UserId { get; set; }
        public string Email { get;set; } = string.Empty;
        public string Passward { get; set; } = string.Empty;
    }
}