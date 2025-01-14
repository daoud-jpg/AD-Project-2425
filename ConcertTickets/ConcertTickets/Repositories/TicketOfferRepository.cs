using ConcertTickets.Data;
using ConcertTickets.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Repositories
{
    public class TicketOfferRepository : Repository<TicketOffer>, ITicketOfferRepository
    {
        public TicketOfferRepository(ApplicationDbContext _context) : base(_context) { }

        public TicketOffer GetTicketOfferById(int id)
        {
            return context.Set<TicketOffer>().Include(c => c.Concert).Where(c => c.Id == id).SingleOrDefault();
        }
    }
}
