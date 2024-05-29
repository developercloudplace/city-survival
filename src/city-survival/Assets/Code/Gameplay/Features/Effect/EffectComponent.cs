using Entitas;

namespace Code.Gameplay.Features.Effect
{
    [Game] public class Effect : IComponent {}
    [Game] public class ProducerId : IComponent {public int Value;}
    [Game] public class TargetId : IComponent {public int Value;}
    [Game] public class EffectValue : IComponent {public float Value;} 
    [Game] public class DamageEffect : IComponent {} 
}