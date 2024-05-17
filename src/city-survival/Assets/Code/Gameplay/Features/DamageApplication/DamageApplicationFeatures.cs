using Code.Gameplay.Features.DamageApplication.System;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.DamageApplication
{
    public class DamageApplicationFeatures : Feature
    {
        public DamageApplicationFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<ApplyDamageOnTargetsSystem>());
            Add(systemFactory.Create<DestructOnZeroHpSystem>());
        }
    }
}