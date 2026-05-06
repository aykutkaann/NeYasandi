using MassTransit;
using MassTransit.Transports;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NeYasandi.Application.Events;
using NeYasandi.Application.Interfaces;
using NeYasandi.Infrastructure.Persistence;


namespace NeYasandi.Infrastructure.BackgroundJobs
{
    public class RssFetchJob(IRssFeedParser rssFeed, AppDbContext db, IPublishEndpoint publish, ILogger<RssFetchJob> logger)
    {
        public async Task ExecuteAsync(CancellationToken ct)
        {
            var sources = await db.RssSources.Where(r => r.IsActive).ToListAsync(ct);

            var newlyAddedIds = new List<Guid>();



            foreach (var source in sources)
            {
                try
                {
                    var parsedItems = await rssFeed.ParseAsync(source.FeedUrl, ct);

                    var incomingExternalIds = parsedItems.Select(i => i.ExternalId).ToList();

                    var existingExternalIds = await db.RawNewsItems
                        .Where(i => incomingExternalIds.Contains(i.ExternalId))
                        .Select(i => i.ExternalId)
                        .ToListAsync(ct);

                    var newItems = parsedItems
                        .Where(i => !existingExternalIds.Contains(i.ExternalId))
                        .ToList();

                    foreach (var item in newItems)
                    {
                        item.RssSourceId = source.Id;
                        item.CategoryId = source.CategoryId;

                        db.RawNewsItems.Add(item);
                        newlyAddedIds.Add(item.Id);
                    }

                    source.LastFetchedAt = DateTime.UtcNow;

                    await db.SaveChangesAsync(ct);
                }catch(Exception ex)
                {
                    logger.LogError(ex, "Error while fetching Rss Source : {SourceUrl}", source.FeedUrl);
                    continue;
                }

            }

            if (newlyAddedIds.Any())
            {
                await publish.Publish(new RawNewsItemsFetched(newlyAddedIds), ct);
            }


        }
    }
}
