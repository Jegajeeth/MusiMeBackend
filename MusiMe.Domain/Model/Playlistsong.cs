namespace MusiMe.Domain.Model
{
    public class Playlistsong 
    {
        //nav properties
        //playlist
        public Guid PlaylistId { get; set; }
        public Playlist Playlists { get; set; } = new();

        //song
        public Guid SongId { get; set; }
        public Song Songs { get; set; } = new();
    }
}