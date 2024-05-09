using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Player.Behaviours;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Registrars
{
    //TODO : Temporary class for linking with MonoBehaviour
    public class PlayerRegistrar : MonoBehaviour
    {
        public float Speed;
        public PlayerAnimator PlayerAnimator;
        private GameEntity _entity;

        private void Awake()
        {
            _entity = CreateEntity
                .Empty()
                .AddTransform(transform)
                .AddRotate(transform.rotation)
                .AddWorldPosition(transform.position)
                .AddSpeed(Speed)
                .AddDirection(Vector3.zero)
                .AddPlayerAnimator(PlayerAnimator)
                .With(x=>x.isPlayer = true)
                .With(x=>x.isRotating = true)
                ;
        }
    }
}