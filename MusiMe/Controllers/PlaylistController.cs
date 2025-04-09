using MediatR;
using Microsoft.AspNetCore.Mvc;
using MusiMe.Application.Usecases;
using MusiMe.Domain.Model;

namespace MusiMe.Controllers
{
    [Route("[Controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly IMediator mediator;
        public PlaylistController(IMediator _mediator) 
        {
            mediator = _mediator;
        }
        [HttpGet]
        [Route("{Id}")]
        public async Task<IActionResult> GetPlaylists(Guid Id) 
        {
            Playlist response = await mediator.Send(new GetPlaylistByIdRequest()
            {
                playlistId = Id
            });
            return Ok(response);
        }
        [HttpGet]
        [Route("")]
        public string GetPlaylist() 
        {
            return "Helsdfsdflo!";
        }
    }
}
