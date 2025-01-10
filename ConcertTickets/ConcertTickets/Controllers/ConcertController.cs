using ConcertTickets.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcertTickets.Controllers
{
    public class ConcertController : Controller
    {
        private IConcertService concertService;

        public ConcertController(IConcertService _concertService)
        {
            concertService = _concertService;
        }
        public IActionResult Index()
        {
            concertService.Get
            return View();
        }


    }
}
