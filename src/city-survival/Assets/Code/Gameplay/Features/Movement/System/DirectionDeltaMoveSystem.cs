using Code.Gameplay.Common.Time;
using Entitas;
using UnityEngine;

namespace Code.Gameplay.Features.Movement.System
{
    public class DirectionDeltaMoveSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _movers;

        public DirectionDeltaMoveSystem(GameContext gameContext, ITimeService time)
        {
            _time = time;
            _movers = gameContext.GetGroup(GameMatcher.
                AllOf(
                    GameMatcher.WorldPosition, 
                    GameMatcher.Speed,
                    GameMatcher.Direction,
                    GameMatcher.Moving));
        }
        public void Execute()
        {
            foreach (GameEntity mover in _movers)
            {
                mover.ReplaceWorldPosition(mover.WorldPosition + mover.Direction * mover.Speed * _time.DeltaTime);
            }
        }
    }
    public class RotationSpecifiedSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _movers;

        public RotationSpecifiedSystem(GameContext gameContext, ITimeService time)
        {
            _time = time;
            _movers = gameContext.GetGroup(GameMatcher.
                AllOf(
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
             //  float targetAngle = Mathf.Atan2(mover.Direction.x, mover.Direction.z) * Mathf.Rad2Deg;
             //  float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity,
             //  mover.ReplaceRotate(mover.WorldPosition + mover.Direction * mover.Speed * _time.DeltaTime);
            }
        }
    }
}