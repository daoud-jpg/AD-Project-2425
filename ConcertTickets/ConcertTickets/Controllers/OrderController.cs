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
            var user = await userManager.GetUserAsync(User);
            OrderFormViewModel model = ticketOfferService.GetTicketOfferForOrder(id);
            model.UserId = userManager.GetUserAsync(User).Id;
            model.UserName = user.UserName;
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
                int id = orderService.CreateOrder(model);
                TicketOfferUpdateViewModel ticketOffer = new TicketOfferUpdateViewModel()
                {
                    TicketOfferId = ticketOfferService.GetTicketOfferForOrder(model.TicketOfferId).TicketOfferId,
                    NumOfOrderedTickets = model.NumberOfSelectedTickets
                };
                ticketOfferService.UpdateTicketOffer(ticketOffer);
                return RedirectToAction("Index", "Concert");
            }
            return View(model);
        }   
    }   
}
