using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Player.Systems
{
    public class FinalizePlayerDeathProcessingSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        private readonly List<GameEntity> _buffer = new(1);

        public FinalizePlayerDeathProcessingSystem(GameContext game)
        {
            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.Dead,
                    GameMatcher.ProcessingDeath));
        }

        public void Execute()
        {
            foreach (GameEntity player in _players.GetEntities(_buffer))
            {
                player.isProcessingDeath = false;
               // player.isDestructed = true;
            }
        }
    }
}