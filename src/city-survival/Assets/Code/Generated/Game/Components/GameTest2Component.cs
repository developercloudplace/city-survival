//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTest2;

    public static Entitas.IMatcher<GameEntity> Test2 {
        get {
            if (_matcherTest2 == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Test2);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTest2 = matcher;
            }

            return _matcherTest2;
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

    public Code.Gameplay.Common.Test2Component test2 { get { return (Code.Gameplay.Common.Test2Component)GetComponent(GameComponentsLookup.Test2); } }
    public UnityEngine.Vector3 Test2 { get { return test2.Value; } }
    public bool hasTest2 { get { return HasComponent(GameComponentsLookup.Test2); } }

    public GameEntity AddTest2(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.Test2;
        var component = (Code.Gameplay.Common.Test2Component)CreateComponent(index, typeof(Code.Gameplay.Common.Test2Component));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceTest2(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.Test2;
        var component = (Code.Gameplay.Common.Test2Component)CreateComponent(index, typeof(Code.Gameplay.Common.Test2Component));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveTest2() {
        RemoveComponent(GameComponentsLookup.Test2);
        return this;
    }
}