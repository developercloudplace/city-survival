using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Applier;
using Code.Gameplay.Features.Statuses.Factory;
using Entitas;

namespace Code.Gameplay.Features.EffectApplication.System
{
    public class ApplyStatusesOnTargetsSystem : IExecuteSystem
    {
        
        private readonly IGroup<GameEntity> _entities;
        private IStatusApplier _statusApplier;


        public ApplyStatusesOnTargetsSystem(GameContext gameContext,IStatusApplier statusApplier)
        {
            _statusApplier = statusApplier;
            
            
            _entities = gameContext.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.TargetBuffer,
                    GameMatcher.StatusSetups));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            foreach (int targetId in entity.TargetBuffer)
            foreach (StatusSetup setup in entity.StatusSetups)
            {
                _statusApplier.ApplyStatus(setup, ProducerId(entity), targetId);
            }
        }

        private static int ProducerId(GameEntity entity) =>
            entity.hasProducerId ? entity.ProducerId : entity.Id;
    }
}