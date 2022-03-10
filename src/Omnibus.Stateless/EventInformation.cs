namespace Omnibus.Stateless
{
    /// <summary>
    /// A container for eventId and additional argument
    /// </summary>
    /// <typeparam name="TEvent">Event type</typeparam>
    public class EventInformation<TEvent>
        where TEvent : IComparable
    {
        public TEvent EventId { get; }

        public object? EventArgument { get; }

        public EventInformation(TEvent eventId, object eventArgument)
        {
            EventId = eventId;
            EventArgument = eventArgument;
        }
    }
}
