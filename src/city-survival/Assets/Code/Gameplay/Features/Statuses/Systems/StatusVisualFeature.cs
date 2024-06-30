using Code.Gameplay.Features.Statuses.Systems.StatusVisuals;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Statuses.Systems
{
    public sealed class StatusVisualFeature : Feature
    {
        public StatusVisualFeature(ISystemFactory systems)
        {
            Add(systems.Create<ApplyBurningVisualSystem>());
            Add(systems.Create<UnapplyBurningVisualSystem>());
            
            Add(systems.Create<ApplyFreezeVisualSystem>());
            Add(systems.Create<UnapplyFreezeVisualSystem>());
        }
    }
}