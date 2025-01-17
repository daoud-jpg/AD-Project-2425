using ConcertTickets.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using ConcertTickets.Models;

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
            IEnumerable<ConcertViewModel> concertOverzicht = concertService.GetAllConcerts();
            return View(concertOverzicht);
        }

        public IActionResult Buy(int id)
        {
            ConcertViewModel model = concertService.GetConcertById(id);
            return View(model);
        }

     

    }
}
