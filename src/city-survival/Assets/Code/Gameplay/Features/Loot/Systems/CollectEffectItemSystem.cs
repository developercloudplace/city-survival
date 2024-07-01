using Code.Gameplay.Features.Effect;
using Code.Gameplay.Features.Effect.Factory;
using Entitas;

namespace Code.Gameplay.Features.Loot.Systems
{
    public class CollectEffectItemSystem : IExecuteSystem
    {
        private readonly IEffectFactory _effectFactory;
        private readonly IGroup<GameEntity> _collected;
        private readonly IGroup<GameEntity> _players;

        public CollectEffectItemSystem(GameContext game, IEffectFactory effectFactory)
        {
            _effectFactory = effectFactory;
            _collected = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Collected,
                    GameMatcher.EffectSetups));

            _players = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Id,
                    GameMatcher.Player,
                    GameMatcher.WorldPosition));
        }

        public void Execute()
        {
            foreach (GameEntity loot in _collected)
            foreach (GameEntity player in _players)
            foreach (EffectSetup effectSetup in loot.EffectSetups)
                _effectFactory.CreateEffect(effectSetup, player.Id, player.Id);
        }
    }
}