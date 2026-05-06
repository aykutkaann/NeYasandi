using System;
using System.Collections.Generic;
using System.Text;

namespace NeYasandi.Application.Events
{

    public record RawNewsItemsFetched(IReadOnlyList<Guid> NewsItemIds);
}
