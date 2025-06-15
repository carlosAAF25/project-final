namespace Application.DTOs;

public class CreateReservationRequest
{
    public Guid SpaceId { get; set; }
    public Guid UserId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Purpose { get; set; }
}
