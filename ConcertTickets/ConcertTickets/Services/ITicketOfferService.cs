using ConcertTickets.Models;

namespace ConcertTickets.Services
{
    public interface ITicketOfferService
    {
        OrderFormViewModel GetTicketOfferForOrder(int id);
        void UpdateTicketOffer(TicketOfferUpdateViewModel model);
    }
}