using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTickets.Data.Entities
{
    [Table("Concerts")]
    public class Concert : BaseEntity
    {
        public string Artist { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

        [NotMapped]
        public int TicketId { get; set; }
        public TicketOffer TicketOffer { get; set; }
    }
}
