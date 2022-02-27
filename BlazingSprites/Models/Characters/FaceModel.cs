namespace BlazingSprites.Models.Characters;

public enum BlushColor { None, Color1, Color2, Color3, Color4, Color5 };
public enum EyeColor { Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8, Color9, Color10, Color11, Color12, Color13, Color14 };
public enum LipColor { Color1, Color2, Color3, Color4, Color5 };

public class FaceModel
{
    public BlushColor BlushColor { get; set; }
    public EyeColor EyeColor { get; set; }
    public LipColor LipColor { get; set; }

    public FaceModel()
    {
    }

    public FaceModel(BlushColor blushColor, EyeColor eyeColor, LipColor lipColor)
    {
        BlushColor = blushColor;
        EyeColor = eyeColor;
        LipColor = lipColor;
    }
}
