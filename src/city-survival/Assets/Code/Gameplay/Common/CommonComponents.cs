﻿using Code.Gameplay.Common.Visuals;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace Code.Gameplay.Common
{
    [Game] public class Id: IComponent { [PrimaryEntityIndex] public int Value;}
    [Game] public class WorldPosition: IComponent {public Vector3 Value;}
    [Game] public class TransformComponent: IComponent {public Transform Value;}
    [Game] public class RotateComponent: IComponent {public Quaternion Value;}
    [Game] public class Velocity: IComponent {public float Value;}
    [Game] public class Damage: IComponent {public float Value;}
    [Game] public class DamageTakenComponent: IComponent {public IDamageTakenAnimator  Value;}
} 
