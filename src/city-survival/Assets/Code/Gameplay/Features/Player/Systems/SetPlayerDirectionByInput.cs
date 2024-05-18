using Entitas;

namespace Code.Gameplay.Features.Player.Systems
{
    public class SetPlayerDirectionByInput: IExecuteSystem
    {
        private readonly IGroup<GameEntity> _players;
        private readonly IGroup<GameEntity> _inputs;

        public SetPlayerDirectionByInput(GameContext gameContext)
        {
            _inputs = gameContext.GetGroup(GameMatcher.Input);
            _players = gameContext.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Player,
                    GameMatcher.MovementAvailable));
        }
        public void Execute()
        {
            foreach (GameEntity input in _inputs)
            foreach (GameEntity player in _players)
            {
                player.isMoving = input.hasAxisInput;
                if (input.hasAxisInput) 
                    player.ReplaceDirection(input.AxisInput.normalized);
            }
        }
    }
}