using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Effect.System
{
    public class CleanupProcessedEffect : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _effects;
        private readonly List<GameEntity> _buffer = new(128);

        public CleanupProcessedEffect(GameContext game)
        {
            _effects = game.GetGroup(GameMatcher.
                AllOf(
                    GameMatcher.Effect,
                    GameMatcher.Processed));
        }

        public void Cleanup()
        {
            foreach (GameEntity effect in _effects.GetEntities(_buffer))
            {
                effect.Destroy();
            }
        }
    }
}