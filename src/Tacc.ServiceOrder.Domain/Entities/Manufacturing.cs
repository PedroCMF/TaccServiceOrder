namespace Tacc.ServiceOrder.Domain.Entities;

public class Manufacturing : BaseEintity
{
    public string Name { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public IEnumerable<Product> Producst { get; set; }
}