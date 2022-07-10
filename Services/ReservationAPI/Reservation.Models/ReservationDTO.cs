using System;

namespace Reservation.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime? BkgDate { get; set; }
        public double Amount { get; set; }
    }
}