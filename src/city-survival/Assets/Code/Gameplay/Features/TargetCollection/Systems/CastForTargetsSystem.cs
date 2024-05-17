using System.Collections.Generic;
using System.Linq;
using Code.Gameplay.Common.Physics;
using Entitas;

namespace Code.Gameplay.Features.TargetCollection.Systems
{
    public class CastForTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly IPhysicsService _physicsService;

        public CastForTargetsSystem(GameContext gameContext, IPhysicsService physicsService)
        {
            _physicsService = physicsService;
            _entities = gameContext.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.TargetBuffer,
                    GameMatcher.WorldPosition,
                    GameMatcher.Radius,
                    GameMatcher.LayerMask));
            // GameMatcher.CollectTargetsTimer,
            // GameMatcher.CollectTargetsInterval));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            {
                entity.TargetBuffer.AddRange(TargetInRadius(entity));
            }
        }

        private IEnumerable<int> TargetInRadius(GameEntity entity) =>
            _physicsService
                .CircleCast(entity.WorldPosition, entity.Radius, entity.LayerMask)
                .Select(x => x.Id);
    }
}