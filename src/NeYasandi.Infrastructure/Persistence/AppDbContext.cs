using Microsoft.EntityFrameworkCore;
using NeYasandi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

    }


   
    
}
