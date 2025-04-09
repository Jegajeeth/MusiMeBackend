using MediatR;
using MusiMe.Domain.Interface.Repositories;
using MusiMe.Domain.Model;

namespace MusiMe.Application.Usecases
{
    public class GetPlaylistByIdRequest : IRequest<Playlist>
    {
        public Guid playlistId { get; set; }
    }
    public class GetPlaylistByIdUsecase : IRequestHandler<GetPlaylistByIdRequest, Playlist>
    {
        private IPlaylistRepository playlistRepository { get; set; }

        public GetPlaylistByIdUsecase(IPlaylistRepository _playlistRepository) 
        {
            playlistRepository = _playlistRepository;
        }

        public async Task<Playlist> Handle(GetPlaylistByIdRequest request, CancellationToken cancellationToken)
        {
            Playlist foundPlaylist = await playlistRepository.GetPlaylistByIdAsync(request.playlistId) ?? new Playlist();
            
            return foundPlaylist;
        }
    }
}
