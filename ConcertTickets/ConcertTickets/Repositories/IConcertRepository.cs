using ConcertTickets.Data.Entities;

namespace ConcertTickets.Repositories
{
    public interface IConcertRepository
    {
        IEnumerable<Concert> GetConcertsWithTicketOffers();
        Concert GetConcertWithTicketOffers(int id);
    }
}