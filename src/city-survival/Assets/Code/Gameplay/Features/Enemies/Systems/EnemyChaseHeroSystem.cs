using Entitas;

namespace Code.Gameplay.Features.Enemies.Systems
{
    public class EnemyChaseHeroSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _enemies;
        private readonly IGroup<GameEntity> _players;

        public EnemyChaseHeroSystem(GameContext game)
        {
            _enemies = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Enemy,
                    GameMatcher.WorldPosition));

            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity player in _players)
            foreach (GameEntity enemy in _enemies)
            {
                enemy.ReplaceDirection((player.WorldPosition - enemy.WorldPosition).normalized);
                enemy.isMoving = true;
            }
        }
    }
}