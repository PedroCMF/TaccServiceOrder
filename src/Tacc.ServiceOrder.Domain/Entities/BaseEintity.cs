namespace Tacc.ServiceOrder.Domain.Entities;

public class BaseEintity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}