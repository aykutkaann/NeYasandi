using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeYasandi.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoriesAndRssSources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "IconUrl", "IsActive", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("07018177-3367-4835-9005-95079efa56b4"), 1, null, true, "Gündem", "gundem" },
                    { new Guid("3e6d0a92-6f7e-4644-8c9b-1b903e794432"), 7, null, true, "Kültür-Sanat", "kultur-sanat" },
                    { new Guid("66085c66-e061-464a-a04b-f88e9164a4a7"), 3, null, true, "Ekonomi", "ekonomi" },
                    { new Guid("7f6e7977-1f93-4b07-a79b-89e9064b9521"), 4, null, true, "Dünya", "dunya" },
                    { new Guid("b1781e83-9366-4af2-a1c8-17551d67b7a4"), 6, null, true, "Teknoloji", "teknoloji" },
                    { new Guid("d7d397c1-e8d5-4f54-9430-80e800d309d5"), 8, null, true, "Sağlık", "saglik" },
                    { new Guid("e8043642-e93c-4d2a-9494-db9e198357a4"), 2, null, true, "Siyaset", "siyaset" },
                    { new Guid("f50d9e1a-a0d3-46b9-b3c5-1772f22f4343"), 5, null, true, "Spor", "spor" }
                });

            migrationBuilder.InsertData(
                table: "RssSources",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "FeedUrl", "FetchIntervalMinutes", "IsActive", "LastFetchedAt", "Name", "ReliabilityScore" },
                values: new object[,]
                {
                    { new Guid("a1a1a1a1-a1a1-4a1a-a1a1-a1a1a1a1a1a1"), new Guid("07018177-3367-4835-9005-95079efa56b4"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://www.trthaber.com/manset_articles.rss", 60, true, null, "TRT Haber - Manşet", 9 },
                    { new Guid("b2b2b2b2-b2b2-4b2b-b2b2-b2b2b2b2b2b2"), new Guid("07018177-3367-4835-9005-95079efa56b4"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://www.aa.com.tr/tr/rss/default?cat=guncel", 60, true, null, "Anadolu Ajansı - Güncel", 10 },
                    { new Guid("c3c3c3c3-c3c3-4c3c-c3c3-c3c3c3c3c3c3"), new Guid("66085c66-e061-464a-a04b-f88e9164a4a7"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://www.bloomberght.com/rss", 60, true, null, "Bloomberg HT - Ekonomi", 8 },
                    { new Guid("d4d4d4d4-d4d4-4d4d-d4d4-d4d4d4d4d4d4"), new Guid("f50d9e1a-a0d3-46b9-b3c5-1772f22f4343"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://www.ntvspor.net/rss", 60, true, null, "NTV Spor - Genel", 8 },
                    { new Guid("e5e5e5e5-e5e5-4e5e-e5e5-e5e5e5e5e5e5"), new Guid("7f6e7977-1f93-4b07-a79b-89e9064b9521"), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://feeds.bbci.co.uk/turkce/rss.xml", 60, true, null, "BBC Türkçe - Dünya", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07018177-3367-4835-9005-95079efa56b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e6d0a92-6f7e-4644-8c9b-1b903e794432"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("66085c66-e061-464a-a04b-f88e9164a4a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f6e7977-1f93-4b07-a79b-89e9064b9521"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1781e83-9366-4af2-a1c8-17551d67b7a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7d397c1-e8d5-4f54-9430-80e800d309d5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e8043642-e93c-4d2a-9494-db9e198357a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f50d9e1a-a0d3-46b9-b3c5-1772f22f4343"));

            migrationBuilder.DeleteData(
                table: "RssSources",
                keyColumn: "Id",
                keyValue: new Guid("a1a1a1a1-a1a1-4a1a-a1a1-a1a1a1a1a1a1"));

            migrationBuilder.DeleteData(
                table: "RssSources",
                keyColumn: "Id",
                keyValue: new Guid("b2b2b2b2-b2b2-4b2b-b2b2-b2b2b2b2b2b2"));

            migrationBuilder.DeleteData(
                table: "RssSources",
                keyColumn: "Id",
                keyValue: new Guid("c3c3c3c3-c3c3-4c3c-c3c3-c3c3c3c3c3c3"));

            migrationBuilder.DeleteData(
                table: "RssSources",
                keyColumn: "Id",
                keyValue: new Guid("d4d4d4d4-d4d4-4d4d-d4d4-d4d4d4d4d4d4"));

            migrationBuilder.DeleteData(
                table: "RssSources",
                keyColumn: "Id",
                keyValue: new Guid("e5e5e5e5-e5e5-4e5e-e5e5-e5e5e5e5e5e5"));
        }
    }
}
