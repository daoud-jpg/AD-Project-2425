using ConcertTickets.Models;
using ConcertTickets.Repositories;

namespace ConcertTickets.Services
{
    public class TicketOfferService
    {
        ITicketOfferRepository ticketOfferRepository;
        public TicketOfferService(ITicketOfferRepository _ticketOfferRepository)
        {
            ticketOfferRepository = _ticketOfferRepository;
        }
        //public OrderFormViewModel GetTicketOfferForOrder(int id, bool hasMemberCard)
        //{
        //    return hasMemberCard == true ? ticketOfferRepository.
        //}
    }
}
