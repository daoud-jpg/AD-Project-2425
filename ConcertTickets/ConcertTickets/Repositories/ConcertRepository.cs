using ConcertTickets.Data.Entities;
using ConcertTickets.Data;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Repositories
{
    public class ConcertRepository : Repository<Concert>, IConcertRepository
    {
        public ConcertRepository(ApplicationDbContext _context) : base(_context) { }

        public IEnumerable<Concert> GetConcertsWithTicketOffers()
        {
            return context.Set<Concert>().Include(t => t.TicketOffer);
        }

        //public Concert GetConcertWithTicketOffers(int id)
        //{
        //    //return context.Set<Concert>().Include(x => x.TicketOffer);

        //}
    }
}
