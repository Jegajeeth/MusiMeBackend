using MusiMe.Common.Enums;
using MusiMe.Domain.Interface;

namespace MusiMe.Domain.Model
{
    public class Author : IValueObject
    {
        public Guid channelId { get; set; }
        public string ChannelName { get; set; } = string.Empty;
        public AuthorType AuthorType { get; set; }
    }
}