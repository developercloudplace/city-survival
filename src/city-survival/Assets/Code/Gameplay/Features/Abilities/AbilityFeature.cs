using Code.Gameplay.Features.Abilities.System;
using Code.Gameplay.Features.Cooldowns.System;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Abilities
{
    public sealed class AbilityFeature : Feature
    {
        public AbilityFeature(ISystemFactory systems)
        {
            
            Add(systems.Create<CooldownSystem>());
            Add(systems.Create<InitializeDroneAbilitySystem>());
            Add(systems.Create<DroneAbilitySystem>());
            Add(systems.Create<MachineGunAbilitySystem>());
        }
    }
}