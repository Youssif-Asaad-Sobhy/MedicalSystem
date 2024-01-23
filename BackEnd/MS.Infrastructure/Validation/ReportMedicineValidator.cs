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
            RuleFor(rm => rm.ID).NotEmpty();
            
            RuleFor(rm => rm.ReportID).NotEmpty().WithMessage("ReportID is required.");

            RuleFor(rm => rm.MedID).NotEmpty().WithMessage("MedID is required.");
        }
    }
}