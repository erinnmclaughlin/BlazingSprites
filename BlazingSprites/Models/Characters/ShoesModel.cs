namespace BlazingSprites.Models.Characters;

public enum ShoeColor { Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Color9, Color10 };
public enum ShoeStyle { Basic, None }

public class ShoesModel
{
    public ShoeColor Color { get; set; }
    public ShoeStyle Style { get; set; }
}
