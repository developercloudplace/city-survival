using Code.Gameplay.Features.EffectApplication.System;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.EffectApplication
{
    public class EffectApplicationFeatures : Feature
    {
        public EffectApplicationFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<ApplyEffectsOnTargetsSystem>());
        }
    }
}