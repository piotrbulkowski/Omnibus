namespace Omnibus.CQRS.Command
{
    /// <summary>
    /// Marker interface
    /// </summary>
    public interface ICommand
    {
    }
    public interface ICommand<out TResult>
    {

    }
}
