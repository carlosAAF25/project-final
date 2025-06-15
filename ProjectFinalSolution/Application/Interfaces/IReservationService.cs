using Application.DTOs;

namespace Application.Interfaces;

public interface IReservationService
{
    Task<Guid> CreateReservationAsync(CreateReservationRequest request);
}
