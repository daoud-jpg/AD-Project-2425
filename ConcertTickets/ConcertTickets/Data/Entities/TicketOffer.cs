using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTickets.Data.Entities
{
    [Table("TicketOffers")]
    public class TicketOffer : BaseEntity
    {
        public string TicketType { get; set; }
        public int NumTickets { get; set; }
        public double Price { get; set; }

        //Relations
        public int ConcertId { get; set; }
        [NotMapped]
        public Concert Concert { get; set; }
    }
}
