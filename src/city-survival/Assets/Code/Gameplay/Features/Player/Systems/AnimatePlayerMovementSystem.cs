using Entitas;

namespace Code.Gameplay.Features.Player.Systems
{
    public class AnimatePlayerMovementSystem: IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        private readonly IGroup<GameEntity> _inputs;

        public AnimatePlayerMovementSystem(GameContext gameContext)
        {
            _players = gameContext.GetGroup(GameMatcher.
                AllOf(
                    GameMatcher.Player,
                    GameMatcher.PlayerAnimator));
             
        }
        public void Execute()
        {
            foreach (GameEntity player in _players)
            {
                if (player.isMoving)
                    player.PlayerAnimator.PlayMove();
                else
                    player.PlayerAnimator.PlayIdle();
            }
        }
    }
}