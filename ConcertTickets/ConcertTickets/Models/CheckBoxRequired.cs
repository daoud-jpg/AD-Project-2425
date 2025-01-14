using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Models
{
    public class CheckBoxRequired : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is bool boolenValue && boolenValue) 
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(ErrorMessage ?? "U moet akkoord gaan met de algemene voorwaarden");
        }
    }
}
