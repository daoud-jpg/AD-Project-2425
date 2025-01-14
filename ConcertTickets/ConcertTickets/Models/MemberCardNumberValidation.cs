using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ConcertTickets.Models
{
    public class MemberCardNumberValidation : ValidationAttribute
    {
        private readonly string voorbeeld;
        public MemberCardNumberValidation(string _voorbeeld)
        {
            voorbeeld = _voorbeeld;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string userInput = (string)value;
            if (userInput.Contains("A"))
            {
                return ValidationResult.Success;

            }
            return new ValidationResult(ErrorMessage ?? $"Vereiste lidnummer is niet correct (voorbeeld: ODI{voorbeeld}");

        }
    }
}
