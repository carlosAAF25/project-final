using Domain.Entities;
using Domain.Interfaces;

namespace Application.UseCases.CreateReservation;

public class CreateReservationHandler
{
    private readonly IReservationRepository _repository;

    public CreateReservationHandler(IReservationRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateReservationCommand command)
    {
        var reservation = new Reservation
        {
            Id = Guid.NewGuid(),
            SpaceId = command.SpaceId,
            UserId = command.UserId,
            Date = command.Date,
            StartTime = command.StartTime,
            EndTime = command.EndTime
        };

        await _repository.AddAsync(reservation);
        return reservation.Id;
    }
}
