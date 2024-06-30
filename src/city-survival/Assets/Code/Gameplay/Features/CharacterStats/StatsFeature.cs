using Code.Gameplay.Features.CharacterStats.Systems;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.CharacterStats
{
    public sealed class StatsFeature : Feature
    {
        public StatsFeature(ISystemFactory systems)
        {
            Add(systems.Create<StatChangeSystem>());
            Add(systems.Create<ApplySpeedFromStatsSystem>());
        }
    }
}