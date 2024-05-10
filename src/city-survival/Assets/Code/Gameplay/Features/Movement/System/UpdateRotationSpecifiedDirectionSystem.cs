using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.System
{
    public class UpdateRotationSpecifiedDirectionSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;
        public UpdateRotationSpecifiedDirectionSystem(GameContext gameContext)
        {
            _movers = gameContext.GetGroup(GameMatcher.
                AllOf(
                    GameMatcher.Rotate,
                    GameMatcher.Transform));
        }
        public void Execute()
        {
            foreach (GameEntity mover in _movers)
                mover.Transform.rotation = mover.Rotate;
        }
    }
}