//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherViewPrefab;

    public static Entitas.IMatcher<GameEntity> ViewPrefab {
        get {
            if (_matcherViewPrefab == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ViewPrefab);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherViewPrefab = matcher;
            }

            return _matcherViewPrefab;
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

    public Code.Common.ViewPrefab viewPrefab { get { return (Code.Common.ViewPrefab)GetComponent(GameComponentsLookup.ViewPrefab); } }
    public Code.Infrastructure.View.EntityBehavior ViewPrefab { get { return viewPrefab.Value; } }
    public bool hasViewPrefab { get { return HasComponent(GameComponentsLookup.ViewPrefab); } }

    public GameEntity AddViewPrefab(Code.Infrastructure.View.EntityBehavior newValue) {
        var index = GameComponentsLookup.ViewPrefab;
        var component = (Code.Common.ViewPrefab)CreateComponent(index, typeof(Code.Common.ViewPrefab));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceViewPrefab(Code.Infrastructure.View.EntityBehavior newValue) {
        var index = GameComponentsLookup.ViewPrefab;
        var component = (Code.Common.ViewPrefab)CreateComponent(index, typeof(Code.Common.ViewPrefab));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveViewPrefab() {
        RemoveComponent(GameComponentsLookup.ViewPrefab);
        return this;
    }
}
