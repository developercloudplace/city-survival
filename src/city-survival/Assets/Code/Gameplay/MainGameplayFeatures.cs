using Code.Common.Destruct;
using Code.Gameplay.Features.DamageApplication;
using Code.Gameplay.Features.Enemies;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Player;
using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Input;
using Code.Infrastructure.System;

namespace Code.Gameplay
{
    public class MainGameplayFeatures : Feature
    {
        public MainGameplayFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InputFeature>());
            Add(systemFactory.Create<PlayerFeatures>());
            Add(systemFactory.Create<EnemyFeatures>());
            Add(systemFactory.Create<MovementFeatures>());
            Add(systemFactory.Create<CollectTargetsFeature>());
            Add(systemFactory.Create<DamageApplicationFeatures>());
            Add(systemFactory.Create<ProcessDestructedFeature>());
        }
    }
}