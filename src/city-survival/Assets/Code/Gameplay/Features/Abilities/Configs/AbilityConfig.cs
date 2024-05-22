using System.Collections.Generic;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.Configs
{
    [CreateAssetMenu(menuName = "Create AbilityConfig", fileName = "AbilityConfig")]
    public class AbilityConfig : ScriptableObject
    {
        public AbilityId AbilityId;
        public List<AbilityLevel> Levels;
        
    }
}