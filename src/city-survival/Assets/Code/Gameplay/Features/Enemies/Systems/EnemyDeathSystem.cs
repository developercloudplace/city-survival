//using Code.Gameplay.Features.TargetCollection;

using Entitas;

public class EnemyDeathSystem : IExecuteSystem
{
    private const int DEATH_ANIMATION_TIMER = 2;
    private readonly IGroup<GameEntity> _enemies;

    public EnemyDeathSystem(GameContext game)
    {
        _enemies = game.GetGroup(GameMatcher
            .AllOf(
                GameMatcher.Enemy,
                GameMatcher.Dead,
                GameMatcher.ProcessingDeath));
    }

    public void Execute()
    {
        foreach (GameEntity enemy in _enemies)
        {
            enemy.isMovementAvailable = false;
            enemy.isRotating = false;
            
            if (enemy.hasEnemyAnimator)
            {
                enemy.EnemyAnimator.PlayDied();
            }

            enemy.ReplaceSelfDestructTimer(DEATH_ANIMATION_TIMER);
        }
    }
}