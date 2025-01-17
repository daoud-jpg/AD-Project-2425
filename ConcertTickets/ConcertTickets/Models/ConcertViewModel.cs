using System.ComponentModel.DataAnnotations;
using ConcertTickets.Data.Entities;
namespace ConcertTickets.Models
{
    public class ConcertViewModel
    {
        public int Id { get; set; }
        public string ArtistPicture { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string MonthOfYear { get; set; }
        public int NumberOfTickets { get; set; }
        public ICollection<TicketOffer> TicketOffers { get; set; }
        
    }
}
