using ConcertTickets.Data.Entities;
using ConcertTickets.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConcertTickets.Repositories
{
    public class ConcertRepository : Repository<Concert>, IConcertRepository
    {
        public ConcertRepository(ApplicationDbContext _context) : base(_context) { }

        public IEnumerable<Concert> GetConcertsWithTicketOffers()
        {
            //return context.Set<Concert>().Include(t => t.TicketOffer);
            return context.Set<Concert>().Include(t => t.TicketOffer);
        }

        public Concert GetConcertWithTicketOffers(int id)
        {
            return context.Set<Concert>().Where(c => c.Id == id).Include(c => c.TicketOffer).FirstOrDefault();
        }
    }
}
