using ConcertTickets.Data.Entities;
using ConcertTickets.Models;
using ConcertTickets.Repositories;

namespace ConcertTickets.Services
{
    public class ConcertService : IConcertService
    {
        private IConcertRepository concertRepo;

        public ConcertService(IConcertRepository _concertRepo)
        {
            concertRepo = _concertRepo;
        }
        public IEnumerable<ConcertViewModel> GetAllConcerts()
        {
            IEnumerable<ConcertViewModel> concertModels = concertRepo.GetConcertsWithTicketOffers().Select(c => new ConcertViewModel
            {
                Id = c.Id,
                Artist = c.Artist,
                Location = c.Location,
                Date = c.Date,
                ArtistPicture = c.Artist,
                NumberOfTickets = c.TicketOffers.Select(t => t.NumTickets).Sum()
            });

            return concertModels;
        }

        public ConcertViewModel GetConcertById(int id)
        {
            Concert concert = concertRepo.GetConcertWithTicketOffers(id);
            ConcertViewModel model = new ConcertViewModel()
            {
                Id = concert.Id,
                Artist = concert.Artist,
                Location = concert.Location,
                Date = concert.Date,
                ArtistPicture = concert.Artist,
                TicketOffers = concert.TicketOffers
            };

            return model;
        }
    }
}
