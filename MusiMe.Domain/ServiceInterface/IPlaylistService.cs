
using MusiMe.Domain.Model;

namespace MusiMe.Domain.ServiceInterface
{
    public interface IPlaylistService
    {
        public Playlist GetPlaylists(Guid playlistId);
    }
}