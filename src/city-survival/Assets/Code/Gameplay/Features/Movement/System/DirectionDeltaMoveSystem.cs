using Code.Gameplay.Common.Time;
using Entitas;

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
}