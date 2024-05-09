using System;
using Code.Common.Entity;
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
                .AddWorldPosition(transform.position)
                .AddSpeed(Speed)
                .AddDirection(Vector3.zero);
        }
    }
}