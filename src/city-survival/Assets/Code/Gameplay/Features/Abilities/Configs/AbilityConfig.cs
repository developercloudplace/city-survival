using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.Configs
{
    [CreateAssetMenu(menuName = "City Survival", fileName = "AbilityConfig")]
    public class AbilityConfig : ScriptableObject
    {
        public AbilityId AbilityId;
        private List<AbilityLevel> _abilityLevels;
    }
}