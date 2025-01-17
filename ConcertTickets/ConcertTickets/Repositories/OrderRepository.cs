using ConcertTickets.Data;
using ConcertTickets.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcertTickets.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext _context) : base(_context) { }

        public Order GetOrderById(int id)
        {
            return context.Set<Order>().Include(t => t.TicketOffer).Where(c => c.Id == id).SingleOrDefault();
        }

        public IEnumerable<Order> GetOrdersByStatus(bool paid)
        {
            return null;
        }
    }
}
