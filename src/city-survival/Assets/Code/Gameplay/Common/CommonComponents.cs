using Entitas;
using UnityEngine;

namespace Code.Gameplay.Common
{
    [Game] public class Id: IComponent {public int Value;}
    [Game] public class WorldPosition: IComponent {public Vector3 Value;}
    [Game] public class TransformComponent: IComponent {public Transform Value;}
    [Game] public class RotateComponent: IComponent {public Quaternion Value;}
    [Game] public class Velocity: IComponent {public float Value;}
    
   
    
} 
