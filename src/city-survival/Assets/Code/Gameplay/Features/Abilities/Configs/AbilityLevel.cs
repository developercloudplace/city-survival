using System;
using System.Collections.Generic;
using Code.Gameplay.Features.Armaments;
using Code.Gameplay.Features.Effect;
using Code.Gameplay.Features.Statuses;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features.Abilities.Configs
{
    [Serializable]
    public class AbilityLevel
    {
        public float Cooldown;
        public EntityBehavior ViewPrefab;
        public List<EffectSetup> EffectSetups;
        public List<StatusSetup> StatusSetups;
        public ProjectileSetup ProjectileSetup;

    }
}