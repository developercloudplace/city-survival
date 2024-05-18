using System.Collections.Generic;
using Code.Common.Extensions;
using Code.Gameplay.Features.Enemies.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Registrar
{
    public class EnemyRegistrar : EntityComponentRegistrar
    {
        public float Speed;

        public EnemyAnimator EnemyAnimator;
        public int MaxHp = 10;
        public float Damage = 1;
        public float Radius = 1;

        public override void RegistrarComponent()
        {
            Entity
                .AddWorldPosition(transform.position)
                .AddEnemyTypeId(EnemyTypeId.Zombie)
                .AddSpeed(Speed)
                .AddCurrentXp(MaxHp)
                .AddMaxXp(MaxHp)
                .AddDamage(Damage)
                .AddTargetBuffer(new List<int>(1))
                .AddRadius(Radius)
                .AddDamageTakenAnimator(EnemyAnimator)
                .AddCollectTargetsInterval(.5f)
                .AddCollectTargetsTimer(0)
                .AddLayerMask(CollisionLayer.Player.AsMask())
                .AddDirection(Vector3.zero)
                .AddEnemyAnimator(EnemyAnimator)
                .With(x => x.isEnemy = true)
                .With(x => x.isRotating = true)
                ;
        }

        public override void UnRegistrarComponent()
        {
            if (Entity.hasPlayerAnimator)
                Entity.RemoveEnemyAnimator();
            if (Entity.hasDamageTakenAnimator) 
                Entity.RemoveDamageTakenAnimator();
        }
    }
}