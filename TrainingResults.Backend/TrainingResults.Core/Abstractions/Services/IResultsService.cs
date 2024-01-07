using TrainingResults.Core.Models;

namespace TrainingResults.Core.Abstractions.Services
{
    public interface IResultsService
    {
        Task Create(Result result);
        Task<IEnumerable<Result>> GetAll();
        Task<Result> Get();
    }
}
