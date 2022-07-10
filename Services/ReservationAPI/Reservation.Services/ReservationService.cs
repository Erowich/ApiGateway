using System;
using Reservation.Infrastructure;
using Reservation.Models;

namespace Reservation.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(50),
                Amount = (new Random().Next(50)),
                BkgDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37)
            };
        }
    }
}