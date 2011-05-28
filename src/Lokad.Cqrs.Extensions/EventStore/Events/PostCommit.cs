using System;

namespace Lokad.Cqrs.Extensions.EventStore.Events
{
    public class PostCommit : ISystemEvent
    {
        public PostCommit(Guid streamId, int streamRevision, int eventCount)
        {
            StreamId = streamId;
            StreamRevision = streamRevision;
            EventCount = eventCount;
        }

        public Guid StreamId { get; private set; }
        public int StreamRevision { get; private set; }
        public int EventCount { get; private set; }

        public override string ToString()
        {
            return string.Format("Committed event stream [{0}] rev {1}. [{2} events]", StreamId, StreamRevision,
                                 EventCount);
        }
    }
}