using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.System
{
    public class RotationSpecifiedDirectionSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _movers;

        public RotationSpecifiedDirectionSystem(GameContext gameContext)
        {
            _movers = gameContext.GetGroup(GameMatcher.AllOf(
                GameMatcher.WorldPosition,
                GameMatcher.Speed,
                GameMatcher.Direction,
                GameMatcher.Rotate,
                GameMatcher.Moving,
                GameMatcher.Rotating));
        }

        public void Execute()
        {
            foreach (GameEntity mover in _movers)
            {
                float targetAngle = Mathf.Atan2(mover.Direction.x, mover.Direction.z) * Mathf.Rad2Deg;
                mover.ReplaceRotate(Quaternion.Euler(0.0f, targetAngle, 0.0f));
            }
        }
    }
}