using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
    public class PullTowardsPlayerSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _palyers;
        private readonly IGroup<GameEntity> _pullables;

        public PullTowardsPlayerSystem(GameContext game)
        {
            _palyers = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));

            _pullables = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Pulling,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity player in _palyers)
            foreach (GameEntity pullable in _pullables)
            {
                pullable.ReplaceDirection((player.WorldPosition - pullable.WorldPosition).normalized);
                pullable.ReplaceSpeed(4);
                pullable.isMoving = true;
                pullable.isMovementAvailable = true;
            }
        }
    }
}