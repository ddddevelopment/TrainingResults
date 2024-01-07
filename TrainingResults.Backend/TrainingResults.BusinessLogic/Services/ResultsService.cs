using TrainingResults.Core.Abstractions.Repositories;
using TrainingResults.Core.Abstractions.Services;
using TrainingResults.Core.Models;

namespace TrainingResults.BusinessLogic.Services
{
    public class ResultsService : IResultsService
    {
        private readonly IResultsRepository _repository;

        public ResultsService(IResultsRepository repository)
        {
            _repository = repository;
        }

        public async Task Create(Result result)
        {
            await _repository.Add();
        }

        public async Task<IEnumerable<Result>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Result> Get()
        {
            return await _repository.Get();
        }

        public async Task Update()
        {
            await _repository.Update();
        }

        public async Task Delete()
        {
            await _repository.Remove();
        }
    }
}
