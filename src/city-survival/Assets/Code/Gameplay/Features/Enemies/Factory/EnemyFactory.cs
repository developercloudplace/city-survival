using System;
using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Factory
{
    public class EnemyFactory : IEnemyFactory
    {
        private IIdentifierService _identifier;

        public EnemyFactory(IIdentifierService identifier)
        {
            _identifier = identifier;
        }

        public GameEntity CreateEnemy(EnemyTypeId typeId, Vector3 at)
        {
            switch (typeId)
            {
                case EnemyTypeId.Zombie:
                    return CreateZombie(at);
            }

            throw new Exception($"with type id {typeId} does note exist");
        }

        private GameEntity CreateZombie(Vector3 at)
        {
            return CreateEntity.Empty()
                    .AddId(_identifier.Next())
                    .AddWorldPosition(at)
                    .AddEnemyTypeId(EnemyTypeId.Zombie)
                    .AddSpeed(1)
                    .AddCurrentXp(10)
                    .AddMaxXp(3)
                    .AddDamage(1)
                    .AddTargetBuffer(new List<int>(1))
                    .AddViewPath("Enemy/Zombie")//Resources path. TODO:place Addressable labels
                    .AddCollectTargetRadius(1)
                    .AddCollectTargetsInterval(.5f)
                    .AddCollectTargetsTimer(0)
                    .AddLayerMask(CollisionLayer.Player.AsMask())
                    .AddDirection(Vector3.zero)
                    .With(x => x.isEnemy = true)
                    .With(x => x.isRotating = true)
                    .With(x => x.isMovementAvailable = true)
                ;
        }
    }
}