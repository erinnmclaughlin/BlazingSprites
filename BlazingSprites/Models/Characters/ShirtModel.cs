namespace BlazingSprites.Models.Characters;

public enum ShirtColor { Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Color9, Color10 };
public enum ShirtStyle { Basic, Dress, Floral, Overalls, Sailor, Sailor_Bow, Skull, Spaghetti, Sporty, Stripe, Suit, None }

public class ShirtModel
{
    public ShirtColor Color { get; set; }
    public ShirtStyle Style { get; set; }
}
