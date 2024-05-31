using System.Collections.Generic;
using Code.Gameplay.Features.Effect;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems.StatusVisuals
{
    public class ApplyBurningVisualSystem : ReactiveSystem<GameEntity>
    {
        public ApplyBurningVisualSystem(GameContext game) : base(game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) => 
            context.CreateCollector(GameMatcher.Burning.Added());

        protected override bool Filter(GameEntity entity) => entity.isStatus && entity.isBurning && entity.hasTargetId;

        protected override void Execute(List<GameEntity> statuses)
        {
            foreach (GameEntity status in statuses)
            {
                GameEntity target = status.Target();
                if (target is {hasStatusVisuals: true}) 
                    target.StatusVisuals.ApplyBurning();
            }
        }
    }
    public class UnapplyBurningVisualSystem : ReactiveSystem<GameEntity>
    {
        public UnapplyBurningVisualSystem(GameContext game) : base(game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.AllOf(GameMatcher.Burning, GameMatcher.Status, GameMatcher.Unapplied));

        protected override bool Filter(GameEntity entity) => entity.isStatus && entity.isBurning && entity.hasTargetId;

        protected override void Execute(List<GameEntity> statuses)
        {
            foreach (GameEntity status in statuses)
            {
                GameEntity target = status.Target();
                if (target is {hasStatusVisuals: true}) 
                    target.StatusVisuals.UnApplyBurning();
            }
        }
    }
}