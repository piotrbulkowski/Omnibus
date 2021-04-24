namespace Omnibus.CQRS
{
    // Marker interface
    public interface ICommand
    {
    }
    public interface ICommand<out TResult>
    {

    }
}
