using Humanizer;
using System.Transactions;

namespace ConcertTickets.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Artist {  get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string TicketType { get; set; }
        public int NumberOfSelectedTickets { get; set; }
        public double TotalPrice { get; set; }
        public string Client {  get; set; }
        public bool Paid { get; set; }

    }
}
