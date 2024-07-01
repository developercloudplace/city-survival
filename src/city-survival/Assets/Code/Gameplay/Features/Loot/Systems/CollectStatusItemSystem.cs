using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Applier;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
    public class CollectStatusItemSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _collected;
        private readonly IGroup<GameEntity> _palyers;
        private readonly IStatusApplier _statusApplier;

        public CollectStatusItemSystem(GameContext game, IStatusApplier statusApplier)
        {
            _statusApplier = statusApplier;
            _collected = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Collected,
                    GameMatcher.StatusSetups));
      
            _palyers = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Id, 
                    GameMatcher.Player, 
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity loot in _collected)
            foreach (GameEntity player in _palyers)
            foreach (StatusSetup statusSetup in loot.StatusSetups)
                _statusApplier.ApplyStatus(statusSetup, player.Id, player.Id);
        }
    
    }
}