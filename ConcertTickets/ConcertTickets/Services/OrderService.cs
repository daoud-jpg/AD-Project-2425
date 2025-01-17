using ConcertTickets.Data.Entities;
using ConcertTickets.Models;
using ConcertTickets.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Identity.Client;

namespace ConcertTickets.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository orderRepo { get; set; }
        private IRepository<Order> repoOrder {  get; set; }
        public OrderService(IOrderRepository _orderRepo, IRepository<Order> _repoOrder)
        {
            orderRepo = _orderRepo;
            repoOrder = _repoOrder;
        }

        public int CreateOrder(OrderFormViewModel model)
        {
            Order toCreateOrder = new Order();
            if (model != null)
            {

                toCreateOrder.UserId = model.UserId;
                toCreateOrder.UserName = model.UserName;
                toCreateOrder.NumTickets = model.NumTickets;
                toCreateOrder.NumberOfSelectedTickets = model.NumberOfSelectedTickets;
                toCreateOrder.TotalPrice = model.TicketPrice * model.NumberOfSelectedTickets;
                toCreateOrder.Paid = false;
                toCreateOrder.TicketOfferId = model.TicketOfferId;

                repoOrder.Add(toCreateOrder);
                repoOrder.SaveChanges();
            }
            
            return model.Id;
        }

        public IEnumerable<OrderViewModel> GetOrdersByStatus(bool paid)
        {
            return null;
        }

        public OrderViewModel GetOrderById(int orderId)
        {
            Order getOrder = orderRepo.GetOrderById(orderId);
            OrderViewModel model = new OrderViewModel()
            {
                Id = getOrder.Id,
                Artist = getOrder.TicketOffer.Concert.Artist,
                Location = getOrder.TicketOffer.Concert.Location,
                Date = getOrder.TicketOffer.Concert.Date,
                TicketType = getOrder.TicketOffer.TicketType,
                NumberOfSelectedTickets = getOrder.NumberOfSelectedTickets,
                TotalPrice = getOrder.TotalPrice,
                Client = getOrder.UserName,
                Paid = false
            };
            return model;
        }

        public void UpdatePaid(int orderId, bool paid)
        {

        }
    }
}
