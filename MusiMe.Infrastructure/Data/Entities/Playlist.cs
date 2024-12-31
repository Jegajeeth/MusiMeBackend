using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusiMe.Common.Enums;

namespace MusiMe.Infrastructure.Data.Entities{
    public class Playlist{
        [Required]
        [Column("Id", TypeName = "UUID")]
        public Guid Id { get; set; }
        [Required]
        [Column("Title", TypeName = "varchar")]
        public string Title { get; set; }
        [Column("PlaylistType")]
        public List<PlaylistType> PlaylistType { get; set; }
        [Column("createDate")]
        public DateTime CreateDate { get; set; }
        [Column("MusicList")]
        public List<Guid> MusicList { get; set; }
        [Column("PlaylistOwnerId", TypeName = "UUID")]
        public Guid PlaylistOwnerId { get; set; }
        [Column("PlaylistVisibility")]
        public PlaylistVisibility PlaylistVisibility { get; set; }
        public Playlist() {
            MusicList = new();
            PlaylistType = new();
            PlaylistType = new List<PlaylistType>();
            CreateDate = DateTime.Now;
            PlaylistVisibility = PlaylistVisibility.Public;
        }
    }
}