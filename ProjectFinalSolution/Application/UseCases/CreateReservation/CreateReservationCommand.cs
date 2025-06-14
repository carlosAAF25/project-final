namespace Application.UseCases.CreateReservation;

public class CreateReservationCommand
{
    public Guid SpaceId { get; set; }
    public Guid UserId { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}
