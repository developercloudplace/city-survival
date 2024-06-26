﻿using Code.Gameplay.Features.Enemies.Systems;
using Code.Infrastructure.System;

namespace Code.Gameplay.Features.Enemies
{
    public class EnemyFeatures : Feature
    {
        public EnemyFeatures(ISystemFactory systemFactory)
        {
            Add(systemFactory.Create<InitializeSpawnTimerSystem>());
            Add(systemFactory.Create<EnemySpawnSystem>());
            
            Add(systemFactory.Create<EnemyChaseHeroSystem>());
            Add(systemFactory.Create<EnemyDeathSystem>());
            Add(systemFactory.Create<FinalizeEnemyDeathProcessingSystem>());
        }
    }
}