using System.Threading.Tasks;

namespace Omnibus.CQRS.Query
{
    public interface IQueryHandler<in T, TResult> where T : IQuery<TResult>
    {
        Task<TResult> HandleAsync(T query);
    }
}
