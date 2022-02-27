namespace BlazingSprites.Models.Characters;

public class CharacterModel
{
    public CharacterAnimation Animation { get; set; }
    public Direction Direction { get; set; } = Direction.Right;
    public SkinColor SkinColor { get; set; }

    public FaceModel Face { get; set; } = new FaceModel();
    public HairModel Hair { get; set; } = new HairModel();
    public ClothingModel Clothing { get; set; } = new ClothingModel();

    public bool HasHair => Hair.Style != HairStyle.None;
    public bool HasShirt => Clothing.Shirt.Style != ShirtStyle.None;
    public bool HasPants => Clothing.Pants.Style != PantStyle.None;
    public bool HasShoes => Clothing.Shoes.Style != ShoeStyle.None;
}
