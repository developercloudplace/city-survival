using Entitas;

namespace Code.Gameplay.Features.Player.Systems
{
    public class PlayerDeathSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;

        public PlayerDeathSystem(GameContext game)
        {
            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.PlayerAnimator,
                    GameMatcher.Dead,
                    GameMatcher.ProcessingDeath));
        }

        public void Execute()
        {
            foreach (GameEntity player in _players)
            {
                player.isMovementAvailable = false;
                player.isRotating = false;
                if (player.hasPlayerAnimator)
                {
                    player.PlayerAnimator.PlayDied();
                }

                player.PlayerAnimator.StopDamageTaken();
                player.ReplaceSelfDestructTimer(5);
            }
        }
    }
}