using MusiMe.Domain.Interface.Repositories;
using MusiMe.Domain.Model;
using MusiMe.Infrastructure.Data.Context;

namespace MusiMe.Application.Repositories
{
    public class PlaylistRepository : IPlaylistRepository, IDisposable
    {
        private DBContext _DBContext { get; set; }
        private bool _disposed = false;
        public PlaylistRepository(DBContext dBContext) 
        {
            _DBContext = dBContext;
        }

        public async Task<Playlist?> GetPlaylistByIdAsync(Guid playlistId)
        {
            return await _DBContext.playlists.FindAsync(playlistId);
        }

        private void Dispose(bool isDisposed) 
        {
            if (!this._disposed)
            { 
                if (isDisposed)
                {
                    _DBContext.Dispose();
                }
            }
            this._disposed = true;

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
