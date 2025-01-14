using ConcertTickets.Data.Entities;
using ConcertTickets.Models;
using ConcertTickets.Repositories;

namespace ConcertTickets.Services
{
    public class TicketOfferService : ITicketOfferService
    {
        private ITicketOfferRepository ticketOfferRepository;
        private IRepository<TicketOffer> repoTicketOffer;
        public TicketOfferService(ITicketOfferRepository _ticketOfferRepository, IRepository<TicketOffer> _repoTicketOffer)
        {
            ticketOfferRepository = _ticketOfferRepository;
            repoTicketOffer = _repoTicketOffer;
        }
        public OrderFormViewModel GetTicketOfferForOrder(int id)
        {
            TicketOffer ticketOffer = ticketOfferRepository.GetTicketOfferById(id);

            OrderFormViewModel model = new OrderFormViewModel()
            {
                TicketType = ticketOffer.TicketType,
                TicketPrice = ticketOffer.Price,
                NumTickets = ticketOffer.NumTickets,
                TicketOfferId = ticketOffer.Id
            };
            return model;
        }

        public void UpdateTicketOffer(TicketOfferUpdateViewModel model)
        {
            TicketOffer getTicketOffer = new TicketOffer();
            getTicketOffer = ticketOfferRepository.GetTicketOfferById(model.TicketOfferId);
            int rr = getTicketOffer.NumTickets;
            rr = getTicketOffer.NumTickets - model.NumOfOrderedTickets;
            getTicketOffer.NumTickets = rr;
            repoTicketOffer.Update(getTicketOffer);
            repoTicketOffer.SaveChanges();
        }
    }
}
