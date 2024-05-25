using Entitas;

namespace Code.Gameplay.Features.Armaments
{ 
    [Game] public class Armament : IComponent {}
    [Game] public class Processed : IComponent {}
    [Game] public class TargetLimits : IComponent {public int Value;}
    
}