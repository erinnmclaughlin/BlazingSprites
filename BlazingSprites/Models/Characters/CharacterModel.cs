namespace BlazingSprites.Models.Characters;

public class CharacterModel
{
    public CharacterAnimation Animation { get; set; }
    public Direction Direction { get; set; } = Direction.Right;
    public FaceModel Face { get; set; } = new FaceModel();
    public HairModel Hair { get; set; } = new HairModel();


    public SkinColor SkinColor { get; set; }

    public ClothesColor ShirtColor { get; set; }
    public ShirtStyle ShirtStyle { get; set; }

    public ClothesColor PantColor { get; set; }
    public PantStyle PantStyle { get; set; }

    public ClothesColor ShoeColor { get; set; }
    public ShoeStyle ShoeStyle { get; set; }
}
