using Code.Gameplay.Features.Statuses.Systems;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Statuses
{
    public sealed class StatusFeature : Feature
    {
        public StatusFeature(ISystemFactory systems)
        {
            Add(systems.Create<StatusDurationSystem>());
            Add(systems.Create<PeriodicDamageStatusSystem>());
            Add(systems.Create<ApplyFreezeStatusSystem>());
            Add(systems.Create<StatusVisualFeature>());
            
            Add(systems.Create<CleanupUnappliedStatusLinkedChanges>());
            Add(systems.Create<CleanupUnappliedStatuses>());
        }
    }
}