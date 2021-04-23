using System;
using AutoFixture;
using Xunit;
using FluentValidation.TestHelper;

namespace ENSEK.Common.Tests.Models.Validations
{
    using ENSEK.Common.Models;
    using ENSEK.Common.Models.Validation;

    public class MeterReadingModelValidatorTests
    {
        private readonly MeterReadingModelValidator _validator = new MeterReadingModelValidator();
        private readonly Fixture _fixture = new Fixture();
        
        [Fact]
        public void Validate_WhenValidData_ReturnsNoValidationError()
        {
            // arrange
           var sut= _fixture.Build<MeterReadingModel>()
                .With(e => e.MeterReadValue, "11111")
                .Create();

            // act
            var validationResult =_validator.Validate(sut);

            // assert
            Assert.True(validationResult.IsValid);

        }

        [Theory]
        [InlineData("111")]
        [InlineData("Void")]
        [InlineData("-111")]
        [InlineData("0")]
        public void Validate_WhenInValidData_ReturnsNoValidationError(string readingValue)
        {
            // arrange
            var sut = _fixture.Build<MeterReadingModel>()
                .With(e => e.AccountId, 0)
                .With(e => e.MeterReadingDateTime, DateTime.MinValue)
                .With(e => e.MeterReadValue, readingValue)
                .Create();

            // act
            var validationResult = _validator.TestValidate(sut);

            // assert
            validationResult.ShouldHaveValidationErrorFor(a => a.AccountId);
            validationResult.ShouldHaveValidationErrorFor(a => a.MeterReadingDateTime);
            validationResult.ShouldHaveValidationErrorFor(a => a.MeterReadValue);
        }
    }
}
