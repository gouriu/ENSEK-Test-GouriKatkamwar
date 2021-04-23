using FluentValidation.Validators;

namespace ENSEK.Common.Models.Validation
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FluentValidation;
    using FluentValidation.Results;

    internal class MeterReadValidator : IPropertyValidator
    {
        public IEnumerable<ValidationFailure> Validate(PropertyValidatorContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ValidationFailure>> ValidateAsync(PropertyValidatorContext context, CancellationToken cancellation)
        {
            throw new System.NotImplementedException();
        }

        public bool ShouldValidateAsynchronously(IValidationContext context)
        {
            throw new System.NotImplementedException();
        }

        public PropertyValidatorOptions Options { get; }
    }
}