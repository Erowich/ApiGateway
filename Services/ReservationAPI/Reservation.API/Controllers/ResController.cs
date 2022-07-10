using Microsoft.AspNetCore.Mvc;
using Reservation.Infrastructure;
using Reservation.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : Controller
    {
        private readonly IReservationService _reservationService;

        public ResController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int id)
        {
            return  _reservationService.GetResByBkgNumber(id);
        }
    }
}