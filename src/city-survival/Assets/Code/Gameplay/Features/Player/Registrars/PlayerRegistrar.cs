using System;
using Code.Common.Entity;
using Code.Common.Extensions;
using UnityEngine;

namespace Code.Gameplay.Features.Player.Registrars
{
    //TODO : Temporary class for linking with MonoBehaviour
    public class PlayerRegistrar : MonoBehaviour
    {
        public float Speed;
        private GameEntity _entity;

        private void Awake()
        {
            _entity = CreateEntity
                .Empty()
                .AddTransform(transform)
                .AddWorldPosition(transform.position)
                .AddSpeed(Speed)
                .AddDirection(Vector3.zero)
                .With(x=>x.isPlayer = true)
                ;
        }
    }
}