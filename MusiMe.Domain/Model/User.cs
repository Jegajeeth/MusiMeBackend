using MusiMe.Common.Enums;
using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class User : IEntry
    {
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public bool? IsSubscribed { get; set; }
    }
}