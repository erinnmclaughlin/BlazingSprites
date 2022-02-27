namespace BlazingSprites.Models;

public class CharacterModel
{
    public Direction Direction { get; set; } = Direction.Down;

    public BlushColor BlushColor { get; set; }
    public EyeColor EyeColor { get; set; }
    public SkinColor SkinColor { get; set; }
    public HairColor HairColor { get; set; }
    public HairStyle HairStyle { get; set; } = HairStyle.Bob;
    public LipColor LipColor { get; set; }

    public ClothesColor ShirtColor { get; set; }
    public ShirtStyle ShirtStyle { get; set; }

    public ClothesColor PantColor { get; set; }
    public PantStyle PantStyle { get; set; }

    public ClothesColor ShoeColor { get; set; }
    public ShoeStyle ShoeStyle { get; set; }
}
