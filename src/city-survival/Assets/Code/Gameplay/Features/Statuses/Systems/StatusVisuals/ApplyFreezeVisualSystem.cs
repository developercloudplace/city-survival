﻿using System.Collections.Generic;
using Code.Gameplay.Features.Effect;
using Entitas;

namespace Code.Gameplay.Features.Statuses.Systems.StatusVisuals
{
    public class ApplyFreezeVisualSystem : ReactiveSystem<GameEntity>
    {
        public ApplyFreezeVisualSystem(GameContext game) : base(game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) => 
            context.CreateCollector(GameMatcher.Freeze.Added());

        protected override bool Filter(GameEntity entity) => entity.isStatus && entity.isFreeze && entity.hasTargetId;

        protected override void Execute(List<GameEntity> statuses)
        {
            foreach (GameEntity status in statuses)
            {
                GameEntity target = status.Target();
                if (target is {hasStatusVisuals: true}) 
                    target.StatusVisuals.ApplyFreeze();
            }
        }
    }
}