using System.ComponentModel.DataAnnotations.Schema;

namespace ConcertTickets.Data.Entities
{
    [Table("Orders")]
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int NnumTickets { get; set; }
        public double TotalPrice { get; set; }
        public bool Paid { get; set; }
        public bool DiscountApplied { get; set; }
        
        //Relations
        public int TicketOfferId { get; set; }
        public TicketOffer TicketOffer { get; set; }
    }
}
