using Code.Gameplay.Features.LifeTime.Systems;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.LifeTime
{
    public sealed class DeadFeature : Feature
    {
        public DeadFeature(ISystemFactory systems)
        {
            Add(systems.Create<MarkDeadSystem>());
            Add(systems.Create<UnapplyStatusesOfDeadTargetSystem>());
        }
    }
}