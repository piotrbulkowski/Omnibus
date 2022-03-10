namespace Omnibus.Stateless
{
    /// <summary>
    /// Contains all mutable states of the current state machine.
    /// </summary>
    public class StateContainer<TState, TEvent>
        where TState : IComparable
        where TEvent : IComparable
    {
        public Queue<EventInformation<TEvent>> Events { get; set; } = new Queue<EventInformation<TEvent>>();
    }
}
