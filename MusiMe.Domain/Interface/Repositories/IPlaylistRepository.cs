using MusiMe.Domain.Model;

namespace MusiMe.Domain.Interface.Repositories
{
    public interface IPlaylistRepository : IDisposable
    {
        public Task<Playlist?> GetPlaylistByIdAsync(Guid playlistId);
    }
}
