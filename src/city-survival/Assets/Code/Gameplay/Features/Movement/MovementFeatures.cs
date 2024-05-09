using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.Movement.System;

namespace Code.Gameplay.Features.Movement
{
    public class MovementFeatures : Feature
    {
        public MovementFeatures(GameContext gameContext, ITimeService time)
        {
            Add(new DirectionDeltaMoveSystem(gameContext, time));
            Add(new UpdateTransformPositionSystem(gameContext));
        }
    }
}