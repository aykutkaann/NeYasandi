using CodeHollow.FeedReader;
using NeYasandi.Application.Interfaces;
using NeYasandi.Domain.Entities;

using System.Text.RegularExpressions;

namespace NeYasandi.Infrastructure.Services
{
    public class RssFeedParser :IRssFeedParser
    {
        public async Task<IEnumerable<RawNewsItem>> ParseAsync(string feedUrl, CancellationToken cancellationToken)
        {
            var feed = await FeedReader.ReadAsync(feedUrl);

            var newsItems = new List<RawNewsItem>();

            foreach(var item in feed.Items)
            {
                newsItems.Add(new RawNewsItem
                {
                    Id = Guid.NewGuid(),
                    ExternalId = item.Id ?? item.Link,
                    Title = item.Title,
                    Description = StripHtml(item.Description),
                    SourceUrl = item.Link,

                    PublishedAt = item.PublishingDate ?? DateTime.UtcNow,
                    FetchedAt = DateTime.UtcNow,
                    IsProcessed = false,
                    ImageUrl = null,

                    RssSourceId = Guid.Empty,
                    CategoryId = Guid.Empty
                });
            }

            return newsItems;
            
        }

        private static string StripHtml(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            return Regex.Replace(input, "<.*?>", string.Empty).Trim();
        }
    }
}
