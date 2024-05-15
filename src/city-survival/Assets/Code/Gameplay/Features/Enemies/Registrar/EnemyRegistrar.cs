using Code.Common.Extensions;
using Code.Gameplay.Features.Enemies.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Enemies.Registrar
{
    public class EnemyRegistrar: EntityComponentRegistrar
    {
        public float Speed;
        public EnemyAnimator EnemyAnimator;
        public override void RegistrarComponent()
        {
            Entity
                .AddTransform(transform)
                .AddWorldPosition(transform.position)
                .AddEnemyTypeId(EnemyTypeId.Zombie)
                .AddSpeed(Speed)
                .AddDirection(Vector3.zero)
                .AddEnemyAnimator(EnemyAnimator)
                .With(x => x.isEnemy = true)
                .With(x => x.isRotating = true)
                ;
        }

        public override void UnRegistrarComponent()
        {
            
        }
    }
}