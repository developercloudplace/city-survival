using Code.Common.Extensions;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Factory;
using Entitas;

namespace Code.Gameplay.Features.EffectApplication.System
{
    public class ApplyStatusesOnTargetsSystem : IExecuteSystem
    {
        private readonly IStatusFactory _statusFactory;
        private readonly IGroup<GameEntity> _entities;
        

        public ApplyStatusesOnTargetsSystem(GameContext gameContext, IStatusFactory statusFactory)
        {
            _statusFactory = statusFactory;
            
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
                _statusFactory.CreateStatus(setup, ProducerId(entity), targetId)
                    .With(x => x.isApplied = true);
            }
        }

        private static int ProducerId(GameEntity entity) =>
            entity.hasProducerId ? entity.ProducerId : entity.Id;
    }
}