using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MS.Data.Entities;

namespace MS.Infrastructure.Validation
{
    public class ReportMedicineValidator : AbstractValidator<ReportMedicine>
    {
        public ReportMedicineValidator()
        {
            RuleFor(reportMedicine => reportMedicine.ID)
                .NotEmpty().WithMessage("ID is required")
                .GreaterThan(0).WithMessage("ID must be greater than 0");

            RuleFor(reportMedicine => reportMedicine.ReportID)
                .NotEmpty().WithMessage("ReportID is required")
                .GreaterThan(0).WithMessage("ReportID must be greater than 0");

            RuleFor(reportMedicine => reportMedicine.MedicineTypeID)
                .NotEmpty().WithMessage("MedicineTypeID is required")
                .GreaterThan(0).WithMessage("MedicineTypeID must be greater than 0");
        }
    }
}