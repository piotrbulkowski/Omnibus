namespace Omnibus.CQRS.Query
{
    /// <summary>
    /// Marker interface
    /// </summary>
    public interface IQuery
    {
    }
    public interface IQuery<T> : IQuery
    {
    }
}
