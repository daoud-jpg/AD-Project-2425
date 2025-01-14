using ConcertTickets.Models;

namespace ConcertTickets.Services
{
    public interface IOrderService
    {
        int CreateOrder(OrderFormViewModel model);
        OrderViewModel GetOrderById(int orderId);
        IEnumerable<OrderViewModel> GetOrdersByStatus(bool paid);
        void UpdatePaid(int orderId, bool paid);
    }
}