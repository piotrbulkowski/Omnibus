using System.Threading.Tasks;

namespace Omnibus.CQRS.Query
{
    public interface IQueryDispatcher
    {
        Task<TResult> QueryAsync<TResult>(IQuery<TResult> query);
    }
}
