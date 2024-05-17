using Entitas;

namespace Code.Gameplay.Features.TargetCollection.Systems
{
    public class CastForTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _targets;

        public CastForTargetsSystem(GameContext gameContext)
        {
           _targets =  gameContext.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.TargetBuffer,
                    GameMatcher.CollectTargetsTimer,
                    GameMatcher.CollectTargetsInterval));
        }

        public void Execute()
        {
            foreach (var target in _targets)
            {
            }
        }
    }
}