using System.ComponentModel.DataAnnotations;

namespace GaiaMare.Domain;

public class Inventory
{
    [Key]
    public int InventoryId { get; set; }
    public int ProductId { get; set; }
    public string SKU { get; set; } = string.Empty;
    public string Status { get; set; } = "In Stock";
    public string? Location { get; set; }
    public DateTime ArrivalDate { get; set; } = DateTime.Now;
}