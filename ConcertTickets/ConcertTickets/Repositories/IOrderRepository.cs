using ConcertTickets.Data.Entities;

namespace ConcertTickets.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrderById(int id);
        IEnumerable<Order> GetOrdersByStatus(bool paid);
    }
}