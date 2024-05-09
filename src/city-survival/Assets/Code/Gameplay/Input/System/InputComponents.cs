using Entitas;
using UnityEngine;

namespace Code.Gameplay.Input.System
{   
    [Game] public class Input : IComponent { } 
    [Game] public class AxisInput : IComponent {public Vector3 Value;}
}