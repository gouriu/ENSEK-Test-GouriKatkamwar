namespace ENSEK.Common.Models.Validation
{
    using FluentValidation;

    public class MeterReadingModelValidator : AbstractValidator<MeterReadingModel>
    {
        public MeterReadingModelValidator()
        {
            RuleFor(a => a.AccountId).NotEmpty();
            RuleFor(a => a.MeterReadingDateTime).NotEmpty();
            RuleFor(a => a.MeterReadValue).Custom((reading, context) => {
                if (!int.TryParse(reading, out int result))
                {
                    context.AddFailure("The reading value in wrong format. It's not a number.");
                }
                if (result < 0)
                {
                    context.AddFailure("The reading value is less than 0.");
                }
                if (reading.Length != 5)
                {
                    context.AddFailure("The reading value should contain 5 digits"); // as per AC Reading values should be in format NNNNN.
                }
            });
        }
    }
}
