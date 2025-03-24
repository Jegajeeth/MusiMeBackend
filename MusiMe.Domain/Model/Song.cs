using MusiMe.Common.Enums;
using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class Song : IEntry
    {
        public string SongName { get; set; } = string.Empty;
        public string SongDescription { get; set; } = string.Empty;
        public List<Genre> Genres { get; set; } = new();
        public DateTime YearOfRelease { get; set; }
        public TimeSpan SongLength { get; set; }
        public int NumberHeard { get; set; } = 0;

        //nav
        //playlistsong
        public List<Playlistsong> PlaylistSongs { get; set; } = new();
    }
}