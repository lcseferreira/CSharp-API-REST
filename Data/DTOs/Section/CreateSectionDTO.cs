namespace REST_API.Data;

public class CreateSectionDTO
{
    public int MovieTheaterId { get; set; }
    public int MovieId { get; set; }
    public DateTime EndSection { get; set; }
}