using MusiMe.Common.Enums;
using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class Channel : IEntry
    {
        public string ChannelName { get; set; } = string.Empty;
        public string? Detail { get; set; } = string.Empty;
        public ChannelType ChannelType { get; set; }
        public int NumberOfFavours { get; set; } = 0;

       //nav properties
       public User User { get; set; } = null!;
       public Guid UserId { get; set; }
    }
}