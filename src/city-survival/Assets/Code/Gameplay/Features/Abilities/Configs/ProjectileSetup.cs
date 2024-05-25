using System;
using UnityEngine;

namespace Code.Gameplay.Features.Abilities.Configs
{
    [Serializable]
    public class ProjectileSetup
    {
        public float Speed;
        public int Pierce = 1;
        public float ContactSphereRadios;
        public float LifeTime;
        public Transform SpawnPoint;
    }
}