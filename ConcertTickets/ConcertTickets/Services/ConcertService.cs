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
                MonthOfYear = GetNameOfMonth(c.Date.Month),
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
                TicketOffers = concert.TicketOffers,
                MonthOfYear = GetNameOfMonth(concert.Date.Month)
            };

            return model;
        }

        public string GetNameOfMonth(int givenMonth)
        {
            string month = "";
            switch (givenMonth)
            {
                case 1:
                    month = "JNY";
                    break;
                case 2:
                    month = "FEB";
                    break;
                case 3:
                    month = "MRT";
                    break;
                case 4:
                    month = "APL";
                    break;
                case 5:
                    month = "MAY";
                    break;
                case 6:
                    month = "JUN";
                    break;
                case 7:
                    month = "JUL";
                    break;
                case 8:
                    month = "AUG";
                    break;
                case 9:
                    month = "SEP";
                    break;
                case 10:
                    month = "OCT";
                    break;
                case 11:
                    month = "NOV";
                    break;
                case 12:
                    month = "DEC";
                    break;
                default:
                    break;
            }
            return month;
        }
    }
}
