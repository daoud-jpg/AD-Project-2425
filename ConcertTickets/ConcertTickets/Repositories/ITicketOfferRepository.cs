using ConcertTickets.Data.Entities;

namespace ConcertTickets.Repositories
{
    public interface ITicketOfferRepository
    {
        TicketOffer GetTicketOfferById(int id);
    }
}