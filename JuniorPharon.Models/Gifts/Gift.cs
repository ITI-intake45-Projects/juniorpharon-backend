using JuniorPharon.Models;

public class Gift
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public virtual Product Product { get; set; }

    public int? TripId { get; set; }
    public virtual Trip? Trip { get; set; }

    public int? PackageId { get; set; }
    public virtual Package? Package { get; set; }

    public int Quantity { get; set; } = 1;

    public bool IsActive { get; set; } = true;
}