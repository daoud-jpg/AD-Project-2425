using System.ComponentModel.DataAnnotations;

namespace ConcertTickets.Models
{
    public class ConcertViewModel
    {
        public int Id { get; set; }
        public string ArtistPicture { get; set; }
        public string Artist { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }

    }
}
