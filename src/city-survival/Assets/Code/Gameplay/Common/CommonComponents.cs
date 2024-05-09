using Entitas;
using UnityEngine;

namespace Code.Gameplay.Common
{
    [Game] public class Id: IComponent {public int Value;}
    [Game] public class WorldPosition: IComponent {public Vector3 Value;}
    [Game] public class TransformComponent: IComponent {public Transform Value;}
    [Game] public class TestComponent: IComponent {public Vector3 Value;}
    [Game] public class Test2Component: IComponent {public Vector3 Value;}
    
} 
