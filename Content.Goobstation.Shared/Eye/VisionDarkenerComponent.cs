using Robust.Shared.GameStates;

namespace Content.Goobstation.Shared.Eye;

/// <summary>
/// Piece of gear that darkens the user vision
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(VisionDarkenerSystem))]
public sealed partial class VisionDarkenerComponent : Component
{
    [DataField, AutoNetworkedField]
    public float Strength = 0;
}
