using BlazingSprites.Models.Characters;

namespace BlazingSprites.Components;

public partial class CharacterCreator
{
    private CharacterModel Model { get; set; } = new();

    void UpdateHair(HairStyle? style)
    {
        if (style == null)
        {
            Model.Hair = null;
            return;
        }

        if (Model.Hair == null)
            Model.Hair = new();

        Model.Hair.Style = style.Value;
    }
}
