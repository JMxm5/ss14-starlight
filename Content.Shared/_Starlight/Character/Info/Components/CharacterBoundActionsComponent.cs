using Content.Shared.GameTicking;
using Robust.Shared.GameStates;

namespace Content.Shared._Starlight.Character.Info.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState, Access(typeof(SharedGameTicker), typeof(SLSharedCharacterInfoSystem))]
public sealed partial class CharacterBoundActionsComponent : Component
{
    [DataField, AutoNetworkedField]
    public string[] Emotes { get; set; } = [];
}
