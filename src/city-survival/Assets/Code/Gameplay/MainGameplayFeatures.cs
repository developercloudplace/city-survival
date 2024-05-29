using Code.Common.Destruct;
using Code.Gameplay.Features.Abilities;
using Code.Gameplay.Features.Effect;
using Code.Gameplay.Features.EffectApplication;
using Code.Gameplay.Features.Enemies;
using Code.Gameplay.Features.LifeTime;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Features.Player;
using Code.Gameplay.Features.TargetCollection;
using Code.Gameplay.Input;
using Code.Infrastructure.System;
using Code.Infrastructure.View;

namespace Code.Gameplay
{
    public class MainGameplayFeatures : Feature
    {
        public MainGameplayFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InputFeature>());
            Add(systemFactory.Create<BindViewFeature>());
            
            Add(systemFactory.Create<MovementFeatures>());
            Add(systemFactory.Create<PlayerFeatures>());
            Add(systemFactory.Create<EnemyFeatures>());
            Add(systemFactory.Create<AbilityFeature>());
            Add(systemFactory.Create<ArmamentFeature>());
            
            Add(systemFactory.Create<CollectTargetsFeature>());
            Add(systemFactory.Create<EffectApplicationFeatures>());
            Add(systemFactory.Create<EffectFeature>());
            Add(systemFactory.Create<ProcessDestructedFeature>());
            Add(systemFactory.Create<DeadFeature>());
        }
    }
}