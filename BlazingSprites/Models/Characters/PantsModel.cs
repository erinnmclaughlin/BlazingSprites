namespace BlazingSprites.Models.Characters;

public enum PantColor { Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Color9, Color10 };
public enum PantStyle { Pants, Pants_Suit, Skirt, None }

public class PantsModel
{
    public PantColor Color { get; set; }
    public PantStyle Style { get; set; }
}
