using System.ComponentModel.DataAnnotations;

namespace Presentation.Data;

public class EventEntity
    {
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Titel { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; } = DateTime.UtcNow.AddDays(10);
    public string Location { get; set; } = null!;
    public string Price { get; set; } = null!;

    }