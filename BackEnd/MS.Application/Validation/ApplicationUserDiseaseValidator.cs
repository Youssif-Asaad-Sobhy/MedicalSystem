using FluentValidation;
using MS.Data.Entities;

namespace MS.Application.Validation
{
    public class ApplicationUserDiseaseValidator : AbstractValidator<ApplicationUserDisease>
    {
        public ApplicationUserDiseaseValidator()
        {
            RuleFor(aud => aud.ID).NotEmpty().WithMessage("ID is required");
            RuleFor(au => au.Type).NotEmpty().WithMessage("Type is required");
            RuleFor(au => au.ValueResult).NotEmpty().WithMessage("ValueResult is required");
            RuleFor(au => au.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(au => au.Height).GreaterThanOrEqualTo(1).WithMessage("Height must be greater than or equal to 1");
            RuleFor(au => au.Weight).GreaterThanOrEqualTo(1).WithMessage("Weight must be greater than or equal to 1");
            RuleFor(au => au.ApplicationUserId).NotEmpty().WithMessage("ApplicationUserId is required");
            RuleFor(au => au.DiseaseId).NotEmpty().WithMessage("DiseaseId is required");
            RuleFor(au => au.Diagnosis).NotEmpty().WithMessage("Diagnosis is required");
            RuleFor(au => au.DiagnosisDate).NotEmpty().WithMessage("DiagnosisDate is required");
            RuleFor(aud => aud.Attachments).NotEmpty().WithMessage("Attachments are required");
        }       
    }           
}