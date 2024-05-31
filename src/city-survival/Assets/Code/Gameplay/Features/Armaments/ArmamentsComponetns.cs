﻿using System.Collections.Generic;
using Code.Gameplay.Features.Effect;
using Code.Gameplay.Features.Statuses;
using Entitas;

namespace Code.Gameplay.Features.Armaments
{ 
    [Game] public class Armament : IComponent {}
    [Game] public class TargetLimits : IComponent {public int Value;}
    [Game] public class EffectSetups : IComponent {public List<EffectSetup> Value;}
    [Game] public class StatusSetups : IComponent {public List<StatusSetup> Value;}
    [Game] public class Processed : IComponent {}
    
}