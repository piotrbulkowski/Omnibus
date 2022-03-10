using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnibus.Stateless.Interface
{
    /// <summary>
    /// Notifies events.
    /// </summary>
    /// <typeparam name="TState">State type.</typeparam>
    /// <typeparam name="TEvent">Event type.</typeparam>
    public interface INotifier<TState, TEvent>
        where TState : IComparable
        where TEvent : IComparable
    {
        /// <summary>
        /// Called when an exception was thrown.
        /// </summary>
        /// <param name="transition">The transition and its context.</param>
        /// <param name="ex">The exception.</param>
        void OnExceptionThrown(ITransitionContainer<TState, TEvent> transition, Exception ex);

        /// <summary>
        /// Called before a transition is executed.
        /// </summary>
        /// <param name="transition">The transition and its context.</param>
        void OnTransitionBegin(ITransitionContainer<TState, TEvent> transition);
    }
}
