namespace FoodDeliveryAPI.Domain.Models;

public class Product
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required int CurrentPrice { get; set; }    
    public required int OldPrice { get; set; }
    public required string Category { get; set; }
    public required string ImageSrc { get; set; }
    public required string Description { get; set; }
}