using Omnibus.Stateless.Interface;

namespace Omnibus.Stateless
{
    /// <summary>
    /// A basic implementation of a passive state machine
    /// </summary>
    /// <typeparam name="TState">The state type</typeparam>
    /// <typeparam name="TEvent">The event type</typeparam>
    public partial class StateMachine<TState, TEvent>
        where TState : IComparable
        where TEvent : IComparable
    {
        private readonly StateContainer<TState, TEvent> _stateContainer;

        private bool IsExecuting = false;

        public StateMachine(StateContainer<TState, TEvent> stateContainer)
        {
            _stateContainer = stateContainer;
        }

        /// <summary>
        /// Fires the specified event on the queue.
        /// </summary>
        public void Fire(TEvent eventId)
        {
            Fire(eventId, null);
        }

        /// <summary>
        /// Fires the specified event on the queue.
        /// </summary>
        /// <param name="eventId">The event id.</param>
        /// <param name="eventArgument">Additional event argument.</param>
        public void Fire(TEvent eventId, object eventArgument)
        {
            _stateContainer.Events.Enqueue(new EventInformation<TEvent>(eventId, eventArgument));

            Execute();
        }

        /// <summary>
        /// Executes all the events in the queue.
        /// </summary>
        private void Execute()
        {
            if (IsExecuting)
            {
                return;
            }

            IsExecuting = true;
            try
            {
                ProcessEvents();
            }
            finally
            {
                IsExecuting = false;
            }
        }

        /// <summary>
        /// Processes all queued events on the state machine.
        /// </summary>
        private void ProcessEvents()
        {
            while (_stateContainer.Events.Count > 0)
            {
                throw new NotImplementedException();
            }
        }
        /// <summary>
        /// Happens when transitin begins, fired by OnTransitionBegin.
        /// </summary>
        public event EventHandler<TState> TransitionBegin;

        /// <summary>
        /// Happens when transitin begins, fired by OnTransitionEnd.
        /// </summary>
        public event EventHandler<TState> TransitionCompleted;


        public void OnTransitionBegin(ITransitionContainer<TState, TEvent> transition)
        {
            throw new NotImplementedException();
        }

        private void OnTransitionCompleted(ITransitionContainer<TState, TEvent> transition, TState currentStateId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A simple event raiser with exception handling.
        /// </summary>
        /// <typeparam name="T">Event arguments.</typeparam>
        private void RaiseEvent<T>(EventHandler<T> eventHandler, ITransitionContainer<TState, TEvent> transition, bool isRaiseEventOnException = false)
            where T : EventArgs
        {
            try
            {
                if (eventHandler is null)
                {
                    return;
                }
                throw new NotImplementedException();
                //eventHandler(this, transition.Event);
            }
            catch(Exception ex)
            {
                if (!isRaiseEventOnException)
                {
                    throw;
                }

                ((INotifier<TState, TEvent>)this).OnExceptionThrown(transition, ex);
            }
        }
    }
}
