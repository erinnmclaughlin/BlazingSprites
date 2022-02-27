namespace BlazingSprites.Models.Characters;

public enum HairColor { Black, Blonde, Brown, LightBrown, Copper, Emerald, Green, Grey, Lilac, Navy, Pink, Purple, Red, Turquoise }
public enum HairStyle { Bob, Braids, Buzzcut, Curly, Emo, Extra_Long, French_Curl, Gentleman, Long_Straight, Midiwave, Ponytail, Spacebuns, Wavy, None }

public class HairModel
{
    public HairColor Color { get; set; }
    public HairStyle Style { get; set; }

    public HairModel()
    {
    }

    public HairModel(HairColor color)
    {
        Color = color;
    }

    public HairModel(HairStyle style)
    {
        Style = style;
    }

    public HairModel(HairColor color, HairStyle style)
    {
        Color = color;
        Style = style;
    }
}
