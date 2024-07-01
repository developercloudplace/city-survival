using Code.Gameplay.Features.Loot.Systems;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Loot
{
    public sealed class LootingFeature : Feature
    {
        public LootingFeature(ISystemFactory systems)
        {
            Add(systems.Create<CastForPullablesSystem>());

            Add(systems.Create<PullTowardsPlayerSystem>());
            Add(systems.Create<CollectWhenNearSystem>());

            Add(systems.Create<CollectExperienceSystem>());
            Add(systems.Create<CollectEffectItemSystem>());
            Add(systems.Create<CollectStatusItemSystem>());


            Add(systems.Create<CleanupCollected>());
        }
    }
}