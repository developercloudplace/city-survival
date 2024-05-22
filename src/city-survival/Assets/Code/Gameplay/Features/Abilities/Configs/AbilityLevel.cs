using System;
using Code.Infrastructure.View;

namespace Code.Gameplay.Features.Abilities.Configs
{
    [Serializable]
    public class AbilityLevel
    {
        public float Cooldown;
        public EntityBehavior ViewPrefab;
        public ProjectileSetup ProjectileSetup;

    }
}