using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities
{
    [Game] public class AbilityIdComponent: IComponent {public AbilityId Value;}
    [Game] public class DroneAbilityComponent: IComponent {}
    [Game] public class MachineGunAbilityComponent: IComponent {}
    [Game] public class CurrentTarget: IComponent {}
    [Game] public class CurrentTargetPosition: IComponent {public Vector3 Value;}
}