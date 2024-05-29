using Code.Gameplay.Features.Effect;
using Code.Gameplay.Features.Effect.Factory;
using Entitas;

namespace Code.Gameplay.Features.EffectApplication.System
{
    public class ApplyEffectsOnTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _entities;
        private readonly IEffectFactory _effectFactory;

        public ApplyEffectsOnTargetsSystem(GameContext gameContext, IEffectFactory effectFactory)
        {
            _effectFactory = effectFactory;
            _entities = gameContext.GetGroup(GameMatcher
                .AllOf(
                    // GameMatcher.TargetBuffer,
                    GameMatcher.EffectSetups));
        }

        public void Execute()
        {
            foreach (GameEntity entity in _entities)
            foreach (int targetId in entity.TargetBuffer)
            foreach (EffectSetup setup in entity.EffectSetups)
            {
                _effectFactory.CreateEffect(setup, ProducerId(entity), entity.TargetId);
            }
        }

        private static int ProducerId(GameEntity entity) =>
            entity.hasProducerId ? entity.ProducerId : entity.Id;
    }
}

// GameEntity target = _gameContext.GetEntityWithId(targetId);
// if (target.hasCurrentXp)
// {
//     target.ReplaceCurrentXp(target.CurrentXp - damageDealer.Damage);
//     if (target.hasDamageTakenAnimator)
//     {
//         target.DamageTakenAnimator.PlayDamageTaken();
//     }
// }