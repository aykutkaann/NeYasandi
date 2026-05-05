

namespace NeYasandi.Domain.Entities
{
    public class RssSource : BaseEntity
    {
        public Guid CategoryId { get;  set; }


        public string Name { get; set; } //AA NTV TRT vb.
        public string FeedUrl { get; set; }
        public bool IsActive { get; set; }
        public int FetchIntervalMinutes { get; set; } = 60;
        public int ReliabilityScore { get; set; }

        public DateTime? LastFetchedAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
