using MusiMe.Common.Enums;
using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class Playlist : IEntry
    {
        public string Title { get; set; } = string.Empty;
        public List<PlaylistType> PlaylistType { get; set; } = new();
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public PlaylistVisibility PlaylistVisibility { get; set; }

        // nav properties
        //channel
        public Channel? Channel {get; set;}
        public Guid? PlaylistOwnerId { get; set;}
    }
}