using System;
using Code.Common.Extensions;
using Code.Gameplay.Features.Player.Behaviours;
using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Registrars
{
    //TODO : Temporary class for linking with MonoBehaviour
    public class PlayerRegistrar : EntityComponentRegistrar
    {
        public float Speed;
        public int MaxHp = 100;
        public PlayerAnimator PlayerAnimator;
        public override void RegistrarComponent()
        {
            Entity
                .AddWorldPosition(transform.position)
                .AddCurrentXp(MaxHp)
                .AddMaxXp(MaxHp)
                .AddSpeed(Speed)
                .AddDamageTakenAnimator(PlayerAnimator)
                .AddDirection(Vector3.zero)
                .AddPlayerAnimator(PlayerAnimator)
                .With(x => x.isPlayer = true)
                .With(x => x.isRotating = true)
                ;
        }

        public override void UnRegistrarComponent()
        {
            if (Entity.hasPlayerAnimator)
                Entity.RemovePlayerAnimator();
            if (Entity.hasDamageTakenAnimator) 
                Entity.RemoveDamageTakenAnimator();

        }
    }
}