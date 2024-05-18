using System.Collections.Generic;
using Entitas;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Code.Common.Destruct.System
{
    public class CleanupGameDestructedViewSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _entities;
        
        public CleanupGameDestructedViewSystem(GameContext gameContext)
        {
            _entities = gameContext.GetGroup(GameMatcher.AllOf(
                GameMatcher.Destructed,
                GameMatcher.View));
        }

        public void Cleanup()
        {
            foreach (var entity in _entities)
            {
                entity.View.ReleaseEntity();
                Object.Destroy(entity.View.gameObject);
            }
        }
    }
}