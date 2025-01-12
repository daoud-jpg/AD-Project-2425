﻿using ConcertTickets.Data.Entities;
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
                ArtistPicture = c.Artist
            });

            return concertModels;
        }

        //public ConcertViewModel GetConcertById(int id)
        //{
        //    Concert concert = concertRepo.GetById(id);
        //    ConcertViewModel model = new ConcertViewModel()
        //    {
        //        Id = id,
        //        Artist = concert.Artist,
        //        Location = concert.Location,
        //        Date = concert.Date,
        //        ArtistPicture = $"/img/{concert.Artist}"
        //    };

        //    return model;
        //}
    }
}
