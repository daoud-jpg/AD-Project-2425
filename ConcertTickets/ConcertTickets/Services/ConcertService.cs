using ConcertTickets.Data.Entities;
using ConcertTickets.Models;

namespace ConcertTickets.Services
{
    public class ConcertService : IConcertService
    {
        private IRepository<Concert> concertRepo;
        private IWebHostEnvironment webHostEnvironment;

        public ConcertService(IRepository<Concert> _concertRepo, IWebHostEnvironment _webHostEnvironment)
        {
            concertRepo = _concertRepo;
            webHostEnvironment = _webHostEnvironment;
        }

        public IEnumerable<ConcertViewModel> GetAllConcerts()
        {
            IEnumerable<ConcertViewModel> concertsIndex =  concertRepo.GetAll().Select(
                c => new ConcertViewModel()
                {
                    Id = c.Id,
                    Artist = c.Artist,
                    Location = c.Location,
                    Date = c.Date,
                    ArtistPicture = $"/img/{c.Artist}"
                });

            return concertsIndex;
        }
    }
}
