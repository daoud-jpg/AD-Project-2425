using ConcertTickets.Models;

namespace ConcertTickets.Services
{
    public interface IConcertService
    {
        IEnumerable<ConcertViewModel> GetAllConcerts();
        ConcertViewModel GetConcertById(int id);
        string GetNameOfMonth(int givenMonth);
    }
}