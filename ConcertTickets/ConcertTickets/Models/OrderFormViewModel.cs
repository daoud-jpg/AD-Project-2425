using ConcertTickets.Data.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConcertTickets.Models
{
    public class OrderFormViewModel
    {
        [Required]
        public int NumberOfSelectedTickets {  get; set; }
        [Required]
        public bool TermsAndConditions {  get; set; }

        [ValidateNever]
        public int TicketOfferId { get; set; }
        [ValidateNever]
        public string TicketType { get; set; }
        [ValidateNever]
        public double TicketPrice { get; set; }
        [ValidateNever]
        public bool HasMemberCard { get; set; }
        [ValidateNever]
        public int NumTickets { get; set; }
        [ValidateNever]
        public int ConcertId { get; set; }
        [ValidateNever]
        public ConcertViewModel ConcertCard {  get; set; }
        [ValidateNever]
        public int UserId { get; set; }
        [ValidateNever]
        public string UserName { get; set; }
    }
}
