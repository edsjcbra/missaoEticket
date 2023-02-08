using FluentValidation.Results;
using Microsoft.AspNetCore.Routing.Matching;

namespace Eticket.Models.Error
{
    public static class ValidationFailureExtension
    {
        public static IList<CustomValidatorFailure> ToCustomValidatorFailure(this IList<ValidationFailure> failures)
        {
            return failures.Select(f => new CustomValidatorFailure(f.PropertyName, f.ErrorMessage)).ToList();
        }
    }
}
