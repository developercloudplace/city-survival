using Code.Gameplay.Features.Effect.System;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Effect
{
    public sealed class EffectFeature : Feature
    {
        public EffectFeature(ISystemFactory systems)
        {
            Add(systems.Create<RemoveEffectsWithoutTargetsSystem>());
            Add(systems.Create<ProcessDamageEffectSystem>());
            Add(systems.Create<CleanupProcessedEffect>());
        }
    }
}