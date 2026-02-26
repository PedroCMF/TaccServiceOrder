namespace Tacc.ServiceOrder.Domain.Entities;

public class Product : BaseEintity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Manufacturing Manufacturing { get; set; }
    public int ManufacturingId { get; set; }

}
