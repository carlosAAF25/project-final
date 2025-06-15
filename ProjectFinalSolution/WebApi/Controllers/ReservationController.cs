using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationController : ControllerBase
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateReservationRequest request)
    {
        var reservationId = await _reservationService.CreateReservationAsync(request);
        return CreatedAtAction(
            nameof(GetById),
            new { id = reservationId },
            new { Id = reservationId }
        );
    }

    // Endpoint dummy para que CreatedAtAction funcione sin error (opcional si no lo usarás por ahora)
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        return Ok(); // Lo puedes implementar después
    }
}
