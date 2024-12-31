using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusiMe.Common.Enums;

namespace MusiMe.Infrastructure.Data.Entities{
    public class Channel{
        [Required]
        [Column("Id", TypeName = "UUID")]
        public Guid Id { get; set; }
        [Required]
        [Column("ChannelName", TypeName = "Varchar")]
        public string ChannelName { get; set; }
        [Column("Detail", TypeName = "varchar")]
        public string? Detail { get; set; }
        [Column("ChannelType")]
        public ChannelType ChannelType { get; set; }
        [Column("FavoursCount", TypeName = "Numeric")]
        public int NumberOfFavours { get; set; }
        public Channel(){
            NumberOfFavours = 0;
            Detail = "";
        }
    }
}