using Code.Gameplay.Features.Movement.System;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Movement
{
    public class MovementFeatures : Feature
    {
        public MovementFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<DirectionDeltaMoveSystem>());
            Add(systemFactory.Create<UpdateTransformPositionSystem>());
            Add(systemFactory.Create<RotationSpecifiedDirectionSystem>());
            Add(systemFactory.Create<UpdateRotationSpecifiedDirectionSystem>());
        }
    }
}