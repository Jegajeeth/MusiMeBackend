using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusiMe.Common.Enums;

namespace MusiMe.Infrastructure.Data.Entities{
    public class Music{
        [Required]
        [Column("Id", TypeName = "UUID")]
        public Guid Id { get; set; }
        [Column("Title", TypeName = "varchar")]
        public string Title { get; set; }
        [Column("Description", TypeName = "varchar")]
        public string Descriprion { get; set; }
        [Column("Genres")]
        public List<Genres> Genres { get; set; }
        [Column("Author")]
        public List<Guid> Author { get; set; }
        [Column("Featured")]
        public List<Guid> Featured { get; set; }
        [Column("YearofRelease")]
        public DateTime YearOfRelease { get; set; }
        [Column("Musiclength")]
        public TimeSpan MusicLength { get; set; }
        [Column("NumberHeard")]
        public int NumberHeard { get; set; }
        public Music() {
            Descriprion = "";
            NumberHeard = 0;
            Genres = new();
            Author = new();
            Featured = new();
        }
    }
}