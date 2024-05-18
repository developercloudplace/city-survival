using Entitas;

namespace Code.Gameplay.Features.LifeTime
{
    [Game] public class CurrentXp : IComponent { public float Value; }
    [Game] public class MaxXp : IComponent { public float Value; }
    [Game] public class Dead : IComponent { }
    [Game] public class ProcessingDeath : IComponent { }
}   