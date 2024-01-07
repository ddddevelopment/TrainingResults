using FluentValidation;
using TrainingResults.Core.Models;

namespace TrainingResults.BusinessLogic.Validators
{
    public class ResultsValidator : AbstractValidator<Result>
    {
        public ResultsValidator()
        {
            RuleFor(x => x.Exercise).NotEmpty();
            RuleFor(x => x.NumberOfRepetition).GreaterThanOrEqualTo(0).NotEmpty();
            RuleFor(x => x.Weight).GreaterThanOrEqualTo(0).NotEmpty();
        }
    }
}