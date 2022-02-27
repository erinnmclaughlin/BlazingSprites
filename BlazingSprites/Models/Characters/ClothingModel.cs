namespace BlazingSprites.Models.Characters;

public class ClothingModel
{
    public ShirtModel Shirt { get; set; } = new();
    public PantsModel Pants { get; set; } = new();
    public ShoesModel Shoes { get; set; } = new();
}
