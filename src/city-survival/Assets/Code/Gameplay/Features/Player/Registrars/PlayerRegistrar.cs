using Code.Common.Extensions;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Registrars
{
    //TODO : Temporary class for linking with MonoBehaviour
    public class PlayerRegistrar : EntityComponentRegistrar
    {
        public float Speed;
        public int MaxHp = 100;

        public override void RegistrarComponent()
        {
            Entity
                .AddWorldPosition(transform.position)
                .AddCurrentXp(MaxHp)
                .AddMaxXp(MaxHp)
                .AddSpeed(Speed)
                .AddDirection(Vector3.zero)
                .With(x => x.isPlayer = true)
                .With(x => x.isRotating = true)
                .With(x => x.isMovementAvailable = true)
                ;
        }

        public override void UnRegistrarComponent()
        {
        }
    }
}