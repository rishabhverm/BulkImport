using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace Bulkimport.Bussiness.Validator
{
    public class importvalidator :AbstractValidator<ImportData>
    {
        public importvalidator() 
        {
            RuleFor(e => e.RecordId).NotEmpty().WithMessage("recordID is required");

                RuleFor(x => x.Email)
                 .NotEmpty().WithMessage("Email is required")
                   .EmailAddress().WithMessage("Invalid email format")
                    .MaximumLength(100).WithMessage("Email cannot exceed 100 characters");

            RuleFor(x => x.Amount)
            .NotEmpty().WithMessage("amount is required.").GreaterThanOrEqualTo(0).WithMessage("amount must not be in negitive value");

            RuleFor(x => x.TransactionDate)
                .NotEmpty().WithMessage("Date is required.")
                .Must(BeValidDate).WithMessage("Date must be in the format dd/MM/yyyy.");

        }

        private bool BeValidDate(string date)
        {
            return DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
    }
}
