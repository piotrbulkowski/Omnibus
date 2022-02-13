namespace Omnibus.CQRS.Command
{
    // Marker interface
    public interface ICommand
    {
    }
    public interface ICommand<out TResult>
    {

    }
}
