using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Armaments.System
{
    public class MarkProcessedOnTargetLimitExceededSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _armaments;

        public MarkProcessedOnTargetLimitExceededSystem(GameContext game)
        {
            _armaments = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Armament,
                    GameMatcher.TargetLimits, 
                    GameMatcher.ProcessedTargetsBuffer));
        }

        public void Execute()
        {
            foreach (GameEntity armament in _armaments)
            {
                if (armament.ProcessedTargetsBuffer.Count >= armament.TargetLimits)
                {
                    Debug.Log("armament destroy");
                    armament.isProcessed = true;
                }
            }
        }
    }
}