using System.Collections.Generic;
using Code.Gameplay.Features.Effect;
using Code.Gameplay.Features.Statuses;
using Code.Infrastructure.View;
using UnityEngine;

namespace Code.Gameplay.Features.Loot.Configs
{
    [CreateAssetMenu(menuName = "Create LootConfig", fileName = "LootConfig")]
    public class LootConfig : ScriptableObject
    {
        public LootTypeId LootTypeId;

        public float Experience;
        public EntityBehavior ViewPrefab;

        public List<EffectSetup> EffectSetups;
        public List<StatusSetup> StatusSetups;
    }
}