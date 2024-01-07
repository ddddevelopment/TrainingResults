using System.Linq.Expressions;
using TrainingResults.Core.Models;

namespace TrainingResults.Core.Abstractions.Repositories
{
    public interface IResultsRepository
    {
        Task<bool> Add(Result result);
        Task<Result> Get(Guid id);
        Task<IEnumerable<Result>> GetAll();
        Task<bool> Update<T>(Guid id, Expression<T> expression);
        Task<bool> Remove(Guid id);
    }
}
