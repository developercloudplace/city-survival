//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAxisInput;

    public static Entitas.IMatcher<GameEntity> AxisInput {
        get {
            if (_matcherAxisInput == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AxisInput);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAxisInput = matcher;
            }

            return _matcherAxisInput;
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

    public Code.Gameplay.Input.System.AxisInput axisInput { get { return (Code.Gameplay.Input.System.AxisInput)GetComponent(GameComponentsLookup.AxisInput); } }
    public UnityEngine.Vector3 AxisInput { get { return axisInput.Value; } }
    public bool hasAxisInput { get { return HasComponent(GameComponentsLookup.AxisInput); } }

    public GameEntity AddAxisInput(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.AxisInput;
        var component = (Code.Gameplay.Input.System.AxisInput)CreateComponent(index, typeof(Code.Gameplay.Input.System.AxisInput));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceAxisInput(UnityEngine.Vector3 newValue) {
        var index = GameComponentsLookup.AxisInput;
        var component = (Code.Gameplay.Input.System.AxisInput)CreateComponent(index, typeof(Code.Gameplay.Input.System.AxisInput));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveAxisInput() {
        RemoveComponent(GameComponentsLookup.AxisInput);
        return this;
    }
}
