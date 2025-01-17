using ConcertTickets.Data;
using ConcertTickets.Models;
using ConcertTickets.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace ConcertTickets.Controllers
{
    public class OrderController : Controller
    {
        private ITicketOfferService ticketOfferService;
        private IOrderService orderService;
        private UserManager<CustomUser> userManager;
        private IConcertService concertService;

        public OrderController(ITicketOfferService _ticketOfferService, IOrderService _orderService, UserManager<CustomUser> _userManager, IConcertService _concertService)
        {
            ticketOfferService = _ticketOfferService;
            orderService = _orderService;
            userManager = _userManager;
            concertService = _concertService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Create(int id)
        {
            OrderFormViewModel model = ticketOfferService.GetTicketOfferForOrder(id);
            
            model.ConcertCard = concertService.GetConcertById(model.ConcertId);
            return View(model);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(OrderFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                model.UserId = userManager.GetUserAsync(User).Id;
                model.UserName = user.UserName;

                TicketOfferUpdateViewModel ticketOffer = new TicketOfferUpdateViewModel()
                {
                    TicketOfferId = ticketOfferService.GetTicketOfferForOrder(model.TicketOfferId).TicketOfferId,
                    NumOfOrderedTickets = model.NumberOfSelectedTickets
                };

                ticketOfferService.UpdateTicketOffer(ticketOffer);
                int id = orderService.CreateOrder(model);

                return RedirectToAction("Success", "Order", new { id = id });
            }
            return View(model);
        }   

        public IActionResult Success(int id)
        {
            OrderViewModel model = new OrderViewModel();
            model = orderService.GetOrderById(id);
            return View(model);
        }
    }   
}
