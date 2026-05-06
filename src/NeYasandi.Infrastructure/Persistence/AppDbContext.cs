using Microsoft.EntityFrameworkCore;
using NeYasandi.Domain.Entities;

namespace NeYasandi.Infrastructure.Persistence
{
    public  class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<DailyPage> DailyPages => Set<DailyPage>();
        public DbSet<DailySection> DailySections => Set<DailySection>();
        public DbSet<DailySectionImage> DailySectionImages => Set<DailySectionImage>();
        public DbSet<ForumPost> ForumPosts => Set<ForumPost>();
        public DbSet<ForumPostVote> ForumPostVotes => Set<ForumPostVote>();
        public DbSet<ForumReport> ForumReports => Set<ForumReport>();
        public DbSet<ForumThread> ForumThreads => Set<ForumThread>();
        public DbSet<RawNewsItem> RawNewsItems => Set<RawNewsItem>();
        public DbSet<RssSource> RssSources => Set<RssSource>();
        public DbSet<SourceAttribution> SourceAttributions => Set<SourceAttribution>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

            var gundemId = Guid.Parse("07018177-3367-4835-9005-95079EFA56B4");
            var siyasetId = Guid.Parse("E8043642-E93C-4D2A-9494-DB9E198357A4");
            var ekonomiId = Guid.Parse("66085C66-E061-464A-A04B-F88E9164A4A7");
            var dunyaId = Guid.Parse("7F6E7977-1F93-4B07-A79B-89E9064B9521");
            var sporId = Guid.Parse("F50D9E1A-A0D3-46B9-B3C5-1772F22F4343");
            var teknolojiId = Guid.Parse("B1781E83-9366-4AF2-A1C8-17551D67B7A4");
            var kulturId = Guid.Parse("3E6D0A92-6F7E-4644-8C9B-1B903E794432");
            var saglikId = Guid.Parse("D7D397C1-E8D5-4F54-9430-80E800D309D5");

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = gundemId, Name = "Gündem", Slug = "gundem", DisplayOrder = 1, IsActive = true },
                new Category { Id = siyasetId, Name = "Siyaset", Slug = "siyaset", DisplayOrder = 2, IsActive = true },
                new Category { Id = ekonomiId, Name = "Ekonomi", Slug = "ekonomi", DisplayOrder = 3, IsActive = true },
                new Category { Id = dunyaId, Name = "Dünya", Slug = "dunya", DisplayOrder = 4, IsActive = true },
                new Category { Id = sporId, Name = "Spor", Slug = "spor", DisplayOrder = 5, IsActive = true },
                new Category { Id = teknolojiId, Name = "Teknoloji", Slug = "teknoloji", DisplayOrder = 6, IsActive = true },
                new Category { Id = kulturId, Name = "Kültür-Sanat", Slug = "kultur-sanat", DisplayOrder = 7, IsActive = true },
                new Category { Id = saglikId, Name = "Sağlık", Slug = "saglik", DisplayOrder = 8, IsActive = true }
            );

            // --- RSS SOURCES SEED DATA ---
            modelBuilder.Entity<RssSource>().HasData(
                new RssSource
                {
                    Id = Guid.Parse("A1A1A1A1-A1A1-4A1A-A1A1-A1A1A1A1A1A1"),
                    Name = "TRT Haber - Manşet",
                    FeedUrl = "https://www.trthaber.com/manset_articles.rss",
                    CategoryId = gundemId,
                    IsActive = true,
                    FetchIntervalMinutes = 60,
                    ReliabilityScore = 9,
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new RssSource
                {
                    Id = Guid.Parse("B2B2B2B2-B2B2-4B2B-B2B2-B2B2B2B2B2B2"),
                    Name = "Anadolu Ajansı - Güncel",
                    FeedUrl = "https://www.aa.com.tr/tr/rss/default?cat=guncel",
                    CategoryId = gundemId,
                    IsActive = true,
                    FetchIntervalMinutes = 60,
                    ReliabilityScore = 10,
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new RssSource
                {
                    Id = Guid.Parse("C3C3C3C3-C3C3-4C3C-C3C3-C3C3C3C3C3C3"),
                    Name = "Bloomberg HT - Ekonomi",
                    FeedUrl = "https://www.bloomberght.com/rss",
                    CategoryId = ekonomiId,
                    IsActive = true,
                    FetchIntervalMinutes = 60,
                    ReliabilityScore = 8,
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new RssSource
                {
                    Id = Guid.Parse("D4D4D4D4-D4D4-4D4D-D4D4-D4D4D4D4D4D4"),
                    Name = "NTV Spor - Genel",
                    FeedUrl = "https://www.ntvspor.net/rss",
                    CategoryId = sporId,
                    IsActive = true,
                    FetchIntervalMinutes = 60,
                    ReliabilityScore = 8,
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                },
                new RssSource
                {
                    Id = Guid.Parse("E5E5E5E5-E5E5-4E5E-E5E5-E5E5E5E5E5E5"),
                    Name = "BBC Türkçe - Dünya",
                    FeedUrl = "https://feeds.bbci.co.uk/turkce/rss.xml",
                    CategoryId = dunyaId,
                    IsActive = true,
                    FetchIntervalMinutes = 60,
                    ReliabilityScore = 9,
                    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }

    }


   
    
}
