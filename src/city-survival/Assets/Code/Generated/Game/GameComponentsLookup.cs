//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int Id = 0;
    public const int Test2 = 1;
    public const int Test = 2;
    public const int WorldPosition = 3;
    public const int Direction = 4;
    public const int Moving = 5;
    public const int Speed = 6;

    public const int TotalComponents = 7;

    public static readonly string[] componentNames = {
        "Id",
        "Test2",
        "Test",
        "WorldPosition",
        "Direction",
        "Moving",
        "Speed"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Code.Gameplay.Common.Id),
        typeof(Code.Gameplay.Common.Test2Component),
        typeof(Code.Gameplay.Common.TestComponent),
        typeof(Code.Gameplay.Common.WorldPosition),
        typeof(Code.Gameplay.Features.Movement.Direction),
        typeof(Code.Gameplay.Features.Movement.Moving),
        typeof(Code.Gameplay.Features.Movement.Speed)
    };
}
