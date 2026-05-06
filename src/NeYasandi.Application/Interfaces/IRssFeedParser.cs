using NeYasandi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Application.Interfaces
{
    public interface IRssFeedParser
    {
        Task<IEnumerable<RawNewsItem>> ParseAsync(string feedUrl, CancellationToken cancellationToken);
    }
}
