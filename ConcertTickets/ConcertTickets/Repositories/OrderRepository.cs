using ConcertTickets.Data;
using ConcertTickets.Data.Entities;

namespace ConcertTickets.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext _context) : base(_context) { }

        //public Order GetOrderById(int id)
        //{
        //    return null;
        //}

        //public IEnumerable<Order> GetOrdersByStatus(bool paid)
        //{
        //    return null;
        //}
    }
}
