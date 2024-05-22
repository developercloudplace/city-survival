//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTargetLimits;

    public static Entitas.IMatcher<GameEntity> TargetLimits {
        get {
            if (_matcherTargetLimits == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TargetLimits);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTargetLimits = matcher;
            }

            return _matcherTargetLimits;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.Armaments.TargetLimits targetLimits { get { return (Code.Gameplay.Features.Armaments.TargetLimits)GetComponent(GameComponentsLookup.TargetLimits); } }
    public int TargetLimits { get { return targetLimits.Value; } }
    public bool hasTargetLimits { get { return HasComponent(GameComponentsLookup.TargetLimits); } }

    public GameEntity AddTargetLimits(int newValue) {
        var index = GameComponentsLookup.TargetLimits;
        var component = (Code.Gameplay.Features.Armaments.TargetLimits)CreateComponent(index, typeof(Code.Gameplay.Features.Armaments.TargetLimits));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceTargetLimits(int newValue) {
        var index = GameComponentsLookup.TargetLimits;
        var component = (Code.Gameplay.Features.Armaments.TargetLimits)CreateComponent(index, typeof(Code.Gameplay.Features.Armaments.TargetLimits));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveTargetLimits() {
        RemoveComponent(GameComponentsLookup.TargetLimits);
        return this;
    }
}
