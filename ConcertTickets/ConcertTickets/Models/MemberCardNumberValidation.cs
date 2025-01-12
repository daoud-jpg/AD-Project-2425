using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Models
{
    public class MemberCardNumberValidation : ValidationAttribute
    {
        string requiredstartLetters = "ODI";
        string numbers = "1234567890";
        public string Template { get; set; }
        public MemberCardNumberValidation()
        {
            ErrorMessage = $"Vereiste lidnummer is niet correct (voorbeeld: ODI{requiredstartLetters}{numbers}";
        }

        public override bool IsValid(object value)
        {
            string userInput = (string)value;

            return userInput.Length == Template.Length && userInput.StartsWith(requiredstartLetters) && userInput.Contains(numbers);
        }
    }
}
