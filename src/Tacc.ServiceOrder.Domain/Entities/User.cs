namespace Tacc.ServiceOrder.Domain.Entities;

public abstract class User : BaseEintity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? IpAdress { get; set; } 
    public string? Phone { get; set; } 
    public string? ProfileImage { get; set; } 
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
