using System;
using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Features.Abilities;
using Code.Gameplay.Features.Abilities.Configs;
using Code.Gameplay.Features.Loot;
using Code.Gameplay.Features.Loot.Configs;
using UnityEngine;

namespace Code.Gameplay.StaticData
{
    public class StaticDataService : IStaticDataService
    {
        private Dictionary<AbilityId, AbilityConfig> _abilityById;
        private Dictionary<LootTypeId, LootConfig> _lootById;

        public void LoadAll()
        {
            LoadAbilities();
            LoadLoot();
        }

        public AbilityConfig GetAbilityConfig(AbilityId abilityId)
        {
            if (_abilityById.TryGetValue(abilityId, out AbilityConfig config))
                return config;
            throw new Exception($"abilityId {abilityId} note found");
        }
        
        public LootConfig GetLootConfig(LootTypeId lootTypeId)
        {
            if (_lootById.TryGetValue(lootTypeId, out LootConfig config))
                return config;
            throw new Exception($"lootTypeId {lootTypeId} note found");
        }

        public AbilityLevel GetAbilityLevel(AbilityId abilityId, int level)
        {
            AbilityConfig config = GetAbilityConfig(abilityId);
            if (level > config.Levels.Count) 
                level = config.Levels.Count;
            return config.Levels[level - 1];
        }

        private void LoadAbilities()
        {
            _abilityById = Resources.LoadAll<AbilityConfig>("Configs/Abilities")
                .ToDictionary(x => x.AbilityId, x => x);
            
        }

        private void LoadLoot()
        {
            _lootById = Resources.LoadAll<LootConfig>("Configs/Loot")
                .ToDictionary(x => x.LootTypeId, x => x);
        }
    }
}