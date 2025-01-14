using ConcertTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.CodeAnalysis;
namespace ConcertTickets.Data
{
    public class CustomUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? MemberCardNumber { get; set; }

        private readonly bool hasMemberCard;
        public bool? HasMemberCard
        {
            get { return hasMemberCard; }
            set
            {
                if (MemberCardNumber != "")
                {
                    value = true;
                }
                else
                {
                    value = false;
                }
            }
        }
    }
}
