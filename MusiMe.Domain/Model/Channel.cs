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
       //User
       public User User { get; set; } = null!;
       public Guid UserId { get; set; }

       //playlist
       public List<Playlist> playlists { get; set; } = new();
    }
}