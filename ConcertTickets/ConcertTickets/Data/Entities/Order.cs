using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTickets.Data.Entities
{
    [Table("Orders")]
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int NumTickets { get; set; }
        public double TotalPrice { get; set; }
        public bool Paid { get; set; }
        [NotMapped]
        public bool DiscountApplied { get; set; }
        [NotMapped]
        public int NumberOfSelectedTickets { get; set; }

        //Relations
        [ForeignKey("TicketOffer")]
        public int TicketOfferId { get; set; }
        public TicketOffer TicketOffer { get; set; }
    }
}
