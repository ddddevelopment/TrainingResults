using System.Linq.Expressions;
using TrainingResults.Core.Abstractions.Repositories;
using TrainingResults.Core.Models;

namespace TrainingResults.DAL.Repositories
{
    public class ResultsRepository : IResultsRepository
    {
        private readonly DbContext
 

        public Task<bool> Add(Result result)
        {
            throw new NotImplementedException();
        }

        public Task<Result> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Result>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update<T>(Guid id, Expression<T> expression)
        {
            throw new NotImplementedException();
        }
    }
}
