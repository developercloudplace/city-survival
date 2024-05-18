using Entitas;

namespace Code.Gameplay.Features.DamageApplication.System
{
    public class ApplyDamageOnTargetsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _damageDealers;
        private readonly GameContext _gameContext;

        public ApplyDamageOnTargetsSystem(GameContext gameContext)
        {
            _gameContext = gameContext;
            _damageDealers = gameContext.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.DamageTakenAnimator,
                    GameMatcher.Damage));
        }

        public void Execute()
        {
            foreach (GameEntity damageDealer in _damageDealers)
            foreach (int targetId in damageDealer.TargetBuffer)
            {
                GameEntity target = _gameContext.GetEntityWithId(targetId);
                if (target.hasCurrentXp)
                {
                    target.ReplaceCurrentXp(target.CurrentXp - damageDealer.Damage);
                    if (target.hasDamageTakenAnimator)
                    {
                        target.DamageTakenAnimator.PlayDamageTaken();
                    }
                }
            }
        }
    }
}