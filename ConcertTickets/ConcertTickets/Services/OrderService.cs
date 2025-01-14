using ConcertTickets.Data.Entities;
using ConcertTickets.Models;
using ConcertTickets.Repositories;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Identity.Client;

namespace ConcertTickets.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepo { get; set; }
        public OrderService(IOrderRepository _orderRepo)
        {
            orderRepo = _orderRepo;
        }

        public int CreateOrder(OrderFormViewModel model)
        {
            //Order toCreateOrder = new Order();
            //toCreateOrder = orderRepo.
            return 0;
        }

        public IEnumerable<OrderViewModel> GetOrdersByStatus(bool paid)
        {
            return null;
        }

        public OrderViewModel GetOrderById(int orderId)
        {
            return null;
        }

        public void UpdatePaid(int orderId, bool paid)
        {

        }
    }
}
