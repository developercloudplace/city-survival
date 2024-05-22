using UnityEngine;

namespace Code.Gameplay.Features.Abilities.Factory
{
    public interface IAbilityFactory
    {
        GameEntity CreateDroneAbility(int level, Vector3 at);
    }
}