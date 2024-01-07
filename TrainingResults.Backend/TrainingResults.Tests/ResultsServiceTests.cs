using Moq;
using AutoFixture;
using TrainingResults.Core.Abstractions.Repositories;
using TrainingResults.BusinessLogic.Services;
using TrainingResults.Core.Models;

namespace TrainingResults.Tests
{
    public class ResultsServiceTests
    {
        private static Fixture _fixture;
        private Result _result;
        private Mock<IResultsRepository> _repositoryMock;
        private ResultsService _service;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _repositoryMock = new Mock<IResultsRepository>();
            _service = new ResultsService(_repositoryMock.Object);
        }

        [Test]
        public async Task Create_ValidResult_ShouldCreateResult()
        {
            //arrange
            _result = _fixture.Build<Result>().Create();

            //act
            await _service.Create(_result);

            //assert
            _repositoryMock.Verify(x => x.Add(_result), Times.Once);
        }

        [Test]
        public async Task Create_InvalidResult_ShouldThrowException()
        {
            //arrange
            _result = _fixture.Build<Result>().Without(x => x.Exercise).Create();

            //act
            Assert.Throws<ArgumentException>(async () => await _service.Create(_result));
        }
    }
}
