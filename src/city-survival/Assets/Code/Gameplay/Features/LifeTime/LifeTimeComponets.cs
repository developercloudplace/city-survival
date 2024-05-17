using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Code.Gameplay.Features.LifeTime
{
    public class LifeTimeComponents
    {
        [Game] public class CurrentXp: IComponent { public float Value;}
        [Game] public class MaxXp: IComponent { public float Value;}
    }
}