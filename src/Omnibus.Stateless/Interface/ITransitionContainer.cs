using Omnibus.Stateless.Interface;

namespace Omnibus.Stateless
{
    /// <summary>
    /// Contains transition context information.
    /// </summary>
    /// <typeparam name="TState">State type.</typeparam>
    /// <typeparam name="TEvent">Event type.</typeparam>
    public interface ITransitionContainer<TState, TEvent>
        where TState : IComparable
        where TEvent : IComparable
    {
        /// <summary>
        /// Currently transited event
        /// </summary>
        EventInformation<TEvent> Event { get; }
        public INotifier<TState, TEvent> Notifier { get; }
    }
}
