using Domain.Entities;

namespace Domain.Interfaces;

public interface IReservationRepository
{
    Task AddAsync(Reservation reservation);
}
