using Code.Gameplay.Features.Abilities.System;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Abilities
{
    public sealed class AbilityFeature : Feature
    {
        public AbilityFeature(ISystemFactory systems)
        {
            Add(systems.Create<InitializeDroneAbilitySystem>());
            Add(systems.Create<DroneAbilitySystem>());
        }
    }
}