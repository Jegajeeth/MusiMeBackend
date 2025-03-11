using MusiMe.Common.Enums;
using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class Music : IEntry
    {
        public string Title { get; set; } = string.Empty;
        public string Descriprion { get; set; } = string.Empty;
        public List<Genre> Genres { get; set; } = new();
        public DateTime YearOfRelease { get; set; }
        public TimeSpan MusicLength { get; set; }
        public int NumberHeard { get; set; } = 0;
    }
}